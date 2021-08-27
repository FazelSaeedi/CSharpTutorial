using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace ADO_Library
{
    partial class Program
    {
        public  class Database
        {


            public IDbConnection _connection = null;
            public IDbCommand _cmd = null;


            public Database()
            {
                this._connection = new SqlConnection(getConnectionString());
                this._cmd = _connection.CreateCommand();
            }


            public Database AddParameter<T>(string name , T value)
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = name;
                param.Value = value;
                _cmd.Parameters.Add(param);
                return this;
            }


            public int ExecuteNonQuery(string query , bool isStoredProc = false)
            {

                int noOfAffectedRows = 0;
                StringBuilder errorMessages = new StringBuilder();

                try
                {
                    using (_connection)
                    {

                        if (isStoredProc)
                        {
                            _cmd.CommandType = CommandType.StoredProcedure;
                        }

                        _cmd.CommandText = query;
                        _connection.Open();
                        noOfAffectedRows = _cmd.ExecuteNonQuery();
                    }
                }
                catch(SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());
                }

                return noOfAffectedRows;

            }


            public IEnumerable<T> ExecuteQuery<T>(string query , bool isStoredProc = false)
            {
                IList<T> list = new List<T>();
                Type t = typeof(T);

                using(_connection)
                {
                    if (isStoredProc)
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;
                    }

                    _cmd.CommandText = query ;
                    _connection.Open();
                    var reader = _cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        T obj = (T)Activator.CreateInstance(t);
                        t.GetProperties().ToList().ForEach(p =>
                        {

                            if(reader[p.Name] == DBNull.Value)
                                p.SetValue(obj, DateTime.MinValue);
                            else
                                p.SetValue(obj, reader[p.Name]);

                        });

                        list.Add(obj);
                    }

                    
                }
                return list;
            }


            public T ExecuteScalar<T> (string query ,  bool isStoredProc = false)
            {
                T result = default(T);

                using (_connection)
                {
                    if (isStoredProc)
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;
                    }
                    _cmd.CommandText = query;
                    _connection.Open();
                    result = (T)_cmd.ExecuteScalar();
                }

                return result;
            }


            public string getConnectionString()
            {
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                TextReader tr = new StreamReader(@"ConnectionString.txt");
                return  tr.ReadLine();
            }


        }
    }
}

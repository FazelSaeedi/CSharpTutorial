using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using ADO_Library.Models.User;
using ADO_Library.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ADO_Library
{
    partial class Program
    {
        
        static void Main(string[] args)
        {



            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IDbRepository, DbRepository>();



            var serviceProvider = serviceCollection.BuildServiceProvider();
            var repositoryService  = serviceProvider.GetRequiredService<IDbRepository>();



            var users =repositoryService.getUsers();
            var books =repositoryService.getBooks();
            var shelves =repositoryService.getUsersShelves(1);
            var usersBooksCount =repositoryService.getUsersBooksCount(1);
            var unReadedUserBooksCount =repositoryService.UnReadedUserBooksCount(1);
            var userBooksStatus =repositoryService.GetBooksStatus(1);









            // Some Example --------------------------------------------------------------------------------



            /* 
             SqlConnection con = new SqlConnection(cs);
             SqlCommand cmd = new SqlCommand("select * from Shelves", con);
             con.Open();
             SqlDataReader reader = cmd.ExecuteReader();
             
             if (reader.HasRows)
             {
                 while (reader.Read())
                 {
                     Console.WriteLine(reader[0].ToString());
                     //Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                     //    reader.GetString(1));
                 }
             }
             else
             {
                 Console.WriteLine("No rows found.");
             }
             reader.Close();
             con.Close();
             */

            //-------------------------------------------------------------------------------------------


             /*INSERT INTO Shelves(title, userId, createDate)
             VALUES
             ('shelf1', 1, '2633-09-09 22:34:09.000'), 


             define INSERT query with parameters

             string query = "INSERT INTO dbo.Shelves (title, userId, createDate) " +
                            "VALUES ('shelf1222222', 1, '2633-09-09 22:34:09.000')";
             
             // create connection and command
             using (SqlConnection cn = new SqlConnection(cs))
             using (SqlCommand cmd = new SqlCommand(query, cn))
             {
                 // open connection, execute INSERT, close connection
                 cn.Open();
                 cmd.ExecuteNonQuery();
                 cn.Close();
             }*/



            //-------------------------------------------------------------------------------

            /* string query = "DELETE  dbo.Shelves where id = 6";
             
             // create connection and command
             using (SqlConnection cn = new SqlConnection(cs))
             using (SqlCommand cmd = new SqlCommand(query, cn))
             {
                 // open connection, execute INSERT, close connection
                 cn.Open();
                 cmd.ExecuteNonQuery();
                 cn.Close();
             }*/

            //------------------------------------------------------------------------------


             /*string query = "UPDATE  dbo.Shelves set title = 'wwwww' where id = 1";
             
             // create connection and command
             using (SqlConnection cn = new SqlConnection(cs))
             using (SqlCommand cmd = new SqlCommand(query, cn))
             {
                 // open connection, execute INSERT, close connection
                 cn.Open();
                 cmd.ExecuteNonQuery();
                 cn.Close();
             }*/

            //------------------------------------------------------------------------------


            /* List<Users> users = new List<Users>();
             
             using (SqlConnection con = new SqlConnection(cs))
             {
                 using (SqlCommand cmd = new SqlCommand("select * from Users", con))
                 {
                     cmd.CommandType = CommandType.Text;
                     using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                     {
                         DataSet ds = new DataSet();
                         sda.Fill(ds);
                         foreach (DataRow row in ds.Tables[0].Rows)
                         {
                             Console.WriteLine(row.ItemArray[3]);
                             Users user = new Users();
             
                             user.id = (int)row.ItemArray[0];
                             
                             user.firstName  =   (string)row.ItemArray[1];
                             user.lastName   =    (string)row.ItemArray[2];
                             user.userName   =    (string)row.ItemArray[3];
                             user.password   =    (string)row.ItemArray[4];
                             user.phone      =    (string)row.ItemArray[5];
                             user.isActive   =    (bool)row.ItemArray[6];
                             user.createDate =  (DateTime)row.ItemArray[7];
                             user.updateDate =  DateTime.Now;
                             users.Add(user); 
             
                                                         
                         }
                     }
                 }
             }*/


            //-----------------------------------------------------------------------


             /*  var  D1 = new Database()
                .ExecuteQuery<Users>("select * from Users where id = 1");




            var D2 = new Database(cs)
                .AddParameter("@title", "sh232elsqqd")
                .AddParameter("@userId", 1)
                .AddParameter("@createDate", "2633-09-09 22:34:09.000")
                .AddParameter("@updateDate", DBNull.Value)
                .ExecuteNonQuery("insert into Shelves values(@title ,@userId,@createDate , @updateDate) ");



            var D3 = new Database(cs)
                 //.AddParameter("@id", 10)
                 .AddParameter("@firstName", "firstName5")
                 .AddParameter("@lastName", "lastName1")
                 .AddParameter("@userName", "User12")
                 .AddParameter("@password", "password4")
                 .AddParameter("@phone", "9366285490")
                 .AddParameter("@isActive", true)
                 .AddParameter("@createDate", "2633-09-09 22:34:09.000")
                 .AddParameter("@updateDate", DBNull.Value)
                 .ExecuteNonQuery("insert into Users values(@firstName , @lastName , @userName , @password , @phone , @isActive , @createDate , @updateDate) ");




             var D4 = new Database(cs)
                 .AddParameter("@id", 8)
                 .AddParameter("@title", "new title")
                 .ExecuteNonQuery("update  Shelves set title=@title where id=@id");




             var D5 = new Database(cs)
                 .AddParameter( "@id", 8 )
                 .ExecuteNonQuery("delete from  Shelves where id=@id");



             var D6 = new Database(cs)
                 .ExecuteScalar<int>("select count(*) from Shelves");


            var result = new Database(cs).ExecuteQuery<Users>("getUsers", true).Where(x => x.id.Equals(1));
            
            
            var isInsert = new Database(cs).Insert<Users>(new Users 
            {  
                firstName = "fazel",
                lastName = "saeedi",
                isActive = true ,
                password = "PwW" ,
                phone = "09367385660",
            });;*/


        }
    }
}

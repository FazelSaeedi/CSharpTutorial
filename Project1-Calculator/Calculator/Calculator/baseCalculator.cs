using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseCalculator
{
    public abstract class baseCalculator
    {

        protected abstract string HistoryAddress { get; set; }
        protected bool HistoryStatus { get;  set; } = false ;
        public bool ExitStatus { get; protected set; } = false ;
        protected string Input { get; set; }
        protected string Decition { get; set; }
        protected double Result { get; set; }
        protected enum Method { separate , expression }
        protected enum Action { history, finish }
        protected enum MathOperator{ sum , subtract , multiply , divide};
        public abstract void Run();
        public string DisplayResult()
        {
            // return Convert.ToString(this.Result);
            string text = File.ReadAllText(this.HistoryAddress);
            return text;
        }

        public void CreateFile()
        {
            FileStream fs; 
            if (File.Exists(this.HistoryAddress))
            {
                File.Delete(this.HistoryAddress);
            }
            fs = File.Create(this.HistoryAddress);
            fs.Close();
        }

        public void Appendresult(string newResult)
        {
            File.AppendAllText(this.HistoryAddress, newResult+ "\n");
        }



    }

}

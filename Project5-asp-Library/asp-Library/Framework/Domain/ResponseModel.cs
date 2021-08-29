using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    public class ResponseModel<T>
    {
        public string message { get; set; }
        public int statusCode { get; set; }
        public T data { get; set; } 

        public int Count { get; set; }
        public ResponseModel(T data, string message, int statusCode)
        {
            this.data = data;
            this.message = message;
            this.statusCode = statusCode;
        }

        public ResponseModel(int count, string message, int statusCode)
        {
            this.Count = count;
            this.message = message;
            this.statusCode = statusCode;
        }

        public ResponseModel(string message, int statusCode)
        {
            this.message = message;
            this.statusCode = statusCode;
        }
    }
}

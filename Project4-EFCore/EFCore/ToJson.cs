using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EFCore
{
    public class ToJson : JsonResult
    {
        private readonly HttpStatusCode _statusCode;

        public ToJson(object json) : this(json, HttpStatusCode.InternalServerError)
        {
        }

        public ToJson(object json, HttpStatusCode statusCode) : base(json)
        {
            _statusCode = statusCode;
        }

        public override void ExecuteResult(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)_statusCode;
            base.ExecuteResult(context);
        }

        public override Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)_statusCode;
            //context.HttpContext.Response.Headers.Add("totalHeader", "ww");
            return base.ExecuteResultAsync(context);
        }
    }
}

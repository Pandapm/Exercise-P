﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMLib
{
    /// <summary>
    /// LoginOff 的摘要说明
    /// </summary>
    public class LoginOff : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            //context.Session["Name"]
            //context.Response.Redirect("~/Home");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
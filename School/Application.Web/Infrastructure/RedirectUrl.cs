﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Application.Web.Infrastructure
{
    public class RedirectUrl
    {
        private string redirectAreaName;

        private string redirectControllerName;

        private string redirectActionName;

        private RouteValueDictionary redirectParameters;

        public RedirectUrl(ControllerContext controllerContext, RouteValueDictionary redirectParameters)
        {
            this.redirectControllerName = controllerContext.RouteData.Values["controller"].ToString();
            this.redirectActionName = controllerContext.RouteData.Values["action"].ToString();
            this.redirectParameters = redirectParameters;
        }

        public string RedirectAreaName 
        {
            get { return this.redirectAreaName; }
            set { this.redirectAreaName = value; }
        }

        public string RedirectControllerName
        {
            get { return this.redirectControllerName; }
            set { this.redirectControllerName = value; }
        }

        public string RedirectActionName
        {
            get { return this.redirectActionName; }
            set { this.redirectActionName = value; }
        }

        public RouteValueDictionary RedirectParameters
        {
            get { return this.redirectParameters; }
            set { this.redirectParameters = value; }
        }
    }
}
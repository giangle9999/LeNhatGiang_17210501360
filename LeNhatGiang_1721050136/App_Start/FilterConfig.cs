﻿using System.Web;
using System.Web.Mvc;

namespace LeNhatGiang_1721050136
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

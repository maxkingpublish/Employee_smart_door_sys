﻿using System.Web;
using System.Web.Mvc;

namespace Employee_smart_door_sys
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace TT_BANHANG_AZURE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

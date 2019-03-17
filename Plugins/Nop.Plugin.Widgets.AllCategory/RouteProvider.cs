using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Widgets.AllCategory
{
    class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Plugin.Widgets.AllCategory.AllCategories", "AllCategories",
                new { controller = "AllCategory", action = "AllCategories" });
        }

        public int Priority
        {
            get
            {
                return -1;
            }
        }
    }
}

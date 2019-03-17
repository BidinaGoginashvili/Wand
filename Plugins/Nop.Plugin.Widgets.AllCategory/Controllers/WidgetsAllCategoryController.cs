using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Nop.Web.Areas.Admin.Models.Catalog;

namespace Nop.Plugin.Widgets.AllCategory.Controllers
{
    [Area(AreaNames.Admin)]
    public class WidgetsAllCategoryController : BasePluginController
    {
        public IActionResult Configure()
        {
            return View("~/Plugins/Widgets.AllCategory/Views/Configure.cshtml");
        }
    }
}

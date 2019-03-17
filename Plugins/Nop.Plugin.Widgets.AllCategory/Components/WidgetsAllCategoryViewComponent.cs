using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Text;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Core;
using Nop.Core.Caching;

namespace Nop.Plugin.Widgets.AllCategory.Components
{
    [ViewComponent(Name = "WidgetsAllCategory")]
    public class WidgetsAllCategoryViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly IStaticCacheManager _cacheManager;
        private readonly ISettingService _settingService;
        private readonly IPictureService _pictureService;

        public WidgetsAllCategoryViewComponent(IStoreContext storeContext,
            IStaticCacheManager cacheManager,
            ISettingService settingService,
            IPictureService pictureService)
        {
            this._storeContext = storeContext;
            this._cacheManager = cacheManager;
            this._settingService = settingService;
            this._pictureService = pictureService;
        }
        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            return View("~/Plugins/Widgets.AllCategory/Views/PublicInfo.cshtml");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core;
using Nop.Core.Infrastructure;
using Nop.Core.Plugins;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.AllCategory
{
    class WidgetsAllCategory : BasePlugin, IWidgetPlugin
    {
        private readonly ILocalizationService _localizationService;
        private readonly Services.Media.IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;
        private readonly INopFileProvider _fileProvider;

        public WidgetsAllCategory(ILocalizationService localizationService,
            IPictureService pictureService,
            ISettingService settingService,
            IWebHelper webHelper,
            INopFileProvider fileProvider)
        {
            this._localizationService = localizationService;
            this._pictureService = pictureService;
            this._settingService = settingService;
            this._webHelper = webHelper;
            this._fileProvider = fileProvider;
        }


        public override string GetConfigurationPageUrl()
        {
            return _webHelper.GetStoreLocation() + "Admin/WidgetsAllCategory/Configure";
        }
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetsAllCategory";
        }
        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.HeaderMenuBefore };//HeaderLinksBefore PIRVELI MENIU
        }

        public override void Install()
        {
            base.Install();
        }

        public override void Uninstall()
        {
            base.Uninstall();
        }
    }
}

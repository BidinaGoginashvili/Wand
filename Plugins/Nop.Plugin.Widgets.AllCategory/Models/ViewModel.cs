using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Media;
using Nop.Core.Domain.Seo;
using Nop.Services.Catalog;
using Nop.Services.Media;
using Nop.Services.Seo;

namespace Nop.Plugin.Widgets.AllCategory.Models
{
    public class ViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Picture> Pictures { get; set; }
        public IList<UrlRecord> UrlRecords { get; set; }
        public UrlRecord UrlRecord { get; set; }
        public Category Category { get; set; }
        public Picture Picture { get; set; }
    }
}

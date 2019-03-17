using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Nop.Core.Domain.News;
using Nop.Web.Factories;
using Nop.Web;
using Nop.Web.Models.Catalog;
using Nop.Web.Models.Media;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Data;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Media;
using Nop.Core.Infrastructure;
using Nop.Data.Mapping.Catalog;
using Nop.Services.Catalog;
using Nop.Web.Framework.Kendoui;
using Nop.Services.Seo;
using Nop.Core.Domain.Seo;
using Nop.Plugin.Widgets.AllCategory.Models;
using Nop.Services.Media;

namespace Nop.Plugin.Widgets.AllCategory.Controllers
{
    public class AllCategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IPictureService _pictureService;
        public AllCategoryController(ICategoryService categoryService, IUrlRecordService urlRecordService, IPictureService pictureService)
        {
            this._urlRecordService = urlRecordService;
            this._categoryService = categoryService;
            this._pictureService = pictureService;
        }

        public ActionResult AllCategories()
        {
            List<Category> CategoriesModel = _categoryService.GetAllCategories() as List<Category>;
            List<Picture> PicturesModel = _pictureService.GetPictures() as List<Picture>;
            List<UrlRecord> UrlRecordsModel = _urlRecordService.GetAllUrlRecords() as List<UrlRecord>;
            Category CategoryModel = new Category();
            Picture PictureModel = new Picture();
            UrlRecord UrlRecordModel = new UrlRecord();
            var ViewModel = new ViewModel();
            ViewModel.Categories = CategoriesModel.ToList();
            ViewModel.Pictures = PicturesModel.ToList();
            ViewModel.UrlRecords = UrlRecordsModel.ToList();
            ViewModel.Category = CategoryModel;
            ViewModel.Picture = PictureModel;
            ViewModel.UrlRecord = UrlRecordModel;
            return View("~/Plugins/Widgets.AllCategory/Views/AllCategory.cshtml", ViewModel);
        }
    }
}

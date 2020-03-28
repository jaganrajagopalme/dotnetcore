using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webappsdemo.Models;

namespace Webappsdemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepo _prodData;
        private readonly IDepartmentRepo _departData;
        public HomeController(IProductRepo ProductRepo,IDepartmentRepo DepartmentRepo)
        {
            _prodData = ProductRepo;
            _departData = DepartmentRepo;
        }
        public ViewResult Index()
        {
            List<Products> productModel = _prodData.FetchProductInfo();
            return View(productModel);

        }

        //public ViewResult Details()
        //{
        //    List<Products> productModel = _prodData.FetchProductInfo();
        //    return  View( productModel);
        //}

       [HttpGet]
        public ViewResult Details(int id)
        {
            Products productModel = _prodData.GetProductInfodata(id);
            return View(productModel);
        }
        public ViewResult MyDataView()
        {
            return View("/Myviews/customview.cshtml");
        }

        //Explaination of ViewData
        public ViewResult ViewDataExample()
        {
            Products productModel = _prodData.GetProductInfodata(1);
            ViewData["Productdata"] = productModel;
            ViewData["PageTitle"] = "ViewBag demo";
            return View();
        }

        //Explaination of ViewData
        public ViewResult ViewBagDemo()
        {
            Products productModel = _prodData.GetProductInfodata(1);
            ViewBag.Product = productModel;
            ViewBag.PageTitle = "ViewBag demo";
            return View();
        }

        //Explaintion of strong type data

        public ViewResult StrongtypeView()
        {
            Products productModel = _prodData.GetProductInfodata(1);
           // ViewBag.Product = productModel;
            ViewBag.PageTitle = "ViewBag demo";
            return View(productModel);
        }

        public ViewResult DepartmentList()
        {
            var departmentModel = _departData.GetlistDepartment();
            return View(departmentModel);

        }

        //Explaination for ViewLayout view 
        public ViewResult ViewLayoutDemo()
        {

            var departmentModel = _departData.GetlistDepartment();
            return View(departmentModel);
        }

        public ViewResult create()
        {
            return View();
        }

        //redirect the create page

        [HttpPost]
        public IActionResult Create(Products productdata)
        {
            if (ModelState.IsValid)
            {
                Products NewProducts = _prodData.AddProducts(productdata);
                return RedirectToAction("details", new { id = NewProducts.ProductId });
            }
            return View();
        }

    }
}
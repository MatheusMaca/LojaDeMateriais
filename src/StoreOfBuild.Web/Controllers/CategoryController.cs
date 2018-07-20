using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Web.Models;
using StroreOfBuild.Domain.Dtos;
using StroreOfBuild.Domain.Products;

namespace StoreOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStorer _categoryStorer;

        public CategoryController(CategoryStorer categoryStorer)
        {
            _categoryStorer = categoryStorer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryDto dto)
        {
            return View();
        }
    }
}

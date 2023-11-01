using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;
using SaleWeb.ViewModels;

namespace SaleWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductManagementController : Controller
    {
        private readonly ProductRepository productRepository = new ProductRepository();
        // GET: Admin/ProductManagement

        public IActionResult Index()
        {
            var listDefault = productRepository.GetProducts();
            return View(listDefault);
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm][Bind("productName, unitPrice")] string? productName, string? unitPrice)
        {
            List<Product> list = new List<Product>();
            if (!string.IsNullOrWhiteSpace(productName) || !string.IsNullOrWhiteSpace(unitPrice))
            {
                if (productName != null)
                {
                    var productByName = productRepository.GetProductbyProductName(productName);
                    list.Add(productByName);
                }
                if (unitPrice != null)
                {
                    var productbyPrice = productRepository.GetProducts().Where(p => p.UnitPrice == decimal.Parse(unitPrice)).ToList();
                    if (productbyPrice.Count > 0) list.AddRange(productbyPrice);
                }
                return View(list);
            }

            var listDefault = productRepository.GetProducts();
            return View(listDefault);
        }

        // GET: Admin/ProductManagement/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productRepository.GetProducts().Where(x => x.ProductId == id).First();

            return View(product);
        }

        // GET: Admin/ProductManagement/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductManagement/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,ProductName,Weight,UnitPrice,UnitsInStock")] CreateProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                Product p = new Product();
                p.ProductName = product.ProductName;
                p.UnitPrice = product.UnitPrice;
                p.Weight = product.Weight;
                p.CategoryId = product.CategoryId;
                p.UnitsInStock = product.UnitsInStock;
                productRepository.CreateProduct(p);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Admin/ProductManagement/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productRepository.GetProducts().Where(x => x.ProductId == id).First();
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Admin/ProductManagement/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,ProductName,Weight,UnitPrice,UnitsInStock")] CreateProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var p = productRepository.GetProducts().Where(x => x.ProductId == id).First();
                p.Weight = product.Weight;
                p.UnitPrice = product.UnitPrice;
                p.ProductName = product.ProductName;
                p.CategoryId = product.CategoryId;
                p.UnitsInStock = product.UnitsInStock;
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Admin/ProductManagement/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var product = productRepository.GetProducts().Where(x => x.ProductId == id).First();
            return View(product);
        }

        // POST: Admin/ProductManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string productName)
        {
            productRepository.DeleteProduct(productName);
            return RedirectToAction(nameof(Index));
        }
    }
}
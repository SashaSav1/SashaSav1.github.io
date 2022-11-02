using GODDAMN.Data;
using GODDAMN.Interfaces;
using GODDAMN.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace GODDAMN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAllProducts allProducts;
        private readonly IProductsCategory allCategories;
        private readonly ApplicationDbContext _context;
        public List<Product> Products { get; set; }
        public List<Basket> Baskets { get; set; }
        public List<MorW> MorWs { get; set; }


        Basket abc = new Basket();
        MorW morw = new MorW();



        public HomeController(ILogger<HomeController> logger, IAllProducts iAllProducts, IProductsCategory iProductsCat, ApplicationDbContext db)
        {
            _logger = logger;
            allProducts = iAllProducts;
            allCategories = iProductsCat;
            _context = db;
        }
        [HttpPost]
        public async Task<IActionResult> MorW(string c)
        {
            morw.Name = c;


            if (c == "M")
            {
                _context.MorWs.Add(morw);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index1");

            }
            else
            {
                _context.MorWs.Add(morw);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index2");
            }
        }

        public IActionResult Index()
        {   

            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }



        public IActionResult Basket()
        {
            Baskets = _context.Baskets.AsNoTracking().ToList();
            Products = _context.Products.AsNoTracking().ToList();
            Baskets.Reverse();
            var model = Tuple.Create<IEnumerable<Basket>, IEnumerable<Product>>(Baskets, Products);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int a)
        {
            if (a != 0)
            {
                Basket basket = await _context.Baskets.FindAsync(a);
                if (basket != null)
                {
                    _context.Baskets.Remove(basket);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Basket");
                }
            }
            return NotFound();
        }

        public IActionResult Shoes()
        {
            ViewBag.Category = "Обувь";
            ViewBag.UserId = "";
            Products = _context.Products.AsNoTracking().ToList();
            MorWs = _context.MorWs.AsNoTracking().ToList();
            MorWs.Reverse();
            var model = Tuple.Create<IEnumerable<Product>, IEnumerable<MorW>>(Products, MorWs);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(string a, int b, string c)
        {
            abc.UserId = a;
            abc.ProductId = b;
            if (c == "Shoes")
            {
                if (ModelState.IsValid)
                {
                    _context.Baskets.Add(abc);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Shoes");
                }
            }
            else if (c == "Hats")
            {
                if (ModelState.IsValid)
                {
                    _context.Baskets.Add(abc);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Hats");
                }
            }
            else if (c == "Pants")
            {
                if (ModelState.IsValid)
                {
                    _context.Baskets.Add(abc);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Pants");
                }

            }
            else if (c == "Sweatshirts")
            {
                if (ModelState.IsValid)
                {
                    _context.Baskets.Add(abc);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Sweatshirts");
                }

            }
            else if (c == "About")
            {
                if (ModelState.IsValid)
                {
                    _context.Baskets.Add(abc);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Basket");
                }
            }

            return RedirectToAction("Shoes");
        }

        public IActionResult Pants()
        {
            ViewBag.Category = "Штаны";
            Products = _context.Products.AsNoTracking().ToList();
            MorWs = _context.MorWs.AsNoTracking().ToList();
            MorWs.Reverse();
            var model = Tuple.Create<IEnumerable<Product>, IEnumerable<MorW>>(Products, MorWs);
            return View(model);
        }

        public IActionResult Sweatshirts()
        {
            ViewBag.Category = "Кофты";
            Products = _context.Products.AsNoTracking().ToList();
            MorWs = _context.MorWs.AsNoTracking().ToList();
            MorWs.Reverse();
            var model = Tuple.Create<IEnumerable<Product>, IEnumerable<MorW>>(Products, MorWs);
            return View(model);
        }

        public IActionResult Hats()
        {
            ViewBag.Category = "Головные уборы";
            Products = _context.Products.AsNoTracking().ToList();
            MorWs = _context.MorWs.AsNoTracking().ToList();
            MorWs.Reverse();
            var model = Tuple.Create<IEnumerable<Product>, IEnumerable<MorW>>(Products, MorWs);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AboutProduct(int a)
        {
            //Basket basket = await _context.Baskets.FindAsync(a);

            ViewBag.Name = "О товаре";
            Product product =  await _context.Products.FindAsync(a);
            return View(product);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class what
    {
        public string a { get; set; }

        public what(string a)
        {
            this.a = a;
        }
    }
}

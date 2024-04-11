using AutoMapper;
using BooksShop.Data;
using Microsoft.AspNetCore.Mvc;
using BooksShop.Extensions;
using Microsoft.EntityFrameworkCore;
using BooksShop.Models;

namespace BooksShop.Controllers
{
    public class CartController : Controller
    {
        private BooksShopDbContext context;
        private readonly IMapper mapper;

        public CartController(BooksShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);
            if (ids == null) ids = new List<int>();

            var entities = context.Books                                    
                                    .Where(x => ids.Contains(x.Id))
                                    .ToList();
            var list = mapper.Map<List<BookCartModel>>(entities);

            return View(list);
        }
        public IActionResult Append(int id)
        {
            // отримуємо дані з корзини
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);

            // якщо корзина порожня, створюємо список
            if (ids == null) ids = new List<int>();

            // додаємо новий елемент
            ids.Add(id);

            // зберігаємо новий список в корзині
            HttpContext.Session.Set(WebConstants.CART_KEY, ids);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Remove(int id)
        {
            // отримуємо дані з корзини
            var ids = HttpContext.Session.Get<List<int>>(WebConstants.CART_KEY);

            if (ids != null) ids.Remove(id);

            // зберігаємо новий список в корзині
            HttpContext.Session.Set(WebConstants.CART_KEY, ids);

            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            HttpContext.Session.Remove(WebConstants.CART_KEY);

            return RedirectToAction("Index");
        }
    }
}

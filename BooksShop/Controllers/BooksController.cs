using BooksShop.Data;
using BooksShop.Data.Entities;
using BooksShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace BooksShop.Controllers
{
    public class BooksController : Controller
    {
        private BooksShopDbContext context;
        public BooksController(BooksShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var books = context.Books.Include(x => x.Category).ToList();
            LoadCategories();
            //LoadAuthors();
            //return View();
            return View(books);
        }
        private void LoadCategories()
        {
            var categories = new SelectList(context.Categories.ToList(), nameof(Category.Id), nameof(Category.Name));
            ViewBag.Categories = categories;
        }
        private void LoadAuthors()
        {
            var authors = new SelectList(context.Authors.ToList(), nameof(Category.Id), nameof(Category.Name));
            ViewBag.Authors = authors;
        }
    }
}

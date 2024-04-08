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
            var books = context.Books.Include(x => x.Category).Include(x => x.Author).ToList();
            LoadCategories();
            LoadAuthors();       
            
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadCategories();
            LoadAuthors();

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateBookModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                LoadAuthors();
                return View(model);
            }

            var entity = new Book()
            {
                Name = model.Name,
                Price = model.Price,
                Discount = model.Discount,
                InStock = model.InStock,
                ImageUrl = model.ImageUrl,
                Quantity = model.Quantity,
                Year = model.Year,
                CategoryId = model.CategoryId,
                AuthorId = model.AuthorId
            };

            context.Books.Add(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var item = context.Books.Find(id);
            if (item == null) return NotFound();

            LoadCategories();
            LoadAuthors();

            var model = new EditBookModel()
            {
                Name = item.Name,
                Price = item.Price,
                Discount = item.Discount,
                InStock = item.InStock,
                ImageUrl = item.ImageUrl,
                Quantity = item.Quantity,
                Year = item.Year,
                CategoryId = item.CategoryId,
                AuthorId = item.AuthorId
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EditBookModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadCategories();
                LoadAuthors();
                return View(model);
            }

            var entity = new Book()
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                Discount = model.Discount,
                InStock = model.InStock,
                ImageUrl = model.ImageUrl,
                Quantity = model.Quantity,
                Year = model.Year,
                CategoryId = model.CategoryId,
                AuthorId = model.AuthorId
            };

            context.Books.Update(entity);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var item = context.Books.Find(id);
            if (item == null) return NotFound();

            context.Books.Remove(item);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Filter(int? categoryId)
        {
            if (categoryId == null)
                return RedirectToAction("Index");

            var books = context.Books
                            .Include(x => x.Category)
                            .Where(x => x.CategoryId == categoryId)
                            .ToList();

            LoadCategories();
            return View("Index", books);
        }
        private void LoadCategories()
        {
            var categories = new SelectList(context.Categories.ToList(), nameof(Category.Id), nameof(Category.Name));
            ViewBag.Categories = categories;
        }
        private void LoadAuthors()
        {
            var authors = new SelectList(context.Authors.ToList(), nameof(Author.Id), nameof(Author.Name));
            ViewBag.Authors = authors;
        }
    }
}

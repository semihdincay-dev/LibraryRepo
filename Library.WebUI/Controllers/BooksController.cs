using Library.BLL;
using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.WebUI.Controllers
{
    public class BooksController : Controller
    {
        BookRepository repo = new BookRepository();
        // GET: Books
        public ActionResult Index()
        {
            List<Book> bookList = repo.GetAll();

            return View(bookList);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Book entity)
        {
            repo.Add(entity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Book entity)
        {
            repo.Update(entity);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Book book = repo.GetById(id);
            return View(book);
        }

        public ActionResult Delete(int id)
        {
            Book book = repo.GetById(id);

            repo.Delete(book);
            return RedirectToAction("Index");
        }

    }
}
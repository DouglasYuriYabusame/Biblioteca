using BibliotecaVesp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVesp.Controllers
{
    public class LivroController : Controller
    {

        public Contexto Contexto;

        public LivroController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: LivroController
        public ActionResult Index()
        {
            List<Livro> lista = Contexto.Livros.ToList();
            return View(lista);
        }

        // GET: LivroController/Details/5
        public ActionResult Details(int id)
        {
            Livro livro = Contexto.Livros.Where(e => e.Idlivro == id).First();
            return View(livro);
        }

        // GET: LivroController/Create
        public ActionResult Create()
        {
            Livro livro = new Livro();
            return View(livro);
        }

        // POST: LivroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Livro novoLivro)
        {
            try
            {
                Contexto.Livros.Add(novoLivro);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET:LivroController/Edit/5
        public ActionResult Edit(int id)
        {
            Livro livro = Contexto.Livros.Where(e => e.Idlivro == id).First();
            return View(livro);
        }

        // POST: LivroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Livro livro)
        {
            try
            {

                Contexto.Update(livro);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivroController/Delete/5
        public ActionResult Delete(int id)
        {
            Livro livro = Contexto.Livros.Where(e => e.Idlivro == id).First();
            return View(livro);
        }

        // POST: LivroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Livro livro)
        {
            try
            {

                Contexto.Remove(livro);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
using BibliotecaVesp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVesp.Controllers
{
    public class AmigoController : Controller
    {

        public Contexto Contexto;

        public AmigoController(Contexto NovoContexto)
        {
            this.Contexto = NovoContexto;
        }

        // GET: AmigoController
        public ActionResult Index()
        {
            List<Amigo> lista = Contexto.Amigos.ToList();
            return View(lista);
        }

        // GET: AmigoController/Details/5
        public ActionResult Details(int id)
        {
            Amigo amigo = Contexto.Amigos.Where(e => e.Idamigo == id).First();
            return View(amigo);
        }

        // GET: AmigoController/Create
        public ActionResult Create()
        {
            Amigo amigo = new Amigo();
            return View(amigo);
        }

        // POST: AmigoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Amigo novoAmigo)
        {
            try
            {
                Contexto.Amigos.Add(novoAmigo);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AmigoController/Edit/5
        public ActionResult Edit(int id)
        {
            Amigo amigo = Contexto.Amigos.Where(e => e.Idamigo == id).First();
            return View(amigo);
        }

        // POST: AmigoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Amigo amigo)
        {
            try
            {

                Contexto.Update(amigo);
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AmigoController/Delete/5
        public ActionResult Delete(int id)
        {
            Amigo amigo = Contexto.Amigos.Where(e => e.Idamigo == id).First();
            return View(amigo);
        }

        // POST: AmigoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Amigo amigo)
        {
            try
            {

                Contexto.Remove(amigo);
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

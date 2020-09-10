using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAzure.Models;

namespace WebAzure.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly Contexto contexto;

        public UsuariosController(Contexto _contexto)
        {
            contexto = _contexto;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(contexto.Usuario.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View(contexto.Usuario.Find(id));
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View(new Usuario());
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario collection)
        {
            try
            {
                // TODO: Add insert logic here
                contexto.Usuario.Add(collection);
                contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View(contexto.Usuario.Find(id));
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuario collection)
        {
            try
            {
                contexto.Usuario.Update(collection);
                contexto.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View(contexto.Usuario.Find(id));
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Usuario collection)
        {
            try
            {
                contexto.Usuario.Remove(collection);
                contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
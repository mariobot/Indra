using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLoyic;
using BussinessObject;

namespace Indra.Controllers
{
    public class RegistroController : Controller
    {
        private readonly RegistroBL _registroBL;

        public RegistroController()
        {
            _registroBL = new RegistroBL();
        }

        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registro/Create
        [HttpPost]        
        public ActionResult Create(UsuarioBO _usuarioBO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ValidarBL.Nombre(_usuarioBO.Nombre))
                    {
                        _registroBL.AlmacenarRegistro(_usuarioBO);
                        ViewBag.Message = null;
                        return RedirectToAction("Index");
                    }
                    else                    
                        ViewBag.Message = String.Format("El nombre {0} no es valido, no se encuentra en la lista permitida",_usuarioBO.Nombre);                                     
                }

                return View(_usuarioBO);
            }
            catch
            {
                return View(_usuarioBO);
            }
        }

        // GET: Registro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]        
        public ActionResult Create(UsuarioBO _usuarioBO)
        {
            double total = 0;

            try
            {
                if (ModelState.IsValid)
                {
                    if (ValidarBL.Nombre(_usuarioBO.Nombre))
                    {
                        total = _registroBL.AlmacenarRegistro(_usuarioBO);
                        ViewBag.Message = null;
                        ViewBag.Total = String.Format("Resultado: {0}", total);
                        return View(_usuarioBO);
                    }
                    else { 
                        ViewBag.Message = String.Format("El nombre {0} no es valido, no se encuentra en la lista permitida",_usuarioBO.Nombre);
                        ViewBag.Total = String.Format("Resultado: {0}", total);
                    }
                }

                return View(_usuarioBO);
            }
            catch
            {
                return View(_usuarioBO);
            }
        }        

        [HttpGet]
        public ActionResult Consultar(string Nombre, double? RespuestaMin, double? RespuestaMax)
        {
            var registros = _registroBL.TotalRegistros();

            registros = FiltrarBL.Filtrar(registros, Nombre, RespuestaMin, RespuestaMax);

            return View(registros);
        }        

        // GET: Registro/Delete/5
        public ActionResult Delete(int id)
        {
            var registro = _registroBL.TotalRegistros().Where(p => p.ID == id).FirstOrDefault();

            if (ValidarBL.FechaEliminacion(registro.FechaRegistro))
                ViewBag.Delete = true;
            else
                ViewBag.Delete = false;
            
            return View(registro);
        }

        // POST: Registro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, RegistroBO _registroBO)
        {
            try
            {
                // TODO: Add delete logic here
                _registroBL.EliminarRegistro(_registroBO);

                return RedirectToAction("Consultar");
            }
            catch
            {
                return View();
            }
        }
    }
}

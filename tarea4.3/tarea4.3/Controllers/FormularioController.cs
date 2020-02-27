using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tarea4._3.Models;
using System.IO;


namespace tarea4._3.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult  Resultado(Formulario forr)
        {
            if (ModelState.IsValid)
            {
                if (forr.Foto != null && forr.Curriculum != null)
                {


                    string nombreFoto = "foto_" + DateTime.Now.ToString("ddMMyyHHmmss") +
                        Path.GetExtension(forr.Foto.FileName);
                    forr.Foto.SaveAs(Path.Combine(Server.MapPath("~/Fotos/"), nombreFoto));

                    ViewBag.foto = nombreFoto;

                    string nombreCurri = "curriculum_" + DateTime.Now.ToString("ddMMyyHHmmss") +
                        Path.GetExtension(forr.Curriculum.FileName);
                    forr.Curriculum.SaveAs(Path.Combine(Server.MapPath("~/Curriculums/"), nombreCurri));
                    ViewBag.curri = nombreCurri;
                    ViewBag.StatusCurri = "Currículum Enviado";
                    return View(forr);
                }

            }
            ViewBag.StatusFoto = "Error al enviar la foto";
            ViewBag.StatusCurri = "Error al enviar el currículum";
            return View(forr);

        }
    }
}
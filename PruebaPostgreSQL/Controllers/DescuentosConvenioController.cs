using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using PruebaPostgreSQL.Models;

namespace PruebaPostgreSQL.Controllers
{
    public class DescuentosConvenioController : Controller
    {
        private List<DescuentoPorConvenio> _arrayListDescuentos;

        private List<DescuentoPorConvenio> _lstDescuentosIndividuales;

        private string[] _lstSucursalesFilter;

        private int _proximoNumeroDisponible;

        private string[] _tipoDocuemnto;

        private string _detalle;

        private DateTime _fecha;

        private string _tipoDocumento;

        // GET: DescuentosConvenio
        public ActionResult Index()
        {
            _arrayListDescuentos = new List<DescuentoPorConvenio>() {
                new DescuentoPorConvenio(){
                    Id=1,
                    Sucursal="Pasto",
                    Convenio="Convenio1",
                    Identifnicacion="1085309822",
                    Nombre="juan",
                    Modulo="modulo1",
                    Concepto="conepto1",
                    Credito="credito1",
                    FechaVencimiento= DateTime.Now,
                    Cuota="130,000",
                    ValorDefinitivo="130,000",
                    FormaPago="Efecivo",
                    ValorDistinto=""
                },
                new DescuentoPorConvenio(){
                    Id=2,
                    Sucursal="Cali",
                    Convenio="Convenio2",
                    Identifnicacion="1085309824",
                    Nombre="diego",
                    Modulo="modulo2",
                    Concepto="conepto2",
                    Credito="credito2",
                    FechaVencimiento= DateTime.Now,
                    Cuota="149,000",
                    ValorDefinitivo="149,000",
                    FormaPago="tarjeta",
                    ValorDistinto=""
                },
                new DescuentoPorConvenio(){
                    Id=3,
                    Sucursal="Bogota",
                    Convenio="Convenio3",
                    Identifnicacion="1085309825",
                    Nombre="Hernan",
                    Modulo="modulo3",
                    Concepto="conepto3",
                    Credito="credito3",
                    FechaVencimiento= DateTime.Now,
                    Cuota="150,000",
                    ValorDefinitivo="150,000",
                    FormaPago="efectivo",
                    ValorDistinto=""
                }
            };
            _lstDescuentosIndividuales = new List<DescuentoPorConvenio>() {
                new DescuentoPorConvenio(){
                    Id=4,
                    Sucursal="Pasto",
                    Convenio="Convenio1",
                    Identifnicacion="1085309822",
                    Nombre="juan",
                    Modulo="modulo1",
                    Concepto="conepto1",
                    Credito="credito1",
                    FechaVencimiento= DateTime.Now,
                    Cuota="130,000",
                    ValorDefinitivo="130,000",
                    FormaPago="Efecivo",
                    ValorDistinto=""
                },
                new DescuentoPorConvenio(){
                    Id=5,
                    Sucursal="Cali",
                    Convenio="Convenio2",
                    Identifnicacion="1085309824",
                    Nombre="diego",
                    Modulo="modulo2",
                    Concepto="conepto2",
                    Credito="credito2",
                    FechaVencimiento= DateTime.Now,
                    Cuota="149,000",
                    ValorDefinitivo="149,000",
                    FormaPago="tarjeta",
                    ValorDistinto=""
                },
                new DescuentoPorConvenio(){
                    Id=6,
                    Sucursal="Bogota",
                    Convenio="Convenio3",
                    Identifnicacion="1085309825",
                    Nombre="Hernan",
                    Modulo="modulo3",
                    Concepto="conepto3",
                    Credito="credito3",
                    FechaVencimiento= DateTime.Now,
                    Cuota="150,000",
                    ValorDefinitivo="150,000",
                    FormaPago="efectivo",
                    ValorDistinto=""
                }
            };
            _proximoNumeroDisponible = 123432;
            _lstSucursalesFilter= new string[] { "Pasto", "Cali", "Bogota" };
            _tipoDocuemnto = new string[] { "Descuentos Por Documento" };
            _fecha = DateTime.Now;
            _detalle = "";

            dynamic render = new ExpandoObject();
            render.lstDecuentos = JsonConvert.SerializeObject(_arrayListDescuentos);
            render.lstDescuentosIndividuales = JsonConvert.SerializeObject(_lstDescuentosIndividuales);
            render.proximoNumeroDisponible = _proximoNumeroDisponible;
            render.sucursalFilter = _lstSucursalesFilter;
            render.tipoDocumento = _tipoDocuemnto;
            render.descripcion = _detalle;
            render.fecha = _fecha;
            return View(render);
        }

        // GET: DescuentosConvenio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DescuentosConvenio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DescuentosConvenio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _tipoDocumento=collection["TipoDocumento"];
                _detalle = collection["detalle"];
                _fecha=DateTime.ParseExact(collection["Fecha"], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                _proximoNumeroDisponible = int.Parse(collection["ProximoNumeroDisponible"]);
                string tempDescuentos = collection["descuentosSaved"];
                List<DescuentoPorConvenio> resutlt = JsonConvert.DeserializeObject<List<DescuentoPorConvenio>>(tempDescuentos);
                _arrayListDescuentos = resutlt;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DescuentosConvenio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DescuentosConvenio/Edit/5
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

        // GET: DescuentosConvenio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DescuentosConvenio/Delete/5
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

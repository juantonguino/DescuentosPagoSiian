using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaPostgreSQL.Models
{
    public class DescuentoPorConvenio
    {

        public int Id { get; set; }

        public string Sucursal { get; set; }

        public string Convenio { get; set; }

        public string Identifnicacion { get; set; }

        public string Nombre { get; set; }

        public string Modulo { get; set; }

        public string Concepto { get; set; }

        public string Credito { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FechaVencimiento { get; set; }

        public string Cuota { get; set; }

        public string ValorDistinto{ get; set; }

        public string ValorDefinitivo { get; set; }

        public string FormaPago { get; set; }
    }
}
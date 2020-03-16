﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVeterinariaSoft.Models
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public int SuplidorId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("CompraId")]
        public virtual List<DetalleProductos> ListaProductos { get; set; }

        public Compras()
        {
            CompraId = 0;
            SuplidorId = 0;
            Fecha = DateTime.Now;
            Impuesto = 0;
            ListaProductos = new List<DetalleProductos>();
            Total = 0;

        }
    }
}

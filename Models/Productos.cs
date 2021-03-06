﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroVeterinariaSoft.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Es necesario introducir una fecha de nacimiento")]
        [Range(typeof(DateTime), minimum: "1/1/1990", maximum: "1/1/2030", ErrorMessage = "La fecha esta fuera de rango")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Es necesario introducir una descripcion")]
        [StringLength(maximumLength:40 ,ErrorMessage = "La descripcion esta fuera de rango")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Es necesario especificar la cantidad del producto")]
        [Range(typeof(int), minimum: "1", maximum: "1000000", ErrorMessage = "Itbis esta fuera de rango")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "Es necesario especificar el minimo de la cantidad del producto")]
        [Range(typeof(int), minimum: "0", maximum: "1000000", ErrorMessage = "Itbis esta fuera de rango")]
        public int Minimo { get; set; }

        [Required(ErrorMessage = "Es necesario introducir una unidad")]
        [Range(typeof(int),maximum:"1000000",minimum:"1",ErrorMessage ="La unidad no es valida")]
        public int UnidadId { get; set;}
        public string UnidadDescripcion { get; set; }

        [Required(ErrorMessage = "Es necesario especificar el costo de compra del producto")]
        [Range(typeof(decimal), minimum: "1", maximum: "1000000", ErrorMessage = "El costo esta fuera de rango")]
        public decimal Costo { get; set; }
        [Required(ErrorMessage ="Es necesario introducir un precio")]
        [Range(typeof(decimal), minimum: "1", maximum: "1000000000000", ErrorMessage = "El precio esta fuera de rango")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Es necesario especificar la ganancia del producto")]
        [Range(typeof(decimal), minimum: "1", maximum: "90", ErrorMessage = "La ganancia esta fuera del rango decimal")]
        public decimal Ganancia { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidad = 0;
            Minimo = 0;
            UnidadId = 0;
            UnidadDescripcion = string.Empty;
            Costo = 0;
            Precio = 0;
            Ganancia = 0;

        }
    }


}

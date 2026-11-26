using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Restaurante.Datos.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
        [Required]
        public decimal PVP { get; set; }
        [Required]
        public decimal Costo_Fabricacion { get; set; }

        //relacion con la tabla productos

        public int CategoriasId { get; set; }
        public Categorias Categorias { get; set; }

    }
}

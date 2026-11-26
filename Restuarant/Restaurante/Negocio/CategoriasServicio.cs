using Restaurante.Datos;
using Restaurante.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Negocio
{
    public class CategoriasServicio
    {
        private readonly RestauranteDbContext _dbContext = new RestauranteDbContext();

        public List<Categorias> todos() {
            return _dbContext.Categorias.ToList();
        }

        public bool insertar(Categorias categorias) {
            try
            {
                _dbContext.Categorias.Add(categorias);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}

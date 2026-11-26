using Microsoft.EntityFrameworkCore;
using Restaurante.Datos;
using Restaurante.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Negocio
{
    public class ProductosService
    {
        private readonly RestauranteDbContext _dbContext = new RestauranteDbContext();

        public List<Producto> todos() {
            return _dbContext.Productos.OrderBy(p => p.Nombre).ToList();
        }
        public Producto uno(int id) {
            return _dbContext.Productos.FirstOrDefault(p => p.Id == id);
        }

        public bool insertar(Producto producto) {
            try
            {
                _dbContext.Productos.Add(producto);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        async public Task<bool> editar(Producto producto)
        {
            try
            {
                var productoExistente = await _dbContext.Productos
                    .FirstOrDefaultAsync(p => p.Id == producto.Id);

                _dbContext.Entry(productoExistente).CurrentValues.SetValues(producto);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool eliminar(int id)
        {
            try
            {
                var pro = _dbContext.Productos.FirstOrDefault(p => p.Id == id);
                _dbContext.Productos.Remove(pro);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

using SisGestionDeProductosConsoleApp1.Interfeces;
using SisGestionDeProductosConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SisGestionDeProductosConsoleApp1.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        // 1. Lista privada que almacena los registros temporalmente en memoria
        private List<Producto> _productos;

        // 2. Constructor: Carga los datos iniciales
        public ProductoRepository()
        {
            _productos = new List<Producto>()
            {
                new Producto { id = 1, name = "Budin Almendras", price = 12000m, category = "Postres", activo = true },
                new Producto { id = 2, name = "Budin Arandanos", price = 1200m, category = "Postres", activo = true },
                new Producto { id = 3, name = "Empanadas JamonyQueso", price = 1500m, category = "Empanadas", activo = true },
                new Producto { id = 4, name = "Empanadas Carne", price = 1350m, category = "Empanadas", activo = true }
            };
        }

        // Método que agrega un producto a la lista
        public void AddProduct(Producto producto)
        {
            _productos.Add(producto);
        }

        // Método usando LINQ para obtener todos los productos
        public List<Producto> GetAllProduct()
        {
            return _productos.ToList();
        }

        // Metodo usando LINQ para buscar por ID usando la propiedad en minúscula 
        public Producto GetById(int id)
        {
            return _productos.FirstOrDefault(p => p.id == id);
        }

        // Metodo usando LINQ para buscar por categoria permitiendo buscar en minusculas o mayusculas
        public List<Producto> SearchByCategory(string categoria)
        {
            return _productos
                .Where(p => p.category.ToLower() == categoria.ToLower())
                .ToList();
        }
    }
}
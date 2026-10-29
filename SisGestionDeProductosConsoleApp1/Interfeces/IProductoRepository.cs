using SisGestionDeProductosConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisGestionDeProductosConsoleApp1.Interfeces
{
    public interface IProductoRepository
    {
        void AddProduct(Models.Producto producto);
        List<Models.Producto> GetAllProduct();
        Models.Producto GetById(int id);
        List<Models.Producto> SearchByCategory(string categoria);
    }
}


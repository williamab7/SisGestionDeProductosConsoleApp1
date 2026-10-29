using System;
using System.Collections.Generic;
using System.Text;

namespace SisGestionDeProductosConsoleApp1.Models
{
    public class Producto
    {
        //Properties
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        public bool activo { get; set; }


    }
}

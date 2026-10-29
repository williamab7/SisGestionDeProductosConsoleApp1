using System;
using System.Text.RegularExpressions;
using SisGestionDeProductosConsoleApp1.Interfeces;
using SisGestionDeProductosConsoleApp1.Models;
using SisGestionDeProductosConsoleApp1.Repositories;

namespace SisGestionDeProductosConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instaciar el repositorio para crear el nuevo producto
            IProductoRepository repo = new ProductoRepository();

            // Probar la impresion de la lista completa
            Console.WriteLine("--- 1. LISTA COMPLETA DE PRODUCTOS ---");
            foreach (var p in repo.GetAllProduct())
            {
                Console.WriteLine($"ID: {p.id} | Nombre: {p.name} | Precio: ${p.price} | Cat: {p.category}");
            }

            Console.WriteLine("--- 2. BUSQUEDA POR ID ---");
            var SearchedProduct = repo.GetById(4);
            if (SearchedProduct != null)
            {
                Console.WriteLine($"Producto encontrado {SearchedProduct.name} - Precio ${SearchedProduct.price}");
            }

            Console.WriteLine("---3.FILTRADO POR CATEGORIA");
            var CategoryFiltered = repo.SearchByCategory("Empanadas");
            foreach (var p in CategoryFiltered)
            {
                Console.WriteLine($" {p.name}, {p.price}");
            }
            Console.WriteLine("---4. Agrega Producto a la lista ---");
            Producto nuevoProducto = new Producto
            {
                id = 1,
                name = "budin de pera",
                price = 1900,
                category = "Postres",
                activo = true

            };
            repo.AddProduct(nuevoProducto);
            Console.WriteLine("Producto agregado con exito");

            Console.WriteLine("\n--- 5. LISTA ACTUALIZADA CON EL NUEVO PRODUCTO ---");
            foreach (var p in repo.GetAllProduct())
            {
                Console.WriteLine($"ID: {p.id} | Nombre: {p.name} | Cat: {p.category}");
            }

            // Pausa para que la consola no se cierre sola
            Console.WriteLine("\nPresioná cualquier tecla para salir...");
            Console.ReadKey();
        }

    }
    
}
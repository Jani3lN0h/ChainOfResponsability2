using ChainOfResponsability2.Entities;
using ChainOfResponsability2.Entities.Interfaces;
using ChainOfResponsability2.Services;
using ChainOfResponsability2.Services.Interfaces;
using System;

namespace ChainOfResponsability2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Capture el concepto de compra");
            Console.ResetColor();
            var cConcepto = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Capture el monto de compra");
            Console.ResetColor();
            var cMonto = Console.ReadLine();
            IHandler handler;
            Client client = new Client();
            handler = client.ConfigurarAutorizadoresCompra();
            IPurchase purchase = new Purchase();
            purchase.cConcept = cConcepto;
            purchase.dAmount = Convert.ToDouble(cMonto);
            handler.ProcessPurchase(purchase);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nPresione una tecla para salir.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;


namespace GerenciamentoDeBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MenuGeral();       
            
            Console.WriteLine("Programa encerrado.");
            Console.ReadLine();            
        }
    }
}

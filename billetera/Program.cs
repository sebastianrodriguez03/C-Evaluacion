using System;
using System.Collections.Generic;

namespace billetera
{
    class Program
    {
        private static int opcion;

        public double DineroAdquirido { get; set; }
        public double Gasto { get; set; }
        public double Inicial { get; set; }
        public double GastoAhorro { get; set; }
        public double Banco { get;  set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la cantidad de dienero");
            var cuenta = Console.ReadLine();
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1 Gastar");
            Console.WriteLine("2 Depositar");
            Console.WriteLine("3 ImprimirDinero");
            Console.WriteLine("4 NotificarTransaccion");
            Console.WriteLine("5 TotalAhorrado");
            
            opcion = Convert.ToInt32(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Gastar");
                    break;

                case 2:
                    Console.WriteLine("Depositar");
                    break;

                case 3:
                    Console.WriteLine("ImprimirDinero");
                    break;
                case 4:
                    Console.WriteLine("NotificarTransaccion");
                    break;
                case 5:
                    Console.WriteLine("TotalAhorrado");
                    break;

            }
             
        }

    }
}

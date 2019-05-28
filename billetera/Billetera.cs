using System;
using System.Collections.Generic;
using System.Text;

namespace billetera
{
    class Billetera
    {



        //Es para definir todas las propiedades
        #region Propiedades
        public string Gastar { get; set; }
        public int Depositar { get; set; }
        #endregion

        public void ImprimirDienro(List<Billetera> billeteras)
        {
            Console.WriteLine("Ingrese cunato quire gastar");
            Gastar = Console.ReadLine();
            Console.WriteLine("Ingrese cuanto quiere depositar");
            Depositar = Convert.ToInt32(Console.ReadLine());
        }
        public void Listarbilletera(List<Billetera> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"Gastar: {item.Gastar} Depositar: {item.Depositar}");
            }
        }

        
    }
}

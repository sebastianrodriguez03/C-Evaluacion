using System;
using System.Collections.Generic;
using System.Text;

namespace billetera
{
    class MusicPlayer
    {
        //Es para definir todas las propiedades
        #region Propiedades
        public int Numero { get; set; }
        public string Nombre { get; set; }
        #endregion

        public void IngresarCanciones()
        {
            Console.WriteLine("Ingrese el nombre de la cancion que desea escuchar");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de la cancion");
            Numero = Convert.ToInt32(Console.ReadLine());
        }
        public void ListarCanciones(List<MusicPlayer> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"La cancion agregada es : {item.Nombre} #: {item.Numero}");
            }
        }
    }
}

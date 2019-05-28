using billetera;
using System;
using System.Collections.Generic;

namespace musicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
                MusicPlayer can = new MusicPlayer();
                MusicPlayer can2 = new MusicPlayer();
                MusicPlayer can3 = new MusicPlayer();

                List<MusicPlayer> canciones = new List<MusicPlayer>();
                can.Nombre = "Bendecida";
                can.Numero = 18;

                Console.WriteLine($"Cancion en reproduccion es:{can.Nombre} #: {can.Numero}");
                
                canciones.Add(can);
                
                

                

                Console.WriteLine("¿Desea ingresar una cancion? s/n");
                var res = Console.ReadLine();

                while (res == "s")
                {
                    MusicPlayer can4 = new MusicPlayer();
                    can4.IngresarCanciones();
                    canciones .Add(can4);
                    Console.WriteLine("¿Desea ingresar otra cancion? s/n");
                    res = Console.ReadLine();

                }
                MusicPlayer per = new MusicPlayer();
                per.ListarCanciones(canciones);
                Console.ReadKey();
            
        }
        
        
    }
}

using System;
using System.Collections.Generic;

namespace Lista_de
{
    class Program
    {
        
         static void Main(string[] args)
        {
            //creamos una lista
            List<Peliculas> peliculas= new List<Peliculas>();
            //agregamos peliculas a la lista
            peliculas.Add(new Peliculas("El joker"));
            peliculas.Add(new Peliculas("jojo rabit"));
            peliculas.Add(new Peliculas("mujercitas"));
            peliculas.Add(new Peliculas("Parasitos"));
            peliculas.Add(new Peliculas("Sonic"));
            peliculas.Add(new Peliculas("Eraze una vez...en Holliwood"));

            //foreach para iterar el imprimir
            foreach(Peliculas I in peliculas)
            {
                I.imprime();
            }



        }
    }
    class Peliculas
    {
        public string Titulo;

        //
        public void imprime()
        {
            Console.WriteLine("Titulo:"+Titulo);
        }
        //
        public Peliculas(string c)
        {
            Titulo = c;
        }
       
    }
}
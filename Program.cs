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
            peliculas.Add(new Peliculas("El joker",2019,"Joaquin fenix"));
            peliculas.Add(new Peliculas("jojo rabit",2019,"Roman Griffin Davis"));
            peliculas.Add(new Peliculas("mujercitas",2019,"Trini alvarado"));
            peliculas.Add(new Peliculas("Parasitos",2019,"Kang-ho Song"));
            peliculas.Add(new Peliculas("Sonic",2020,"El sonic"));
            peliculas.Add(new Peliculas("Eraze una vez...en Holliwood",2019,"Brad pit"));

            //
            List<actor> actores=new List<actor>();
            
    
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
        public int año;
        public string nombre;

        //
        public void imprime()
        {
            Console.Write("Titulo:"+Titulo);
            Console.Write(" Año: "+año);
            Console.WriteLine(" Protagonista: "+nombre);
        }
        //
        public Peliculas(string c,int a,string n)
        {
            Titulo = c;
            año=a;
            nombre=n;
        }
       
       //
       public void agragaractor(string nom)
       {
           nombre=nom;
       }
       
    }
    class actor
    {
        public string nombre;

        //
        public actor(string n)
        {
            nombre=n;
        }




    }
}
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


            //
              //* CREAMOS UNA LISTA PARA LOS ACTORES 
            List<Actores> Actores=new List<Actores>();
            
            
            Actores.Add(new Actores("juan"));
            Actores.Add(new Actores("PEDRO"));
            Actores.Add(new Actores("LUIS"));
            Actores.Add(new Actores("RAUL"));
            Actores.Add(new Actores("STEVE"));


            //foreach para iterar el imprimir
            foreach(Peliculas I in peliculas)
            {
                I.imprime();
            }

            //FOREACH
            foreach(Actores I in Actores)
            {
                I.imprimea();
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
    class Actores
    {
        public string nombre;
        //
        public Actores(string n)
        {
            nombre=n;
        }

        public void imprimea()
        {
           
            Console.WriteLine("Actores: "+nombre);
        }

        

        

    }
}
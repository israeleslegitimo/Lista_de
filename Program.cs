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
            
            
            Actores.Add(new Actores("juan",23));
            Actores.Add(new Actores("PEDRO",2));
            Actores.Add(new Actores("LUIS",2));
            Actores.Add(new Actores("RAUL",2));
            Actores.Add(new Actores("uans",3));


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
        public int año;
        //
        public Actores(string n,int a)
        {
            nombre=n;
            año=a;
        }


        public void imprimea()
        {
           
            Console.WriteLine("Actores: "+nombre+"   Año : "+año);
        }

        

        

    }
}
using System;

namespace Herencia_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //método de sustitución
            Mamifero persona = new Humano("Hamel", 19);
            Mamifero chiguagua = new Perro("Firulais", 3);

            Console.WriteLine(persona.GetNombre() + "\n" + persona.GetEdad());
            persona.PuedoComer();
            persona.PuedoRespirar();

            // Downcasting para llamar a métodos específicos
            if (persona is Humano humano)
            {
                humano.PuedoPensar();
            }            

            Console.WriteLine(chiguagua.GetNombre() + "\n" + chiguagua.GetEdad());
            chiguagua.PuedoComer();
            chiguagua.PuedoRespirar();
            if (chiguagua is Perro perro)
            {
                perro.PuedoLadrar();
            }
        }
    }
    class Mamifero
    {
        private String nombre;
        private int edad;

        public Mamifero(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void PuedoComer()
        {
            Console.WriteLine("Puedo comer");
        }
        public void PuedoRespirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public String GetNombre()
        {
            return "Mi nombre es " + nombre;
        }
        public String GetEdad()
        {
            return "Tengo " + edad + " años de edad"; 
        }

    }
    class Humano : Mamifero
    {
        public Humano(String hNombre, int hEdad):base(hNombre, hEdad)
        {

        }
        public void PuedoPensar()
        {
            Console.WriteLine("Puedo pensar");
        }        

    }
    class Perro : Mamifero
    {
        public Perro(String pNombre, int pEdad) : base(pNombre, pEdad)
        {

        }
        public void PuedoLadrar()
        {
            Console.WriteLine("Soy capaz de ladrar");
        }

    }
}

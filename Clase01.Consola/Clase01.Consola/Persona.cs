using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01.Consola
{
    public class Persona
    {
       
        //Creamos variables


        //string nombre;
        //int edad;

        //public Persona()//Constructor sin carga de informacion
        //{
        //}

        //public Persona(string nombre, int edad)//Constructor sobrecargado
        //{
        //    this.nombre = nombre;
        //    this.edad = edad;
        //}
        //public void imprimirDatos()
        //{
        //    Console.WriteLine(nombre + " " + edad);


        //}


            /*
             metodos abreviados prop y propfull
             *atributo;son las variables para acceder a las propiedades
             * propiedad;sonnn los atributos de la clase, es decir los estados
             */
        public string Nombre { get; set; }


        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public Persona()
        {
        }
    }
}

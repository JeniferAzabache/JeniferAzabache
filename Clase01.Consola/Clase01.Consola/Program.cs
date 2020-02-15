using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola");

            //Console.ReadLine();

            //Declarar e inicializar
            //int[] miMatriz;

            //miMatriz = new int[4];
            //int[] miMatriz2 = new int[4];


            #region Arreglos

            //Modo 1
            //int[] miMatriz=new int[4];

            //miMatriz[0] = 2;
            //miMatriz[1] = 10;
            //miMatriz[2] = 3;
            //miMatriz[3] = 15;

            //Modo 2
            //int[] arrayNumeros = { 2,10,3,15};


            //Recorrer un arreglo

            //Console.WriteLine(  "Recorrido con FOR");
            //for (int i = 0; i < arrayNumeros.Count(); i++) //arrayNumeros.Count():Cuentame la informacion que hay en el Array

            //    Console.WriteLine(arrayNumeros[i]);

            //{
            //    Console.WriteLine("Recorrido con FOREACH");//desgloza cada uno
            //    foreach (var item in arrayNumeros)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Arreglos con Clase y manejo de errores

            //try
            //{

            //    Persona Ana = new Persona("Ana ", 20);

            //    Persona[] persona = new Persona[2];
            //    persona[0] = new Persona("Jenifer ", 20);

            //    persona[1] = Ana;
            //    for (int i = 0; i < persona.Length; i++)
            //    {
            //        persona[i].imprimirDatos();

            //    }
            //    persona[3].imprimirDatos();//Se fuerza al error
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Se presentó un error");
            //    //throw;
            //}

            //    //Console.WriteLine();



            #endregion




            #region Listas(Coleccion de datos)
            //Permiten almacenar elementos genericos
            //No tiene limitaciones como los Arrays, pero genera mayor consumo de recursos
            //Se puede realizaqr las operaciones de ordenar, buscar, añadir

            //int[] arrayNumeros = { 2, 10, 3, 8, 40};
            //List<int> listaDatos = new List<int>();
            ////Agregar datos en la lista medianteen metodo Add
            //for (int i = 0; i< arrayNumeros.Length; i++)
            //{
            //    listaDatos.Add(arrayNumeros[i]);
            //}
            ////Mostrar datos de un List  Count se utiliza como una propiedad
            //for (int i = 0; i < listaDatos.Count; i++)
            //{
            //    Console.WriteLine(listaDatos[i]);
            //}
            /*
             Elaborar un programa que ingrese los valores, si es cero termina su ejecucion 
             *y muestre los valores ingresados
             
             */

            //string campo;
            //List<string> listaDatos = new List<string>();
            //do
            //{
            //    Console.WriteLine("Ingrese infromacion");
            //    campo = Console.ReadLine();
            //    listaDatos.Add(campo);


            //} while (campo!="0");
            //Console.WriteLine("\n Los datos ingresados son");
            //foreach (var item in listaDatos)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion
            #region Listas(coleccion de datos)

            //Persona objP = new Persona();//uso del constructor sin sobrecarga

            //objP.Nombre = "Karina";
            //objP.Edad = 20;
            //Persona objP2 = new Persona("Manuel", 10);//uso del constructor sobrecargado

            //List<Persona> listarPersona = new List<Persona>();
            //listarPersona.Add(new Persona("Pedro", 18));//uso del constructor sobrecargado
            //listarPersona.Add(new Persona { Nombre = "Mariela", Edad = 25 });//uso del constructor vacio

            //listarPersona.Add(objP);
            //listarPersona.Add(objP2);

            ////Listar los datos del objeto

            //Console.WriteLine("listar con FOR");
            //for (int i = 0; i < listarPersona.Count; i++)
            //{
            //    Console.WriteLine(listarPersona[i].Nombre + " " + listarPersona[i].Edad);
            //}
            //Console.WriteLine("listar con FOREACH");
            //foreach (var item in listarPersona)
            //{
            //    Console.WriteLine(item.Nombre + " "+ item.Edad);
            //}
            #endregion


            #region Diccionarios(Coleccion de datos)
            //Console.WriteLine("Ingrese el numero de semana :");
            //int dia = Convert.ToInt32(Console.ReadLine());

            //Dictionary<int, string> datos = new Dictionary<int, string>();


            //datos.Add(1,"Lunes");
            //datos.Add(2, "Martes");
            //datos.Add(3, "Miercoles");
            //datos.Add(4, "Jueves");
            //datos.Add(5, "Viernes");
            //datos.Add(6, "Sabado");
            //datos.Add(7, "Domingo");


            //Console.WriteLine(datos[dia]);


            ////Console.WriteLine(datos[1]);
            ////Recorrido de dictionary con FOR
            //for (int i = 1; i <=datos.Count; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}
            ////Llenado de datos con  foreach
            //foreach (var item in datos)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion


            /*Ejercicio 1
             * 
             * 
             * */

            List<int> listaCostoExtra = new List<int>();
            Dictionary<int, string> horasExtra = new Dictionary<int, string>();
            horasExtra.Add(1, "12");
            horasExtra.Add(2, "12");
            horasExtra.Add(3, "12");
            horasExtra.Add(4, "13");
            horasExtra.Add(5, "13");
            horasExtra.Add(6, "15");
           


            Console.WriteLine("Ingrese horas Trabajadas");
            int horas = Convert.ToInt32(Console.ReadLine());
            int horasExtras = horas - 8;
            if (horasExtras<=0)
            {
                Console.WriteLine("HorasTrabajadas: " + horas);
                Console.WriteLine("Costo de horas trabajadas:" +horas * 10 + "s/.");
                Console.WriteLine("HorasExtras:0");
                Console.WriteLine("Costo de horas Extras :0 s/.");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Pago a realizar es de :" + (horas * 10) +  "s/.");
            }
            else
            {
                Console.WriteLine("HorasTrabajadas: " + 8);
                int costoHorasT = 8 * 10;
                Console.WriteLine("Costo de horas trabajadas:" +costoHorasT+ "s/.");

                int costo = listaCostoExtra[horasExtras];


                Console.WriteLine("HorasExtras:"+horasExtra);

                int costoHorasE = horasExtras * costo;
                Console.WriteLine("Costo de horas Extras : " + costoHorasE + "s/:") ;
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Pago a realizar es de :" + (costoHorasT * costoHorasE) + "s/.");

            }


            List<int> DatosTrbajadores = new List<int>();

            Console.WriteLine("Ingrese el codigo :  ");
            Console.WriteLine("Ingrese el nombre: ");
            Console.WriteLine("Ingrese ");






        }
    }


}

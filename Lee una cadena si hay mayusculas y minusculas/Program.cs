using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lee_una_cadena_si_hay_mayusculas_y_minusculas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos 3 variable 1 de tipo String y 2  de tipo int
            string cadena;
            int mayuscula = 0, minuscula = 0;
            //Mensaje 
            Console.WriteLine("Indroduzca una cadena de texto");
            //Método para introducir una cadena de texto 
            cadena = Console.ReadLine();
            //Ciclo for para obtener la longitud de la cadena
            //Length obtiene el número de caracteres en la cadena introducida ósea la longitud
            for (int i = 0; i < cadena.Length; i++)
            {
                //Condición para evaluar la cadena de texto con  IsLower
                //Indica si un carácter Unicode se clasifica como una letra minúscula.
                if (char.IsLower(cadena[i]))
                {
                    //Incrementaos la variable
                    minuscula++;
                }
                else
                {
                    //Condición para evaluar la cadena de texto con  IsUpper
                    //Indica si un carácter Unicode se clasifica como una letra mayúscula.
                    if (char.IsUpper(cadena[i]))
                    {
                        //Incrementaos la variable
                        mayuscula++;
                    }
                }
            }
            //Mensajes para mostrar el resultado 
            Console.WriteLine("El numero de mayúsculas de cadena es: " + mayuscula);
            Console.WriteLine("El numero de minúsculas de cadena es: " + minuscula);
            Console.ReadLine();
        }
    }
}

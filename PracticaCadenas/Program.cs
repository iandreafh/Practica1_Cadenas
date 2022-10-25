//Practica 1: Cadenas
//Andrea Fernandez Hita

using System;

namespace PracticaCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code donde guardo la opcion del menu elegida
            int code = 0;

            while (code != 4)
            {
                //Reseteo el valor de code
                code = 0;

                //Solicito la cadena
                Console.WriteLine("Introduzca una cadena de al menos 40 caracteres: ");
                string cadena = Console.ReadLine();
                int num = cadena.Length;

                //Compruebo longitud correcta
                while (cadena != null && num < 40)
                {
                    Console.WriteLine($"La cadena introducida posee únicamente {num} caracteres. " +
                        $"Por favor, introduzca una nueva cadena con más de 40 caracteres: ");
                    cadena = Console.ReadLine();
                    num = cadena.Length;
                }

                //Mientras no seleccione opcion valida, se repite
                while (code == 0)
                {
                    //Imprimo menu
                    Console.Write("\n## MENÚ ##\n" +
                        "1 - Sustituir palabra en cadena.\n" +
                        "2 - Buscar coincidencia en cadena.\n" +
                        "3 - Comprobar inicio cadena.\n" +
                        "4 - Salir del programa.\n\n" +
                        "Elige la opción deseada: ");

                    //Leo opcion y hago parse a int
                    Console.Out.Flush();
                    String c = Console.ReadLine();
                    code = Int32.Parse(c);


                    switch (code)
                    {
                        //Sustituyo una palabra por otra
                        case 1:
                            Console.Write("Introduzca la palabra a buscar y la palabra que la sustituya, separadas por un espacio: ");
                            string palabras = Console.ReadLine();
                            //Separo por el espacio ambas palabras y reemplazo
                            string[] separadas = palabras.Split(' ');
                            cadena = cadena.Replace(separadas[0], separadas[1]);
                            Console.WriteLine($"Resultado: {cadena}");
                            break;

                        //Busco si existe esa palabra en la cadena
                        case 2:
                            Console.Write("Introduzca la palabra a buscar: ");
                            string palabra = Console.ReadLine();
                            bool existe = cadena.Contains(palabra);
                            if (existe)
                                Console.WriteLine("La palabra SI existe.");
                            else
                                Console.WriteLine("La palabra NO existe.");
                            break;

                        //Busco si coincide el inicio de cadena
                        case 3:
                            Console.Write("Introduzca el inicio de la cadena que a comprobar: ");
                            string inicio = Console.ReadLine();
                            bool coincide = cadena.StartsWith(inicio);
                            if (coincide)
                                Console.WriteLine("El inicio de la cadena SI coincide.");
                            else
                                Console.WriteLine("El inicio de la cadena NO coincide.");
                            break;

                        //Salir del programa
                        case 4:
                            Console.WriteLine("Cerrando...");
                            break;

                        default:
                            Console.WriteLine($"{code} no es una opción válida. Pruebe de nuevo.\n");
                            code = 0; //reseteo para repetir bucle menu
                            break;
                    }
                }

            }

            //Si selecciono -1 para salir
            Console.WriteLine("Programa finalizado.");
        }
    }
}
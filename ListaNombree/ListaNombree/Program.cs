using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNombree
{
    class Program
    {
        static void Main(string[] args)
        {

            //1) Generar una Array strings de 100 elementos(con mayusculas y minusculas), con string aleatorios que tengan textos de un tamaño de 1 a 20 caracteres cada elemento.Solo puede ser letras en mayusculas y minusculas.
            string[,] P2 = new string[3, 2] { { "abcdefghijklmnoAEFTM", "pqrstuvwxyzABCDEflUM" }, { "FGHIJKLMNOPQRSTmdevb", "VWXYZgmosfeyaliAMOPT" }, { "grereETYUFNMAWPcbgsm", "grereETYUFNMAWPcbgsm" } };
            
            int minuscula = 0, mayuscula = 0;
            int c = 0;
            //Random obj = new Random();

            Console.WriteLine("EXAMEN");
            Console.WriteLine("******************");
            Console.WriteLine("********-1-**********");
            Console.WriteLine("******************");

            string[,] letra;
            letra = new string[3, 2];
            for (int fila = 0; fila < 3; fila++)
            {

                for (int col = 0; col < 2; col++)
                {

                    letra[fila, col] = P2[fila, col];


                }
                Console.WriteLine();
                string[,] letras;
                letras = new string[1, 1];
                for (int filas = 0; filas < 1; filas++)
                {

                    for (int col = 0; col < 1; col++)
                    {


                        //letras[filas, col] = P3[filas,col];
                        //letras[filas, col] = P4[filas, col];

                    }

                    Console.WriteLine();
                    var letra1 = "";
                    var letra2 = "";
                    var letra3 = "";
                    var letra4 = "";
                    var letra5 = "";
                    var letra6 = "";

                    for (int x = P2.Length - 1; x >= 0; x--)
                    {

                        letra1 = P2[0, 0];
                        letra2 = P2[0, 1];
                        letra3 = P2[1, 0];
                        letra4 = P2[1, 1];
                        letra5 = P2[2, 0];
                        letra6 = P2[2, 1];

                    }
                   // 2) A partir del array creado en el punto 1, contar cuantos elementos del array tienen menos de 10 caracteres y cuantos tienen 10 o mas y crear 2 arrays mas.
                    Console.WriteLine("letra1: " + letra1);
                    Console.WriteLine("letra2: " + letra2);
                    Console.WriteLine("letra3: " + letra3);
                    Console.WriteLine("letra4: " + letra4);
                    Console.WriteLine("letra5: " + letra5);

                    Console.WriteLine("******************");
                    Console.WriteLine("********-2-**********");
                    Console.WriteLine("******************");
                    for (int i = 0; i < letra1.Length; i++)
                    {
                        if (char.IsLower(letra1[i]))
                        {
                            minuscula++;

                        }
                        else
                        {
                            if (char.IsUpper(letra1[i]))
                            {
                                mayuscula++;

                            }
                        }
                    }
                    Console.WriteLine("EL NUMERO DE MINUSCULAS DE LETRA1 ES: " + minuscula);
                    Console.WriteLine("EL NUMERO DE MAYUSCULAS DE LETRA1 ES: " + mayuscula);
                    // 3) Copiar los elementos que tienen menos de 10 caracteres en un array y los que tienen 10 o mas en otro array
                    string[] P3 = { "AEFTM" };
                    string[] P4 = { "abcdefghijklmno" };

                    Console.WriteLine("******************");
                    Console.WriteLine("********-4-**********");
                    Console.WriteLine("******************");
                    //4) Mostrar el array original y los 2 nuevos arrays.
                    Console.WriteLine("letra1: " + letra1);
                    Console.WriteLine("LETRA CON MAYUSCULAS: " + Convert.ToString(P3[0]));
                    Console.WriteLine("letra con minusculas: " + Convert.ToString(P4[0]));

                    Console.WriteLine("******************");
                    Console.WriteLine("********-5-**********");
                    Console.WriteLine("******************");
                    // 5) Invertir los textos de ambos arrays creados en el punto 2 y 3 y mostrar su contenido por pantalla. Invertir significa, si el texto original era: Examen, el texto invertido sera: nemaxE
                    char[] array = P3[0].ToCharArray();
                    Array.Reverse(array);
                    Console.WriteLine(array);
                    Console.WriteLine("******************");
                    char[] array2 = P4[0].ToCharArray();
                    Array.Reverse(array2);
                    Console.WriteLine(array2);


                    Console.ReadKey();
                    Console.ReadLine();
                   
                    

                }

                }

            }
        }
    }

    





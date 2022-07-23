using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_parcial_de_F.programacion
{
    internal class Program
    {
    }
    namespace Ej_06_12_ContarVocales
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Mete una frase: ");
                char[] frase = Console.ReadLine().ToCharArray();
                int num = contarVocales(frase);
                Console.WriteLine("El numero de vocales es " + num);
                Console.ReadKey();

                primeraParteB();

                candidatura();



            }
            static bool esVocal(char x)
            {
                char[] vocales = "aeiouAEIOUáéíóú".ToCharArray();
                int i = 0;
                while (i < vocales.Length)
                {
                    if (vocales[i] == x) return true;
                    i++;
                }
                return false;
            }

            static int contarVocales(char[] f)
            {
                int contador = 0;
                int i = 0;
                while (i < f.Length)
                {
                    if (esVocal(f[i]))
                    {
                        contador++;
                    }
                    i++;
                }
                return contador;
            }
            static void primeraParteB()
            {

                string frase;
                frase = "te amaba antes de conocerte lo supe cuando te enconre$";
                char[] texto = frase.ToCharArray();
                int num = 0;
                int i = 0;
                while (frase[i] == ' ') i++;

                if (frase[i] == '$') num--;

                while (frase[i] != '$')
                {
                    if (frase[i] == ' ')
                    {
                        num++;
                        while (frase[i] == ' ') i++;
                        if (frase[i] == '$') num--;

                    }
                    else i++;

                }
                num++;
                Console.WriteLine($"{frase}");
                Console.WriteLine("la frase tiene" + num + "palabras");

                Console.ReadKey();
            }
            static void candidatura()
            {
                int v1 = 0;
                int v2 = 0;
                int vnull = 0;
                int voto;
                int max;
                double total;
                double ov1;
                double ov2;
                double ov3;
                string ganador;
                Console.WriteLine("(1)Zinedine Zidane(2)Santiago Solari");
                Console.WriteLine("(3)votos nulos,(4)Salir");
                do
                {
                    Console.Write("Ingrese el voto:");
                    voto = int.Parse(Console.ReadLine());
                    if (voto == 1)
                    {
                        v1 = v1 + 1;
                    }
                    else if (voto == 2)
                    {
                        v2 = v2 + 1;
                    }
                    else if (voto == 3)
                    {
                        vnull = vnull + 1;
                    }

                } while (voto != 4);


                total = v1 + v2 + vnull;
                ov1 = (v1 / total) * 100;
                ov2 = (v2 / total) * 100;
                ov3 = (vnull / total) * 100;

                Console.WriteLine("Zinedine Zidane tiene : {0}", ov1);
                Console.WriteLine("Santiago Solari tiene : {0}", ov2);
                Console.WriteLine("votos nulos tiene : {0}", ov3);

                max = v1;
                ganador = "Zinedine Zidane";
                if (v2 > max)
                {
                    ganador = "Santiago Solari";
                }
                if (vnull > max)
                {
                    ganador = "no hubo ganadores";

                }
                Console.WriteLine("Felicidades a : {0} ", ganador);
                Console.ReadLine();

               
            }
        } 
    } }














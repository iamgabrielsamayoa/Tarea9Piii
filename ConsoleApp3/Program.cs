using Tarea9PIII.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea9PIII
{
    class Program
    {
        //Homework 9 
        static void LinealQueueExample()
        {
            PilaLineal pila = new PilaLineal();
            int x;
            int Clave = -1;

            Console.WriteLine("Ingrese un numero y para terminar -1");
            try
            {
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    pila.insertar(x);
                } while (x != Clave);

                Console.WriteLine("Estos son los elementos");

                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error = " + error.Message);
            }
            Console.ReadLine();
        }

        static void NumbersList()
        {
            PilaLista PilaL;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                PilaL = new PilaLista();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        PilaL.insertar(x);
                    }
                } while (x != CLAVE);

                Console.WriteLine("ESTOS SON LOS ELEMENTOS DE LA PILA:");


                while (!PilaL.pilaVacia())
                {
                    x = (int)(PilaL.quitar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }
        static void NumbersLinkedList()
        {
            ClsListEnlazada pilaLista;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pilaLista = new ClsListEnlazada();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pilaLista.insertarprimero(x);
                    }
                } while (x != CLAVE);

                Console.WriteLine("ESTOS SON LOS ELEMENTOS DE LA PILA:");


                while (!pilaLista.ListaVacia())
                {
                    x = (int)(pilaLista.quitarchar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }
        static void palindrome_Queue()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            string pal;

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es");
                pal = Console.ReadLine();


                pal = pal.ToLower().Replace(" ", String.Empty); //Elimina los espacios
                Console.WriteLine("Sin espacios: " + pal);
                //aca se eliminan las tildes
                pal = DeleteSpecialCharacters(pal);
                Console.WriteLine("Sin Tildes: " + pal);//Eliminamos Tildes

          

                //creamos la pila con los chars
                for (int i = 0; i < pal.Length;)
                {
                    char c;
                    c = pal[i++];
                    pilaChar.insertar(c);
                }
                //Comprueba si es palindrome
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    char c;
                    c = (char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c; //Evalua igualdad
                }

                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine("La palabra es palindromo");

                }
                else
                {
                    Console.WriteLine($"Nel, no es");
                }
                

            }
            catch (Exception error)
            {

                Console.WriteLine($"upss error {error.Message}");
            }
        }
        static void Palindrome_LinkList()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;
            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ser ver si es palíndromo: ");
                pal = Console.ReadLine();
                string sinTilde = DeleteSpecialCharacters(pal);
               

                sinTilde = sinTilde.Replace(" ", "").ToLower();
                Console.WriteLine("Nueva cadena de texto sin espacios : " + sinTilde);
                for (int i = 0; i < sinTilde.Length;)
                {
                    //Insertamos el caracter, agarrando letra por letra
                    char c;
                    c = sinTilde[i++];
                    pilaChar.insertar(c);
                }
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    char c;
                    //Extraer uno a uno
                    c = (char)pilaChar.quitarChar();
                    //Console.WriteLine("Valor c: " + c);
                    esPalindromo = sinTilde[j++] == c; //Evalúa si la pos es igual
                }
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {sinTilde} es palindromo");
                }
                else
                {
                    Console.WriteLine($"NEl no ees");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"error{error.Message}");
            }
        }
        static void PalindromeStack()
        {
            PilaLista pilaLs;
            bool esPalindromo;
            String pal;

            try
            {
                pilaLs = new PilaLista();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                string remplazada = Regex.Replace(pal, @"\s", "");
                string convertida = remplazada.ToLower();
                string textoSinAcentos = DeleteSpecialCharacters(convertida);
               
                //creamos la pila con los chars
                for (int i = 0; i < textoSinAcentos.Length;)
                {
                    Char c;
                    c = textoSinAcentos[i++];
                    pilaLs.insertar(c);
                }

                //comprueva si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaLs.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaLs.quitar();
                    esPalindromo = textoSinAcentos[j++] == c;//evalua si la posicion es igual o no es igual

                }
                pilaLs.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }
        static string DeleteSpecialCharacters(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);//usar variable NORMALIZE string usa algo similar a regular expresion se usa para dar formato sin tildes
            var stringBuilder = new StringBuilder(); //atraves del n.s y la variable stringbuilder para unir nuevamente nuestro string

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        static void MathPrefixExpressions()
        {
            clsPila miPila = new clsPila();
            int n = 0, a = 0, b = 0, r = 0;
            Console.WriteLine("Ingrese la expresión en prefix");
            string exp = Console.ReadLine();                    
            char caracter = ' ';                                
            for (n = exp.Length - 1; n >= 0; n--)
            {
                caracter = exp[n];
                if (caracter >= '0' && caracter <= '9')
                {
                    miPila.Push(Convert.ToInt32(caracter.ToString()));
                }
                else
                {
                    a = miPila.Pop();
                    b = miPila.Pop();
                  
                    if (caracter == '+')
                    {
                        r = a + b;
                        miPila.Push(r);
                    }
                    if (caracter == '-')
                    {
                        r = a - b;
                        miPila.Push(r);
                    }
                    if (caracter == '/')
                    {
                        r = a / b;
                        miPila.Push(r);
                    }
                    if (caracter == '*')
                    {
                        r = a * b;
                        miPila.Push(r);
                    }
                }
            }
            miPila.Transversa();
        }
        static void LIFOExample()
        {
            PilaLista pl = new PilaLista();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            int pau;
            pau = 0;
        }

        static void Main(string[] args)
        {
            //LinealQueueExample();
            //NumbersLinkedList();
            //palindrome_Queue();
            //Palindrome_LinkList();
            //PalindromeStack();
            //MathPrefixExpressions();
            //LIFOExample();
           
            Console.Read();
        }
    }
}

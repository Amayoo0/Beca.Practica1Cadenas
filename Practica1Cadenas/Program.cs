/*
Enunciado Práctica:

1.1- Solicitar al usuario que introduzca una cadena de al menos 40 caracteres. 
Si la longitud de la cadena es menor de 40 caracteres, se mostrará un aviso al usuario, 
informándole de la longitud actual, y solicitándole que vuelva a introducir una nueva cadena. 
Por ejemplo: "La cadena introducida posee únicamente XX caracteres. Por favor, introduzca una 
nueva cadena con más de 40 caracteres: ".

1.2- Una vez tengamos la cadena con el tamaño mínimo deseado, aparecerá un menú para:

    •Sustituir una palabra por otra. Para ello, se solicitará introducir, separadas por un espacio, 
la palabra a sustituir, y la sustituta, mostrándose por pantalla el resultado final.

    •Buscar texto en la cadena. Para ello, se solicitará introducir un texto para comprobar si existe o no.

    •Buscar texto de inicio en la cadena. Para ello, se solicitará introducir un texto para comprobar 
si la cadena comienza por el mismo.

1.3- Una vez haya terminado la acción seleccionada del menú, volvemos a solicitar una nueva cadena.

*/


using System;

namespace Practica1Cadena
{
    public class Practica1Cadena
    {
        public static void Main(string[] args)
        {
            string str = "", oldChar = "", newChar = "", findString = "";
            int opt = 0;
            bool exit = false;

            Console.WriteLine("Welcome to the Application \"Working with strings\"!");


            while (!exit)
            {
                Console.WriteLine("Write a string with at least 40 characters");

                str = Console.ReadLine();

                while (str != null && str.Length < 40)
                {
                    Console.WriteLine($"Your string has only {str.Length} Please, Write a text with at least 40 characters");
                    str = Console.ReadLine();
                }

                Console.WriteLine("Option (1): Word replace");
                Console.WriteLine("Option (2): String search");
                Console.WriteLine("Option (3): Start string search");
                Console.WriteLine("Option (4): Exit");


                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1: //Word replace
                        Console.WriteLine("Please select one word to replace");
                        oldChar = Console.ReadLine().Trim();

                        Console.WriteLine("Please select the new word");
                        newChar = Console.ReadLine().Trim();

                        str = str.Replace(oldChar, newChar);
                        Console.WriteLine(str);
                        break;


                    case 2: //String search
                        Console.WriteLine("What text do you want to search?");
                        findString = Console.ReadLine();

                        if (str.Contains(findString))
                        {
                            Console.WriteLine("The given text exists! :)");
                        }
                        else
                        {
                            Console.WriteLine("The given text doesn't exist :(");
                        }
                        
                        break;


                    case 3: //Start string search
                        Console.WriteLine("What do you want to search for the start?");
                        findString = Console.ReadLine();

                        if (str.StartsWith(findString))
                        {
                            Console.WriteLine($"Your text start with '{findString}'");
                        }
                        else
                        {
                            Console.WriteLine($"Your text doesn't have '{findString}'");
                        }
                        break;


                    case 4: //Exit
                        exit = true;
                        break;


                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("See you soon!");


        }
    }
}



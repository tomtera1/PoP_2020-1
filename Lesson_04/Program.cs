using System;
using System.Globalization;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Enc();
        }

        private static void Piramid()
        {
            int i, j, rows;

            rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
        private static void Diamond()
        {
            int i, j, rows;

            rows = int.Parse(Console.ReadLine());

            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for(j=1;j<=2*i-1;j++)
                    Console.Write("*");
                Console.Write("\n");
            } 
            
            for (i = rows-1; i >= 1; i--)
            {
                for (j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for(j=1;j<=2*i-1;j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        private static void Enc()
        {

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Alphabet = new char[alphabet.Length];
            for (int i = 0; i < alphabet.Length; i++)
            {
                Alphabet[i] = char.ToUpper(alphabet[i]);
            }
            char[] reverse = new char[2 * (alphabet.Length)];
            string A = new string(Alphabet);
            string a = new string(alphabet);
            for (int i = 0; i < alphabet.Length; i++)
            {
                reverse[i] = alphabet[alphabet.Length - 1 - i];
                reverse[alphabet.Length + i] = A[Alphabet.Length - 1 - i];
            }
            Console.WriteLine("Message: ");
            string m = Console.ReadLine();
            char[] reversemessage = new char[m.Length];
            char[] message = m.ToCharArray();
            int index = 0;
            double num = 0;
            for (int j = 0; j < message.Length; j++)
            {
                if (char.IsLetter(message[j]))
                {

                    if (char.IsUpper(message[j]))
                    {
                        index = A.IndexOf(message[j]);
                        reversemessage[j] = reverse[alphabet.Length + index];
                    }
                    else
                    {
                        index = a.IndexOf(message[j]);
                        reversemessage[j] = reverse[index];
                    }

                }
                else
                {
                    if (char.IsPunctuation(message[j]))
                    {
                        reversemessage[j] = message[j];
                    }
                    if (char.IsNumber(message[j]))
                    {
                        num = 9 - char.GetNumericValue(message[j]);
                        reversemessage[j] = (char)(num + '0');
                    }
                    else
                    {
                        continue;
                    }
                }

            }

            Console.WriteLine();
            foreach (char elem in reversemessage)
            {
                Console.Write(elem);
            }

        }

    }



        }

    

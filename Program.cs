using System;

namespace UsandoIfElseMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = Convert.ToInt32(Console.ReadLine());

            if(mes == 1)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }
            
            else if(mes == 2)
            {
                Console.WriteLine("Este mes tem 28 ou 29 dias");
            }
            
            else if(mes == 3)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }

            else if(mes == 5)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }

            else if(mes == 7)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }

            else if(mes == 8)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }

            else if(mes == 10)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }

            else if(mes == 12)
            {
                Console.WriteLine("Este mes tem 31 dias");
            }
            else
            {
                Console.WriteLine("Este mes tem 30 dias");
            }
        }
    }
}

using System;

namespace ConsoleAppWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lista de Números Multiplos de (3) e (5)");
            
            for (int num = 0; num <= 100; num++)
            {
                
                //Verificando se o número é multiplo de 3
                if (num %3 ==0)
                {
                    Console.WriteLine(num + " Nome ");
                    //Verificando se o número é multiplo de 5
                    if (num %5 ==0)
                    {
                        Console.WriteLine(num + " Sobrenome ");
                        
                        

                    }
                }
            }
            
            Console.Write("Pressione alguma tecla para sair !");

            Console.ReadKey();


        }
    }
}

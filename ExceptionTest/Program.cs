using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Insere um número inteiro: ");

            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número inserido: {i}");
            }
            catch(Exception e)
            {
                Console.Write("Ocorreu o seguinte problema: " + e.Message);    
            }
            Console.WriteLine("Número inserido: " + i);
        }
    }
}

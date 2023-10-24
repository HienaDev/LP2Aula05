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
            catch(FormatException)
            {
                Console.WriteLine("Tem que inserir um número inteiro");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Tem que ser menor que " + int.MaxValue);
            }
            catch(Exception e)
            {
                Console.Write("Ocorreu o seguinte problema: " + e.Message);    
            }
            Console.WriteLine("Número inserido: " + i);
        }
    }
}

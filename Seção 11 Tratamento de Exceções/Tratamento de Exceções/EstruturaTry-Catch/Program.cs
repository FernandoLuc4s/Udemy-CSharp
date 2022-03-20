using System;

namespace EstruturaTry_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try // = tenta executar esse código
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException) // = se ocorrer alguma excessão  
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e) 
            {
                Console.WriteLine("Format error! "+e.Message);
            }

        }
    }
}

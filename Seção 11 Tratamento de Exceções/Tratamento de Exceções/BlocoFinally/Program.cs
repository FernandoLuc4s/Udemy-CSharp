using System;
using System.IO;

namespace BlocoFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally // testa se está e aberto e fecha
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

        }
    }
}

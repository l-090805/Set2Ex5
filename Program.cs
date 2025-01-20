using System.Linq.Expressions;

namespace Set2Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti dimensiunea sirului de numere: ");
            int n = int.Parse(Console.ReadLine());

            int element;
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if(element == i)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Nu exista elemente egale cu pozitia lor");
            }
            else
            {
                Console.WriteLine($"Exista {count} elemente care sunt egale cu pozitia pe care se afla");
            }
            
        }
    }
}

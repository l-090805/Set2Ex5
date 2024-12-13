namespace Set2Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului: ");
            for(int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;

            for(int i = 0;i < v.Length;i++)
            {
                if(v[i] == i)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Nu exista nici un element egal cu pozitia sa");
                }
            }
            Console.WriteLine($"In vectorul introdus exista {count} numere care sunt egale cu pozitia pe care se afla");
            
        }
    }
}

using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace cows_and_bulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulls = 0;
            int cows = 0;
            string choose_number()
                {
                int x = 0;
                int y = 0;
                int w = 0;
                int z = 0;
                Random random = new Random();
                x = random.Next(10);
                y = random.Next(10);
                z = random.Next(10);
                w = random.Next(10);
                while (x == 0)
                {
                    x = random.Next(10);
                }
                while (y == x)
                {
                    y = random.Next(10);
                }
                while (z == y || z == x)
                {
                    z = random.Next(10);
                }
                while (w == x || w == y || w == z)
                {
                    w = random.Next(10);
                }
                string x1 = Convert.ToString(x);
                string y1 = Convert.ToString(y);
                string z1 = Convert.ToString(z);
                string w1 = Convert.ToString(w);
                return x1 + y1 + z1 + w1;
            }

            string secret = choose_number();
            string user = Console.ReadLine();
            char[] digits = user.ToCharArray();
            for (int i = 1; i < 5; i++)
            {

            }
        }
    }
}

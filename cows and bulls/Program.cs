using System.Globalization;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace cows_and_bulls
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            char[] comp = secret.ToCharArray();
            int bulls = 0;
            int cows = 0;
            char[] digits = { '1', '2', '3', '4'};
            while (bulls != 4)
            {
                cows = 0;
                bulls = 0;
                string user = Console.ReadLine();
                digits = user.ToCharArray();
                if (digits[0] == '0')
                {
                    Console.WriteLine("cant have 0 start");
                }
                for (int i = 0; i < digits.Length; i++)
                {
                    for (int j = i + 1; j < digits.Length; j++)
                    {
                        if (digits[i] == digits[j])
                        {
                            Console.WriteLine("cant have any same digits");
                            goto here;
                        }
                    }
                }
            here:
                for (int i = 0; i < 4; i++)
                {
                    if (digits[i] == secret[i])
                    {
                        bulls++;
                    }
                    else if (secret.Contains(digits[i]))
                    {
                        cows++;
                    }
                }
                Console.WriteLine(cows + " cows " + bulls + " bulls ");
            }
            Console.WriteLine("DONE");
        }
    }
}

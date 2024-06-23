using System.Threading.Channels;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Add(2, 7);
            //Add(3.2, 8.6);
            Add(12, 1, true);
            Add(1,0, true);
            Add(18, 1, false);

            // NEED HELP!
            //Console.WriteLine("Hello, please give me two numbers to add:");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int add2 = Add(int x, int y);
            //Console.WriteLine($"{x} + {y} = {add2}");

            //Console.WriteLine("Now give me two decimals to add:");
            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());
            //int addDouble = (int)Add(x, y);
            //Console.WriteLine($"{x} + {y} = {addDouble}");

        }

        public static int Add (int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isTrue)
        {
            //var sum = x + y;

            if (isTrue == true && (x + y) > 1)
            {
                Console.WriteLine($"You have {x + y} dollars");
            }
            else if (isTrue == true && (x + y) == 1)
            {
                Console.WriteLine($"You have {x + y} dollar");
            }
            
            else
            {
                Console.WriteLine($"{x + y}");
               
            }
            return "";
        }

        
    }
}

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isCheck)
           
        {
            var sum = a + b;
            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }


        

        

        static void Main(string[] args)

        {


            Console.WriteLine(Add(3, 5));
            Console.WriteLine(Add(.3, .4));
            Console.WriteLine(Add(6, 7, true));

        
          
        }
        
    }
}

namespace FirstCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first input: ");
            int var1;
            while (true)
            {
                try
                {
                    var1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You can only enter int number");
                }

            }
            Console.Write("Enter the second input: ");
            int var2 = int.Parse(Console.ReadLine());
            int Sum = sum(var1, var2);

            Console.Write("Sum is: " + Sum);


        }
        public static int sum(int var1, int var2)
        {
            return var1 + var2;
        }
    }
    
}
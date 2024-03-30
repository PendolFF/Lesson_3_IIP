
internal class Program
{
    private static void Main(string[] args)
    {
        void Square(int n)
        {
            int i = 0;
            while (i <= n)
            {
                Console.WriteLine($"{i * i} ");
                i++;
            }
        }
        Square(Convert.ToInt32(Console.ReadLine()));
    }
}
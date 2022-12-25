internal class Program
{
     static void Main(string[] args)
    {
        //Perfect Numbers//


        Console.WriteLine("Enter n1 & n2");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int sum;

        for (int i = n1; i <= n2; i++)
        {
            int j = 1;
            sum = 0;
            while (j < i)
            {
                if (i % j == 0)
                {
                    sum = sum + j;

                }
                j++;
            }
            if (sum == i)
                Console.WriteLine("{0}", i);


        }
    }
}
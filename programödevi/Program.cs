namespace Programodev
{
    internal class Program
    {
        static void Main(string[] args)
       
            {
                Console.WriteLine("Enter the starting number : ");
                byte baslangıc = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter the ending number : ");
                int bitis = int.Parse(Console.ReadLine());
                Console.WriteLine("How many numbers do you want? : ");
                int numbers = int.Parse(Console.ReadLine());

                Random rnd = new Random();
                int[] sayi = new int[numbers];
                int number;
                for (int i = 0; i < sayi.Length; i++)
                {
                    number = rnd.Next(baslangıc, bitis);
                    if (i == 0)
                    {
                        sayi[i] = number;
                    }

                    for (int j = 0; j < i; j++)
                    {
                        if (sayi[j] == number)
                        {
                            i--;
                            break;
                        }
                        else
                        {
                            sayi[i] = number;
                        }
                    }
                }
                Array.Sort(sayi);
                for (int i = 0; i < sayi.Length; i++)
                {
                    Console.WriteLine(sayi[i]);
                }
            Console.ReadKey();
     
        }

    }
}
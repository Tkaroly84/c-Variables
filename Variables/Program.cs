namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 42;

            int j = 74;

            string aaa = "aaa";

            string number = "100";
            int x = int.Parse(number);

            //Console.WriteLine(x);


            int charnum = Console.Read();
            Console.WriteLine(charnum);
            Console.ReadLine();

            string inputText = Console.ReadLine();
            Console.WriteLine(inputText);

            Console.ReadLine();


            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key.Key);


        }
    }
}

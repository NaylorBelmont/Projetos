using System;

namespace CowSay
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "use o argumento -t para o texto", olhos = "oo";

            if (args.Length == 2)
                texto = args[1];

            if (args.Length == 4)
            {
                texto = args[1];
                olhos = args[3];
            }
            //Console.WriteLine(args.Length);
            //Console.WriteLine(args[0]);
            //Console.WriteLine("Entre o texto que a vaca vai falar:");
            //var texto = Console.ReadLine();
            //Console.ReadKey();
            Console.Clear();

            Console.Write("/");
            for (int i = 0; i < texto.Length + 6; i++)
                Console.Write("-");
            Console.WriteLine(@"\");

            Console.Write(@"|   ");
            Console.Write(texto);
            Console.WriteLine(@"   |");

            Console.Write(@"\");
            for (int i = 0; i < texto.Length + 6; i++)
                Console.Write("-");
            Console.WriteLine(@"/");

            string vaquinha = @"       \   ^__^
        \  (" + olhos + @")\_______
           (__)\       )\/\
               ||----w |
               ||     ||";

            Console.Write(vaquinha);
            Console.WriteLine("");
            Console.WriteLine("");

            Environment.Exit(0);
        }
    }
}

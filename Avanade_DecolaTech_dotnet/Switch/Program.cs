using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            log($"{!!(2==2)}");
            int num = args.Length;
            
            switch (num)
            {
                case 0:
                    log("0 argumentos");
                    break;
                case 1:
                    log("caso 1");
                    break;
                case 2:
                    log("caso 2");
                    break;
                default:
                    log("default");
                    log($"{num} argumentos");
                    break;
        }
        }

        private static void log(String line){
            Console.WriteLine(line);
        }
    }
}

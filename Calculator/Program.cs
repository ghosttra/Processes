using System;
using System.Data;

namespace Calculator {
    internal class Calc {
        static void Main(string[] args) {
            if (args.Length == 0) return;
            DataTable dt = new DataTable();
            foreach (var item in args)
                Console.WriteLine(item);
            Console.Write("Result: ");
            Console.WriteLine(dt.Compute(args[0] + args[2] + args[1], ""));
            
            Console.ReadLine();
        }
    }
}

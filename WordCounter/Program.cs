using System;
using System.IO;

namespace WordCounter {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length == 0) return;

            string filePath = string.Empty;

            if (args.Length > 2) {
                filePath += args[0] + " ";
                for (int i = 1; i < args.Length - 1; i++) {
                    filePath += args[i] + " ";
                }
            }
            string res;
            using (StreamReader sr = new StreamReader(filePath)) {
                res = sr.ReadToEnd();
            }
            Console.WriteLine(res);
            Console.ReadLine();
            char[] delimiterChars = { ' ', ',', '.', ':' };
            var arr = res.Split(delimiterChars);
            int counter = 0;
            string arg = args[args.Length - 1].ToLower();
            foreach (var item in arr) {
                if (item.ToLower() == arg) counter++; 
            }
            Console.WriteLine($"Result: {counter}");
            Console.ReadLine();
        }
    }
}


using System;
using System.IO;

class Program {
    static void Main() {
        using(var reader = new StreamReader("large.csv")) {
            int count = 0;
            string line;
            while((line = reader.ReadLine()) != null) {
                count++;
                if(count % 100 == 0)
                    Console.WriteLine("Processed: " + count);
            }
        }
    }
}

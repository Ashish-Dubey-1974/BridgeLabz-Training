
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        var lines = File.ReadAllLines("data.csv");
        Regex email = new Regex(@"^[^@]+@[^@]+\.[^@]+$");
        Regex phone = new Regex(@"^\d{10}$");

        for(int i=1;i<lines.Length;i++) {
            var d = lines[i].Split(',');
            if(!email.IsMatch(d[2]) || !phone.IsMatch(d[3]))
                Console.WriteLine("Invalid Row: " + lines[i]);
        }
    }
}


using System;
using System.IO;
using System.Collections.Generic;

class Program {
    static void Main() {
        var lines = File.ReadAllLines("students.csv");
        HashSet<string> ids = new HashSet<string>();

        for(int i=1;i<lines.Length;i++) {
            var id = lines[i].Split(',')[0];
            if(!ids.Add(id))
                Console.WriteLine("Duplicate Record: " + lines[i]);
        }
    }
}

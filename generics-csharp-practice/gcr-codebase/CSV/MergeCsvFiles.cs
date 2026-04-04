
using System;
using System.IO;
using System.Linq;

class Program {
    static void Main() {
        var s1 = File.ReadAllLines("students1.csv").Skip(1)
            .Select(l => l.Split(','));
        var s2 = File.ReadAllLines("students2.csv").Skip(1)
            .Select(l => l.Split(','));

        var result = from a in s1
                     join b in s2 on a[0] equals b[0]
                     select $"{a[0]},{a[1]},{a[2]},{b[1]},{b[2]}";

        File.WriteAllLines("merged.csv", result);
    }
}

using System;

class ATMDispenser
{
    static void DispenseCash(int amount, int[] notes)
    {
        int remaining = amount;
        bool dispensed = false;

        Console.WriteLine("Dispensing for Amount: ?" + amount);

        foreach (int note in notes)
        {
            int count = remaining / note;
            if (count > 0)
            {
                Console.WriteLine("?" + note + " x " + count);
                remaining -= note * count;
                dispensed = true;
            }
        }

        if (remaining > 0)
        {
            Console.WriteLine("? Exact change not possible.");
            Console.WriteLine("Remaining amount: ?" + remaining);
        }
        else if (!dispensed)
        {
            Console.WriteLine("No cash dispensed.");
        }
        else
        {
            Console.WriteLine("? Cash dispensed successfully.");
        }

        Console.WriteLine("--------------------------------");
    }

    static void Main()
    {
        int amount = 880;

        // Scenario A
        int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        Console.WriteLine("Scenario A: All notes available");
        DispenseCash(amount, notesA);

        // Scenario B
        int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
        Console.WriteLine("Scenario B: ?500 note removed");
        DispenseCash(amount, notesB);

        // Scenario C for fallback check we remove 1 or 2 rs
        int oddAmount = 883;
        int[] notesC = { 200, 100, 50, 20, 10, 5};
        Console.WriteLine("Scenario C: Fallback example");
        DispenseCash(oddAmount, notesC);
    }
}

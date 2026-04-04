using System;

namespace BrowserBuddy
{
    internal class UserMenu
    {
        public void Show()
        {
            BrowserTab tab = new BrowserTab();

            while (true)
            {
                Console.WriteLine("\n--- BrowserBuddy ---");
                Console.WriteLine("1. Visit Page");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Close Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Exit");
                Console.Write("Choose: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        tab.Visit(Console.ReadLine());
                        break;
                    case 2:
                        tab.Back();
                        break;
                    case 3:
                        tab.Forward();
                        break;
                    case 4:
                        tab.Close();
                        break;
                    case 5:
                        tab.Restore();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}

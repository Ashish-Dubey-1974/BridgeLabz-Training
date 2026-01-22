
using System;

namespace AmbulanceRoute
{
    internal class Utility : IRoute
    {
        Unit head = null;

        public Utility()
        {
            AddDefaultUnits();
        }

        void AddDefaultUnits()
        {
            AddUnitInternal("Emergency");
            AddUnitInternal("Radiology");
            AddUnitInternal("Surgery");
            AddUnitInternal("ICU");
        }

        void AddUnitInternal(string name)
        {
            Unit newUnit = new Unit(name);

            if (head == null)
            {
                head = newUnit;
                head.Next = head;
                return;
            }

            Unit temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newUnit;
            newUnit.Next = head;
        }

        public void AddUnit()
        {
            Console.Write("Enter Unit Name: ");
            string name = Console.ReadLine();
            AddUnitInternal(name);
            Console.WriteLine("Unit added successfully.");
        }

        public void RemoveUnit()
        {
            if (head == null)
            {
                Console.WriteLine("No units present.");
                return;
            }

            Console.Write("Enter Unit Name to remove: ");
            string name = Console.ReadLine();

            Unit curr = head, prev = null;

            do
            {
                if (curr.Name == name)
                {
                    if (curr == head && curr.Next == head)
                    {
                        head = null;
                    }
                    else
                    {
                        if (curr == head)
                        {
                            Unit last = head;
                            while (last.Next != head)
                                last = last.Next;

                            head = head.Next;
                            last.Next = head;
                        }
                        else
                        {
                            prev.Next = curr.Next;
                        }
                    }

                    Console.WriteLine("Unit removed (Maintenance Mode).");
                    return;
                }

                prev = curr;
                curr = curr.Next;

            } while (curr != head);

            Console.WriteLine("Unit not found.");
        }

        public void FindAvailableUnit()
        {
            if (head == null)
            {
                Console.WriteLine("No hospital units available.");
                return;
            }

            Unit temp = head;
            do
            {
                if (temp.IsAvailable)
                {
                    Console.WriteLine("Redirect patient to: " + temp.Name);
                    return;
                }
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("No available unit currently.");
        }

        public void DisplayRoute()
        {
            if (head == null)
            {
                Console.WriteLine("No units available.");
                return;
            }

            Unit temp = head;
            Console.WriteLine("Circular Hospital Route:");
            do
            {
                Console.Write(temp.Name + " → ");
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("(Back to " + head.Name + ")");
        }
    }
}

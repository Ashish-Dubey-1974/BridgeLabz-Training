
using System;
using System.Collections.Generic;

namespace TrafficManager
{

    class Vehicle
    {
        public string Number;
        public Vehicle Next;

        public Vehicle(string number)
        {
            Number = number;
            Next = null;
        }
    }
    class CircularRoundabout
    {
        private Vehicle last = null;

        public void AddVehicle(string number)
        {
            Vehicle newVehicle = new Vehicle(number);

            if (last == null)
            {
                last = newVehicle;
                last.Next = last;
            }
            else
            {
                newVehicle.Next = last.Next;
                last.Next = newVehicle;
                last = newVehicle;
            }

            Console.WriteLine("Vehicle added: " + number);
        }

        public void RemoveVehicle()
        {
            if (last == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            if (last.Next == last)
            {
                Console.WriteLine("Vehicle removed: " + last.Number);
                last = null;
            }
            else
            {
                Vehicle temp = last.Next;
                Console.WriteLine("Vehicle removed: " + temp.Number);
                last.Next = temp.Next;
            }
        }

        public void Display()
        {
            if (last == null)
            {
                Console.WriteLine("Roundabout empty.");
                return;
            }

            Vehicle temp = last.Next;
            Console.Write("Roundabout State: ");
            do
            {
                Console.Write(temp.Number + " -> ");
                temp = temp.Next;
            } while (temp != last.Next);

            Console.WriteLine("(back to start)");
        }
    }

    class EntryQueue
    {
        private Queue<string> queue = new Queue<string>();
        private int capacity;

        public EntryQueue(int size)
        {
            capacity = size;
        }

        public void Enqueue(string vehicle)
        {
            if (queue.Count == capacity)
            {
                Console.WriteLine("Queue Overflow! Vehicle cannot enter.");
                return;
            }

            queue.Enqueue(vehicle);
            Console.WriteLine("Vehicle waiting: " + vehicle);
        }

        public string Dequeue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue Underflow! No vehicles waiting.");
                return null;
            }

            return queue.Dequeue();
        }
    }

    class Program
    {
        static void Main()
        {
            CircularRoundabout roundabout = new CircularRoundabout();
            EntryQueue queue = new EntryQueue(5);

            queue.Enqueue("KA01");
            queue.Enqueue("KA02");
            queue.Enqueue("KA03");

            string v = queue.Dequeue();
            if (v != null) roundabout.AddVehicle(v);

            roundabout.AddVehicle("KA04");
            roundabout.Display();

            roundabout.RemoveVehicle();
            roundabout.Display();
        }
    }
}

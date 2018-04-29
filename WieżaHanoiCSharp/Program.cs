using System;
using System.Diagnostics;

namespace WieżaHanoiCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Stopwatch MyTimer = new Stopwatch();

            MyTimer.Start();
            p1.MoveTowerDisk(4, "A", "B", "C");
            MyTimer.Stop();
            Console.WriteLine("Hanoi Tower solved in {0}, for 4 disk", MyTimer.Elapsed);
        }

        public void MoveTowerDisk(int intDisks, string strFromTower, string strToTower, string strViaTower)
        {
            if (intDisks > 0)
            {
                MoveTowerDisk(intDisks - 1, strFromTower, strViaTower, strToTower);
//                Console.WriteLine("Move disk {0} from {1} to {2}", intDisks, strFromTower, strToTower);
                MoveTowerDisk(intDisks - 1, strViaTower, strToTower, strFromTower);
            }
        }
    }
}

using System;
using System.Diagnostics;

namespace WieżaHanoiCSharp
{
    class Program
    {
        private int intMoves = 0;
        static void Main(string[] args)
        {
            Console.Clear();
            Program p1 = new Program();
            Stopwatch MyTimer = new Stopwatch();

            int intDisks = 0;
            Int32.TryParse(args[0], out intDisks);
//            Int32.TryParse(Console.ReadLine(), out intDisks);

            MyTimer.Start();
            p1.MoveTowerDisk(intDisks, "A", "B", "C");
            MyTimer.Stop();

            Console.WriteLine("Hanoi Tower solved in {0}, for {1} disks | Move count: {2}.", MyTimer.Elapsed, intDisks, p1.intMoves);
        }

        public void MoveTowerDisk(int intDisks, string strFromTower, string strToTower, string strViaTower)
        {
            if (intDisks > 0)
            {
                intMoves += 1;
                MoveTowerDisk(intDisks - 1, strFromTower, strViaTower, strToTower);
 //               Console.WriteLine("Move disk {0} from {1} to {2}", intDisks, strFromTower, strToTower);
                MoveTowerDisk(intDisks - 1, strViaTower, strToTower, strFromTower);
            }
        }
    }
}
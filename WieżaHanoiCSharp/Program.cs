using System;

namespace WieżaHanoiCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.MoveTowerDisk(4, "A", "B", "C");
        }

        public void MoveTowerDisk(int intDisks, string strFromTower, string strToTower, string strViaTower)
        {
            if (intDisks > 0)
            {
                MoveTowerDisk(intDisks - 1, strFromTower, strViaTower, strToTower);
                Console.WriteLine("Move disk {0} from {1} to {2}", intDisks, strFromTower, strToTower);
                MoveTowerDisk(intDisks - 1, strViaTower, strToTower, strFromTower);
            }
        }
    }
}

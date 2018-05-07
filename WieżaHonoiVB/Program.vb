Imports System

Module Program
    Private intMoves = 0

    Sub Main(args As String())
        
        Dim intDisks As Integer
        intDisks = 0

        Console.Clear()

        Integer.TryParse(Console.ReadLine(), intDisks)

        Dim MyTimer = Stopwatch.StartNew()
        MoveTowerDisk(intDisks, "A", "B", "C")
        MyTimer.Stop()

        Console.WriteLine("Hanoi Tower solved in {0}, for {1} disks | Move count: {2}.", MyTimer.Elapsed, intDisks, intMoves)
    End Sub

    Sub MoveTowerDisk(ByVal intDisks As Integer, ByVal strFromTower As String, ByVal strToTower As String, ByVal strViaTower As String)
        If intDisks > 0 Then
            intMoves = intMoves + 1
            MoveTowerDisk(intDisks - 1, strFromTower, strViaTower, strToTower)
'            Console.WriteLine("Move disk {0} from {1} to {2}", intDisks, strFromTower, strToTower)
            MoveTowerDisk(intDisks - 1, strViaTower, strToTower, strFromTower)
        End If    
    End Sub
End Module

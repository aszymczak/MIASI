Imports System

Module Program
    Sub Main(args As String())

        Dim MyTimer = Stopwatch.StartNew()
        MoveTowerDisk(4, "A", "B", "C")
        MyTimer.Stop()
        Console.WriteLine("Hanoi Tower solved in {0}, for 4 disk", MyTimer.Elapsed)
    End Sub

    Sub MoveTowerDisk(ByVal intDisks As Integer, ByVal strFromTower As String, ByVal strToTower As String, ByVal strViaTower As String)
        If intDisks > 0 Then
            MoveTowerDisk(intDisks - 1, strFromTower, strViaTower, strToTower)
'            Console.WriteLine("Move disk {0} from {1} to {2}", intDisks, strFromTower, strToTower)
            MoveTowerDisk(intDisks - 1, strViaTower, strToTower, strFromTower)
        End If    
    End Sub
End Module

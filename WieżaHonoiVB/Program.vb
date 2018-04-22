Imports System

Module Program
    Sub Main(args As String())
        MoveTowerDisk(4, "A", "B", "C")
    End Sub

    Sub MoveTowerDisk(ByVal intDisks As Integer, ByVal strFromTower As String, ByVal strToTower As String, ByVal strViaTower As String)
        If intDisks > 0 Then
            MoveTowerDisk(intDisks - 1, strFromTower, strViaTower, strToTower)
            Console.WriteLine("Move disk {0} from {1} to {2}", intDisks, strFromTower, strToTower)
            MoveTowerDisk(intDisks - 1, strViaTower, strToTower, strFromTower)
        End If    
    End Sub
End Module

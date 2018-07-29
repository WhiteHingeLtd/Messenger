
Imports System
Imports System.Collections
Imports System.Runtime.InteropServices
Imports System.Text

Namespace DeploymentUtilities

    <StructLayout(LayoutKind.Sequential)>
    Public Structure FLASHWINFO

        Public cbSize As UInteger

        Public hwnd As IntPtr

        Public dwFlags As UInteger

        Public uCount As UInteger

        Public dwTimeout As UInteger
    End Structure

    Class DeploymentUtilsWin32

        <DllImport("user32.Dll")>
        Private Shared Function EnumWindows(ByVal callback As EnumWindowsCallbackDelegate, ByVal lParam As IntPtr) As Integer
        End Function

        <DllImport("User32.Dll")>
        Private Shared Sub GetWindowText(ByVal h As Integer, ByVal s As StringBuilder, ByVal nMaxCount As Integer)
        End Sub

        <DllImport("User32.Dll")>
        Private Shared Sub GetClassName(ByVal h As Integer, ByVal s As StringBuilder, ByVal nMaxCount As Integer)
        End Sub

        <DllImport("User32.Dll")>
        Private Shared Function EnumChildWindows(ByVal hwndParent As IntPtr, ByVal lpEnumFunc As EnumWindowsCallbackDelegate, ByVal lParam As IntPtr) As Boolean
        End Function

        <DllImport("User32.Dll")>
        Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        End Function

        Private Delegate Function EnumWindowsCallbackDelegate(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Boolean

        Private Const BM_CLICK As Integer = 245

        Public Function SearchForTopLevelWindow(ByVal WindowTitle As String) As IntPtr
            Dim windowHandles As ArrayList = New ArrayList()
            Dim gch As GCHandle = GCHandle.Alloc(windowHandles)
            Try
                EnumWindows(New EnumWindowsCallbackDelegate(AddressOf EnumProc), CType(gch, IntPtr))
            Finally
                gch.Free()
            End Try

            For Each handle As IntPtr In windowHandles
                Dim sb As StringBuilder = New StringBuilder(1024)
                GetWindowText(CInt(handle), sb, sb.Capacity)
                If sb.Length > 0 Then
                    If sb.ToString().StartsWith(WindowTitle) Then
                        Return handle
                    End If
                End If
            Next

            Return IntPtr.Zero
        End Function

        Public Function SearchForChildWindow(ByVal ParentHandle As IntPtr, ByVal Caption As String) As IntPtr
            Dim windowHandles As ArrayList = New ArrayList()
            Dim gch As GCHandle = GCHandle.Alloc(windowHandles)
            Try
                EnumChildWindows(ParentHandle, New EnumWindowsCallbackDelegate(AddressOf EnumProc), CType(gch, IntPtr))
            Finally
                gch.Free()
            End Try

            For Each handle As IntPtr In windowHandles
                Dim sb As StringBuilder = New StringBuilder(1024)
                GetWindowText(CInt(handle), sb, sb.Capacity)
                If sb.Length > 0 Then
                    If sb.ToString().StartsWith(Caption) Then
                        Return handle
                    End If
                End If
            Next

            Return IntPtr.Zero
        End Function

        Private Shared Function EnumProc(ByVal hWnd As IntPtr, ByVal lParam As IntPtr) As Boolean
            Dim gch As GCHandle = CType(lParam, GCHandle)
            Dim list As ArrayList = CType((gch.Target), ArrayList)
            list.Add(hWnd)
            Return True
        End Function

        Public Shared Sub DoButtonClick(ByVal ButtonHandle As IntPtr)
            SendMessage(ButtonHandle, BM_CLICK, IntPtr.Zero, IntPtr.Zero)
        End Sub

        Public Shared Function FlashWindowAPI(ByVal handleToWindow As IntPtr) As Boolean
            Dim flashwinfo1 As FLASHWINFO = New FLASHWINFO()
            flashwinfo1.cbSize = CUInt(Marshal.SizeOf(flashwinfo1))
            flashwinfo1.hwnd = handleToWindow
            flashwinfo1.dwFlags = 15
            flashwinfo1.uCount = UInteger.MaxValue
            flashwinfo1.dwTimeout = 0
            Return(DeploymentUtilsWin32.FlashWindowEx(flashwinfo1) = 0)
        End Function

        <DllImport("user32.dll")>
        Private Shared Function FlashWindowEx(ByRef pwfi As FLASHWINFO) As Short
        End Function

        Public Const FLASHW_ALL As UInteger = 3

        Public Const FLASHW_CAPTION As UInteger = 1

        Public Const FLASHW_STOP As UInteger = 0

        Public Const FLASHW_TIMER As UInteger = 4

        Public Const FLASHW_TIMERNOFG As UInteger = 12

        Public Const FLASHW_TRAY As UInteger = 2
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================

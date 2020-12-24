Namespace Extensions
    Module FormExtensions
        Private Declare Function SetWindowPos Lib "user32.dll" _
            Alias "SetWindowPos" (hWnd As IntPtr,hWndIntertAfter As IntPtr,X As Integer,Y As Integer,
                                  cx As Integer,cy As Integer,uFlags As Integer) As Boolean

        Private HWND_TOP As IntPtr = IntPtr.Zero
        Private Const SWP_SHOWWINDOW As Integer = 64


        <Runtime.CompilerServices.Extension()> _
        Public Sub FullScreen( sender As Form,  taskBar As Boolean)

            sender.WindowState = FormWindowState.Maximized
            sender.FormBorderStyle = FormBorderStyle.None
            sender.TopMost = True

            If taskBar Then

                SetWindowPos(sender.Handle, HWND_TOP, 0, 0,
                             Screen.PrimaryScreen.Bounds.Width,
                             Screen.PrimaryScreen.Bounds.Height ,
                             SWP_SHOWWINDOW _
                             )

            End If

        End Sub
        <Runtime.CompilerServices.Extension()> _
        Public Sub NormalMode(ByVal sender As Form)
            sender.WindowState = FormWindowState.Normal
            sender.FormBorderStyle = FormBorderStyle.FixedSingle
            sender.TopMost = True
        End Sub
    End Module
End NameSpace
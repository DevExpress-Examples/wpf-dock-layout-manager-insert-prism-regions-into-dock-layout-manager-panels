Imports System
Imports System.Linq
Imports System.Windows

Namespace PrismSupportSample
    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Partial Public Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            Dim bootstrapper As New Bootstrapper()
            bootstrapper.Run()
        End Sub
    End Class
End Namespace

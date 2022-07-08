Imports System.Windows

Namespace PrismSupportSample

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            Dim bootstrapper As Bootstrapper = New Bootstrapper()
            bootstrapper.Run()
        End Sub
    End Class
End Namespace

' Developer Express Code Central Example:
' Using DXDocking for WPF in accordance with Composite Application Guidelines
' 
' This example contains a DXDocking (http://devexpress.com/DXDocking) to Prism
' (http://www.codeplex.com/CompositeWPF) adapter that allows you to use the
' DXDocking for WPF in your composite applications.
' The sample for version
' v10.2.5 supports Prism 4
' 
' See Also:
' Prism: patterns & practices Composite
' Application Guidance for WPF and Silverlight site
' (http://compositewpf.codeplex.com/)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1926


Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Docking
Imports Microsoft.Practices.Prism.UnityExtensions
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.ServiceLocation

Namespace PrismSupportSample
	Friend Class Bootstrapper
		Inherits UnityBootstrapper
		Protected Overrides Function CreateShell() As DependencyObject
			Dim shell As New Shell()
			shell.Show()
			Return shell
		End Function

		Protected Overrides Sub ConfigureModuleCatalog()
			MyBase.ConfigureModuleCatalog()

			Dim catalog As ModuleCatalog = CType(Me.ModuleCatalog, ModuleCatalog)
			catalog.AddModule(GetType(Modules.TeamList.TeamListModule))
			catalog.AddModule(GetType(Modules.Contacts.ContactsModule))
			catalog.AddModule(GetType(Modules.Stuff.StuffModule))
			catalog.AddModule(GetType(Modules.Projects.ProjectModule))
			catalog.AddModule(GetType(Modules.Chart.ChartModule))

		End Sub
		Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
			Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
			If mappings IsNot Nothing Then
				'mappings.RegisterMapping(typeof(DockLayoutManager), ServiceLocator.Current.GetInstance<DockManagerAdapter>());
				mappings.RegisterMapping(GetType(LayoutPanel), ServiceLocator.Current.GetInstance(Of LayoutPanelAdapter)())

			End If
			Return mappings
		End Function
	End Class
End Namespace

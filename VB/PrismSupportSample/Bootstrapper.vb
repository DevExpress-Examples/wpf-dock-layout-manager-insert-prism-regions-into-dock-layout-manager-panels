Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Docking
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Composite.Modularity
Imports Microsoft.Practices.Composite.Presentation.Regions
Imports Microsoft.Practices.Composite.UnityExtensions

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

		Protected Overrides Function ConfigureRegionAdapterMappings() As Microsoft.Practices.Composite.Presentation.Regions.RegionAdapterMappings
			Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
			mappings.RegisterMapping(GetType(DockLayoutManager), Container.Resolve(Of DockManagerAdapter)())
			Return mappings
		End Function
	End Class
End Namespace

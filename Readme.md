
# WPF Dock Layout Manager - Insert PRISM Regions into DockLayoutManager Panels

This example defines a region at the [LayoutPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel) level and insert a view from another assembly into it. To create an instance of the PRISM adapter for a [LayoutPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel), use the AdapterFactory.Make method:

```cs
mappings.RegisterMapping(typeof(LayoutPanel), AdapterFactory.Make<RegionAdapterBase<LayoutPanel>>(factory));
```

<img src="https://user-images.githubusercontent.com/12169834/175358011-ac1b0321-5282-40d1-8aab-57b8948b5fd4.png" width=700px/>

## Documentation

- [Prism Adapters](https://docs.devexpress.com/WPF/117848/common-concepts/prism-adapters)

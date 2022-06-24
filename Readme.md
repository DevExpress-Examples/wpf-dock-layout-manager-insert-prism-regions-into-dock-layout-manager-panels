<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1926)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Dock Layout Manager - Insert PRISM Regions into DockLayoutManager Panels

This example defines a region at the [LayoutPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel) level and inserts a view from another assembly into this region. To create an instance of the PRISM adapter for a [LayoutPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel), use the AdapterFactory.Make method:


```cs
mappings.RegisterMapping(typeof(LayoutPanel), AdapterFactory.Make<RegionAdapterBase<LayoutPanel>>(factory));
```

<img src="https://user-images.githubusercontent.com/12169834/175358011-ac1b0321-5282-40d1-8aab-57b8948b5fd4.png" width=700px/>

## Documentation

- [Prism Adapters](https://docs.devexpress.com/WPF/117848/common-concepts/prism-adapters)

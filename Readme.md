# How to insert PRISM regions into DockLayoutManager panels


<p>This example demonstrates how define a region at the LayoutPanel level and insert a view from another assembly into it. To create an instance of the PRISM adapter for a LayoutPanel, use the AdapterFactory.Make method:</p>


```cs
mappings.RegisterMapping(typeof(LayoutPanel), AdapterFactory.Make<RegionAdapterBase<LayoutPanel>>(factory));
```



<br/>



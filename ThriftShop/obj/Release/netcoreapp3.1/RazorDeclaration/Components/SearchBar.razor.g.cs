#pragma checksum "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\Components\SearchBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa5be174f955718e2df809ef64d050cf9d85295"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ThriftShop.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using ThriftShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using ThriftShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using ThriftShop.Services.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using ThriftShop.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\_Imports.razor"
using ThriftShop.Components;

#line default
#line hidden
#nullable disable
    public partial class SearchBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Hank\source\repos\thrift_shop-dotNet-Blazor2\ThriftShop\Components\SearchBar.razor"
       
    private string filter;

    [Parameter]
    public EventCallback<string> OnSearch { get; set; }

    private void HandleSearch()
    {
        OnSearch.InvokeAsync(filter);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

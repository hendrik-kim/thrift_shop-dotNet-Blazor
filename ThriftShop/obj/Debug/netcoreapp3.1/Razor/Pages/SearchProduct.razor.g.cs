#pragma checksum "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfe43a30d6a9a20f41373e3d430c40e43aa1706a"
// <auto-generated/>
#pragma warning disable 1591
namespace ThriftShop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using ThriftShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using ThriftShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using ThriftShop.Services.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using ThriftShop.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\_Imports.razor"
using ThriftShop.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class SearchProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Products</h3> \r\n<br>\r\n\r\n");
            __builder.OpenComponent<ThriftShop.Components.SearchBar>(1);
            __builder.AddAttribute(2, "OnSearch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor"
                     HandleSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(4, "ul");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 12 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor"
     foreach(var p in products)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "li");
            __builder.AddContent(8, 
#nullable restore
#line 14 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor"
             p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "li");
            __builder.AddContent(11, 
#nullable restore
#line 15 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor"
             p.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "li");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor"
             p.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 17 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Hank\Desktop\project\thrift-shop\ThriftShop\Pages\SearchProduct.razor"
        
    private IEnumerable<Product> products;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        products = searchProduct.Execute("");
    }

    private void HandleSearch(string filter)
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProduct searchProduct { get; set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccdeb099d22e00ec7eac56dc6edd97b179bba4e5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Hello, ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\Pages\Index.razor"
           upercase(name)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\Pages\Index.razor"
                   WriteInLog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "ClickMe");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "<h3>Movie</h3>\r\n    ");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, "Title: ");
            __builder.AddContent(12, 
#nullable restore
#line 9 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\Pages\Index.razor"
               Lucifer.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "p");
            __builder.AddContent(15, "ReleaseDate: ");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\Pages\Index.razor"
                     Lucifer.ReleaseDate.ToString("dd MM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\MydeskTop\Development\LAB\c#\Blazor\MyApp1\BlazorApp\BlazorApp\Client\Pages\Index.razor"
      

    string name = "vijay";
    string upercase(string value) => value.ToUpper();

    Movie Lucifer = new Movie()
    {
        Title = "Lucifer",
        ReleaseDate = new DateTime(2019, 8, 5)
    };

    void WriteInLog()
    {
        Console.WriteLine("i've been clicked! (from method)");

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
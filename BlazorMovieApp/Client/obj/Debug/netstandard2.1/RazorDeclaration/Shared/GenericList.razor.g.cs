#pragma checksum "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecc9556604df481157834b9db21171c989916ebd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovieApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using BlazorMovieApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using BlazorMovieApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\_Imports.razor"
using BlazorMovieApp.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
       

    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public List<TItem> ItemList { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

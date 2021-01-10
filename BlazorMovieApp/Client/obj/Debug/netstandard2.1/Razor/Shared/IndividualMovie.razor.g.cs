#pragma checksum "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "654cdbc412b295deade3f543c2af715c6fb4a248"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Title:");
            __builder.OpenElement(4, "b");
            __builder.AddContent(5, " ");
            __builder.AddContent(6, 
#nullable restore
#line 2 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\IndividualMovie.razor"
                  Indmovie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "ReleaseDate: ");
            __builder.OpenElement(10, "b");
            __builder.AddContent(11, 
#nullable restore
#line 3 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\IndividualMovie.razor"
                        Indmovie.ReleaseDate.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 5 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\IndividualMovie.razor"
 if (DisplayButtons)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\IndividualMovie.razor"
                            ()=>DeleteMovie.InvokeAsync(Indmovie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 11 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\IndividualMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\IndividualMovie.razor"
       
    [Parameter] public Movie Indmovie { get; set; }
    [Parameter] public bool DisplayButtons { get; set; } = false;
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }

    void Delete()
    {
        Console.WriteLine($"Deleting { Indmovie.Title }");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

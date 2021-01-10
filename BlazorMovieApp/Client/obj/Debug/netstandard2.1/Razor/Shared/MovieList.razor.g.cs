#pragma checksum "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dee666bf1e2875229a1e0a7cff91f94bad0469f"
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
    public partial class MovieList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "checkbox");
            __builder.AddAttribute(2, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 1 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\MovieList.razor"
                                    () => displayButtons = !displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __Blazor.BlazorMovieApp.Client.Shared.MovieList.TypeInference.CreateGenericList_0(__builder, 4, 5, 
#nullable restore
#line 3 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\MovieList.razor"
                       Movies

#line default
#line hidden
#nullable disable
            , 6, (movie) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<BlazorMovieApp.Client.Shared.IndividualMovie>(8);
                __builder2.AddAttribute(9, "Indmovie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovieApp.Shared.Entities.Movie>(
#nullable restore
#line 6 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\MovieList.razor"
                                   movie

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "DisplayButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\MovieList.razor"
                                                          displayButtons

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "DeleteMovie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMovieApp.Shared.Entities.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMovieApp.Shared.Entities.Movie>(this, 
#nullable restore
#line 7 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\MovieList.razor"
                                      DeleteMovie

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\MovieList.razor"
       
    [Parameter] public List<Movie> Movies { get; set; }
    bool displayButtons = false;
    private void DeleteMovie(Movie movie)
    {
        Movies.Remove(movie);
    }

    protected override void OnInitialized()
    {
        Console.WriteLine("OnInitialized. Movie.Count=" + Movies.Count());
    }
    protected override void OnParametersSet()
    {
        Console.WriteLine("OnParametersSet. Movie.Count=" + Movies.Count());
    }
    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("OnAfterRender. firstRender=" + firstRender.ToString());
    }
    protected override bool ShouldRender()
    {
        return true;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorMovieApp.Client.Shared.MovieList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::BlazorMovieApp.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ItemList", __arg0);
        __builder.AddAttribute(__seq1, "ElementTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecc9556604df481157834b9db21171c989916ebd"
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
 if (ItemList == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "NullTemplate....");
#nullable restore
#line 8 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
                                     
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "Loading....");
#nullable restore
#line 12 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
                                
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
     
}
else if (ItemList.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 19 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 19 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
                      
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "There re no record to show");
#nullable restore
#line 23 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
                                               
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
     
}

else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
     foreach (var element in ItemList)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 31 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
         ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 31 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\MydeskTop\Development\LAB\c#\Blazor\BlazorMovieApp\BlazorMovieApp\Client\Shared\GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
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
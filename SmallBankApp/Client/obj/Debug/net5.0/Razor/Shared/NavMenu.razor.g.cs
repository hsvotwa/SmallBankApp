#pragma checksum "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca44853aa5df50d7e80cd8fa45f2466c89face2c"
// <auto-generated/>
#pragma warning disable 1591
namespace SmallBankApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using SmallBankApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using SmallBankApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor"
using SmallBankApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-0cd1zt7y1v");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "navbar-brand");
            __builder.AddAttribute(5, "href");
            __builder.AddAttribute(6, "b-0cd1zt7y1v");
            __builder.AddContent(7, 
#nullable restore
#line 4 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor"
                                     SmallBankApp.Shared.Common.Constants.APP_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "navbar-toggler");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "b-0cd1zt7y1v");
            __builder.AddMarkupContent(13, "<span class=\"navbar-toggler-icon\" b-0cd1zt7y1v></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", 
#nullable restore
#line 10 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-0cd1zt7y1v");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "class", "nav flex-column");
            __builder.AddAttribute(21, "b-0cd1zt7y1v");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item px-3");
            __builder.AddAttribute(24, "b-0cd1zt7y1v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "class", "nav-link");
            __builder.AddAttribute(27, "href", "");
            __builder.AddAttribute(28, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-0cd1zt7y1v></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item px-3");
            __builder.AddAttribute(34, "b-0cd1zt7y1v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "counter");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-0cd1zt7y1v></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav-item px-3");
            __builder.AddAttribute(43, "b-0cd1zt7y1v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "fetchdata");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-0cd1zt7y1v></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApp\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

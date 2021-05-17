#pragma checksum "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e94f5274c63ce8d53abc8621497a72da0d553cd"
// <auto-generated/>
#pragma warning disable 1591
namespace SmallBankApplication.Client.Pages.Accounts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using SmallBankApplication.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using SmallBankApplication.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\_Imports.razor"
using Blazorise.Snackbar;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Accounts")]
    public partial class List : ListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Accounts List</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mt-4 mb-4");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
                      Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "btn btn-dark");
            __builder.AddContent(6, "Create New");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
 if (_Accounts == null || _Accounts.Count == 0)
{
    if (IsBusy)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p class=\"text-dark\">Loading...</p>");
#nullable restore
#line 14 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
        return;
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p class=\"text-warning\">No data to display</p>");
#nullable restore
#line 17 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
    return;
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-striped");
            __builder.AddMarkupContent(11, "<thead class=\"thead-dark\"><tr><td>Full Name</td>\r\n            <td>Account Number</td>\r\n            <td>Sort Code</td>\r\n            <td></td></tr></thead>\r\n    ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 29 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
         foreach (var item in _Accounts)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
                     item.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 33 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
                     item.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 34 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
                     item.SortCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
                                        ()=> EditAccount(item.AccountID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "btn btn-outline-dark");
            __builder.AddContent(27, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\List.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

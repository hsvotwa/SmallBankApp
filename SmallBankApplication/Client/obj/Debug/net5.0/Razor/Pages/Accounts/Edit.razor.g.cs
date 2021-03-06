#pragma checksum "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c968ecce6d1542a1b474468da2fc4d3f560ea5a7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAccount/{AccountID}")]
    public partial class Edit : EditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Edit Account - ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                    _Account.AccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " (");
            __builder.AddContent(4, 
#nullable restore
#line 4 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                             _Account.SortCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<Blazorise.Snackbar.Snackbar>(7);
            __builder.AddAttribute(8, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarColor>(
#nullable restore
#line 6 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                  _SnackbarColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarBody>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, 
#nullable restore
#line 8 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
         _SnackbarMessage

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(13, (__value) => {
#nullable restore
#line 6 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                _Snackbar = (Blazorise.Snackbar.Snackbar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                 _Account

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                            ()=>SaveActionAsync()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group col-6");
                __builder2.AddMarkupContent(27, "<label class=\"form-label d-block\">Account Holder Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-text form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    _Account.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _Account.FullName = __value, _Account.FullName))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _Account.FullName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateValidationMessage_0(__builder2, 34, 35, 
#nullable restore
#line 20 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    () => _Account.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group col-6");
                __builder2.AddMarkupContent(39, "<label class=\"form-label d-block\">Account Type</label>\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateInputSelect_1(__builder2, 40, 41, "AccountTypeID", 42, "form-control", 43, true, 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                                                                 SetAccountType

#line default
#line hidden
#nullable disable
                ), 45, 
#nullable restore
#line 24 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                              AccountTypeID

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountTypeID = __value, AccountTypeID)), 47, () => AccountTypeID, 48, (__builder3) => {
#nullable restore
#line 25 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                 foreach (var item in _AccountTypes)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(49, "option");
                    __builder3.AddAttribute(50, "value", 
#nullable restore
#line 27 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    item.AccountTypeID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(51, 
#nullable restore
#line 27 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                         item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 28 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 30 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    () => _Account.AccountTypeID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "row");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group col-6");
                __builder2.AddMarkupContent(60, "<label class=\"form-label d-block\">Account Type</label>\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateInputSelect_3(__builder2, 61, 62, "CurrencyID", 63, "form-control", 64, true, 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                                                           SetCurrency

#line default
#line hidden
#nullable disable
                ), 66, 
#nullable restore
#line 37 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                           CurrencyID

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrencyID = __value, CurrencyID)), 68, () => CurrencyID, 69, (__builder3) => {
#nullable restore
#line 38 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                 foreach (var item in _Currencies)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "value", 
#nullable restore
#line 40 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    item.CurrencyID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(72, 
#nullable restore
#line 40 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 41 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(73, "\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateValidationMessage_4(__builder2, 74, 75, 
#nullable restore
#line 43 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    () => _Account.CurrencyID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "row col-12");
                __builder2.OpenElement(79, "button");
                __builder2.AddAttribute(80, "type", "button");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                        ()=>SaveActionAsync()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "class", "btn btn-dark mr-1");
                __builder2.AddContent(83, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenElement(85, "button");
                __builder2.AddAttribute(86, "class", "btn btn-warning");
                __builder2.AddAttribute(87, "type", "button");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                CancelAsync

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(89, "Close");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "required", __arg2);
        __builder.AddAttribute(__seq3, "onchange", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "required", __arg2);
        __builder.AddAttribute(__seq3, "onchange", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

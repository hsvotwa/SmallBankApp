#pragma checksum "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aba2838467ae3e99690f0e904080476fea3d60f"
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
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                 _Account

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                            ()=>SaveActionAsync()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group col-6");
                __builder2.AddMarkupContent(19, "<label class=\"form-label d-block\">Account Holder Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "class", "form-text form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    _Account.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _Account.FullName = __value, _Account.FullName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _Account.FullName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 13 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    () => _Account.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group col-6");
                __builder2.AddMarkupContent(31, "<label class=\"form-label d-block\">Account Type</label>\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateInputSelect_1(__builder2, 32, 33, "AccountTypeID", 34, "form-control", 35, true, 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                                                                 SetAccountType

#line default
#line hidden
#nullable disable
                ), 37, 
#nullable restore
#line 17 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                              AccountTypeID

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountTypeID = __value, AccountTypeID)), 39, () => AccountTypeID, 40, (__builder3) => {
#nullable restore
#line 18 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                 foreach (var item in _AccountTypes)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(41, "option");
                    __builder3.AddAttribute(42, "value", 
#nullable restore
#line 20 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    item.AccountTypeID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(43, 
#nullable restore
#line 20 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                         item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 21 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(44, "\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateValidationMessage_2(__builder2, 45, 46, 
#nullable restore
#line 23 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    () => _Account.AccountTypeID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "row");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group col-6");
                __builder2.AddMarkupContent(52, "<label class=\"form-label d-block\">Account Type</label>\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateInputSelect_3(__builder2, 53, 54, "CurrencyID", 55, "form-control", 56, true, 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                                                           SetCurrency

#line default
#line hidden
#nullable disable
                ), 58, 
#nullable restore
#line 30 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                           CurrencyID

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrencyID = __value, CurrencyID)), 60, () => CurrencyID, 61, (__builder3) => {
#nullable restore
#line 31 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                 foreach (var item in _Currencies)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(62, "option");
                    __builder3.AddAttribute(63, "value", 
#nullable restore
#line 33 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    item.CurrencyID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(64, 
#nullable restore
#line 33 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 34 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(65, "\r\n            ");
                __Blazor.SmallBankApplication.Client.Pages.Accounts.Edit.TypeInference.CreateValidationMessage_4(__builder2, 66, 67, 
#nullable restore
#line 36 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                    () => _Account.CurrencyID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "row col-12");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                        ()=>SaveActionAsync()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "class", "btn btn-dark mr-1");
                __builder2.AddContent(75, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "class", "btn btn-warning");
                __builder2.AddAttribute(79, "type", "button");
                __builder2.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\lenna\source\repos\SmallBankApp\SmallBankApplication\Client\Pages\Accounts\Edit.razor"
                                                                CancelAsync

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(81, "Close");
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

#pragma checksum "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "536b0f302b3b3ad82bf3d4dc79b5757ab3de0164"
// <auto-generated/>
#pragma warning disable 1591
namespace GameShopBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using GameShopBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using GameShopBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "Identity/Account/Manage");
                __builder2.AddContent(4, "Hello, ");
                __builder2.AddContent(5, 
#nullable restore
#line 3 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Shared\LoginDisplay.razor"
                                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(6, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "form");
                __builder2.AddAttribute(9, "method", "post");
                __builder2.AddAttribute(10, "action", "Identity/Account/LogOut");
                __builder2.AddAttribute(11, "style", "margin-left: 10px;");
                __builder2.OpenComponent<BlazorStrap.BSButton>(12);
                __builder2.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 5 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Shared\LoginDisplay.razor"
                             Color.Danger

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "type", "submit");
                __builder2.AddAttribute(15, "class", "nav-link btn btn-link");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "Log out");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(18, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(19, "a");
                __builder2.AddAttribute(20, "href", "Identity/Account/Register");
                __builder2.OpenComponent<BlazorStrap.BSButton>(21);
                __builder2.AddAttribute(22, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 9 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Shared\LoginDisplay.razor"
                                                             Color.Success

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "Registrarse");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n         ");
                __builder2.OpenElement(26, "a");
                __builder2.AddAttribute(27, "href", "Identity/Account/Login");
                __builder2.OpenComponent<BlazorStrap.BSButton>(28);
                __builder2.AddAttribute(29, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 10 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Shared\LoginDisplay.razor"
                                                           Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(31, "Login");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
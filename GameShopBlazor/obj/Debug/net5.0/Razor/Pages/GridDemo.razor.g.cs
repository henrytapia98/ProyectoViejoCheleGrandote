#pragma checksum "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2406656982d95084765907e454d827ace89b48bc"
// <auto-generated/>
#pragma warning disable 1591
namespace GameShopBlazor.Pages
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
#line 2 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
using GameShopBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/masterDetailsGrid")]
    public partial class GridDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Maestro Detalle</h3>");
#nullable restore
#line 7 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
 if (orders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading...</p>");
#nullable restore
#line 10 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
}
else 
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Order>>(2);
            __builder.AddAttribute(3, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                       orders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                                                                          FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                                                                                                                                              4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Order>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Order>(this, 
#nullable restore
#line 14 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                             args => order=args

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Order>>(10);
                __builder2.AddAttribute(11, "Property", "OrderID");
                __builder2.AddAttribute(12, "Title", "Order ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Order>>(14);
                __builder2.AddAttribute(15, "Property", "CustomerName");
                __builder2.AddAttribute(16, "Title", "Customer Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Order>>(18);
                __builder2.AddAttribute(19, "Property", "OrderDate");
                __builder2.AddAttribute(20, "Title", "Order Date");
                __builder2.AddAttribute(21, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((data) => (__builder3) => {
                    __builder3.AddContent(22, 
#nullable restore
#line 20 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                     string.Format("{0:d}", data.OrderDate)

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.OpenComponent<Radzen.Blazor.RadzenTabs>(23);
            __builder.AddAttribute(24, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(25);
                __builder2.AddAttribute(26, "Text", "Order Details");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGrid<OrderDetails>>(28);
                    __builder3.AddAttribute(29, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderDetails>>(
#nullable restore
#line 29 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
                                                                                                order.OrderDetails

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderDetails>>(34);
                        __builder4.AddAttribute(35, "Property", "ProductID");
                        __builder4.AddAttribute(36, "Title", "Product ID");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderDetails>>(38);
                        __builder4.AddAttribute(39, "Property", "ProductName");
                        __builder4.AddAttribute(40, "Title", "Product ID");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderDetails>>(42);
                        __builder4.AddAttribute(43, "Property", "ProdQty");
                        __builder4.AddAttribute(44, "Title", "Quantity");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderDetails>>(46);
                        __builder4.AddAttribute(47, "Property", "Price");
                        __builder4.AddAttribute(48, "Title", "Price");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 40 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GridDemo.razor"
       

    Order order = new Order();
    IEnumerable<Order> orders;

    protected override async Task OnInitializedAsync()
    {
        orders = await Task.Run(() => orderService.OrderList());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService orderService { get; set; }
    }
}
#pragma warning restore 1591

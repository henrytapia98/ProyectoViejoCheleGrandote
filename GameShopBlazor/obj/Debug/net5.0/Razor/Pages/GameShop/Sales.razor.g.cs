#pragma checksum "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94db4f87d538ac3d8f42c7c406f2ae8a292c449c"
// <auto-generated/>
#pragma warning disable 1591
namespace GameShopBlazor.Pages.GameShop
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
#nullable restore
#line 2 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
using GSDataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
using GSDataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
using GameShopBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Sales")]
    public partial class Sales : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Sales</h1>\r\n\r\n");
            __builder.OpenComponent<BlazorStrap.BSForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                newSales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                          InsertSales

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "style", "width: 700px;");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(6);
                __builder2.AddAttribute(7, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(9);
                    __builder3.AddAttribute(10, "For", "exampleEmail");
                    __builder3.AddAttribute(11, "Class", "mr-sm-2");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(13, "First Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_0(__builder3, 15, 16, 
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Text

#line default
#line hidden
#nullable disable
                    , 17, "first_nanme", 18, "first_name", 19, "First Name", 20, 
#nullable restore
#line 14 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                            newSales.First_Name

#line default
#line hidden
#nullable disable
                    , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.First_Name = __value, newSales.First_Name)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(23);
                __builder2.AddAttribute(24, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(26);
                    __builder3.AddAttribute(27, "For", "exampleEmail");
                    __builder3.AddAttribute(28, "Class", "mr-sm-2");
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(30, "Product Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_1(__builder3, 32, 33, 
#nullable restore
#line 18 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Text

#line default
#line hidden
#nullable disable
                    , 34, "last_name", 35, "last_name", 36, "Last Name", 37, 
#nullable restore
#line 19 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                           newSales.Last_Name

#line default
#line hidden
#nullable disable
                    , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.Last_Name = __value, newSales.Last_Name)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(40);
                __builder2.AddAttribute(41, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(43);
                    __builder3.AddAttribute(44, "For", "exampleEmail");
                    __builder3.AddAttribute(45, "Class", "mr-sm-2");
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(47, "Product Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_2(__builder3, 49, 50, 
#nullable restore
#line 23 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Text

#line default
#line hidden
#nullable disable
                    , 51, "product_name", 52, "product_name", 53, "Product Name", 54, 
#nullable restore
#line 24 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                              newSales.Product_Name

#line default
#line hidden
#nullable disable
                    , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.Product_Name = __value, newSales.Product_Name)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(57);
                __builder2.AddAttribute(58, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(60);
                    __builder3.AddAttribute(61, "For", "exampleEmail");
                    __builder3.AddAttribute(62, "Class", "mr-sm-2");
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(64, "Price");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_3(__builder3, 66, 67, 
#nullable restore
#line 28 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Number

#line default
#line hidden
#nullable disable
                    , 68, "price", 69, "price", 70, "Price", 71, 
#nullable restore
#line 29 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                       newSales.Price

#line default
#line hidden
#nullable disable
                    , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.Price = __value, newSales.Price)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(74);
                __builder2.AddAttribute(75, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(77);
                    __builder3.AddAttribute(78, "For", "exampleEmail");
                    __builder3.AddAttribute(79, "Class", "mr-sm-2");
                    __builder3.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(81, "Quantity");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_4(__builder3, 83, 84, 
#nullable restore
#line 33 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Number

#line default
#line hidden
#nullable disable
                    , 85, "quantity", 86, "quantity", 87, "Quantity", 88, 
#nullable restore
#line 34 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                          newSales.Quantity

#line default
#line hidden
#nullable disable
                    , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.Quantity = __value, newSales.Quantity)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(91);
                __builder2.AddAttribute(92, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(94);
                    __builder3.AddAttribute(95, "For", "exampleEmail");
                    __builder3.AddAttribute(96, "Class", "mr-sm-2");
                    __builder3.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(98, "Product Category");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_5(__builder3, 100, 101, 
#nullable restore
#line 38 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Select

#line default
#line hidden
#nullable disable
                    , 102, "product_category", 103, "product_category", 104, "Product Category", 105, 
#nullable restore
#line 39 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                                  newSales.Product_Category

#line default
#line hidden
#nullable disable
                    , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.Product_Category = __value, newSales.Product_Category)), 107, (__builder4) => {
                        __builder4.AddMarkupContent(108, "<option>Consola</option>\r\n            ");
                        __builder4.AddMarkupContent(109, "<option>Juego</option>\r\n            ");
                        __builder4.AddMarkupContent(110, "<option>Accesorio</option>");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(112);
                __builder2.AddAttribute(113, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(115);
                    __builder3.AddAttribute(116, "For", "exampleEmail");
                    __builder3.AddAttribute(117, "Class", "mr-sm-2");
                    __builder3.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(119, "Brand Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_6(__builder3, 121, 122, 
#nullable restore
#line 47 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Text

#line default
#line hidden
#nullable disable
                    , 123, "brand_name", 124, "brand_name", 125, "Brand_Name", 126, 
#nullable restore
#line 48 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                            newSales.Brand_Name

#line default
#line hidden
#nullable disable
                    , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.Brand_Name = __value, newSales.Brand_Name)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(129);
                __builder2.AddAttribute(130, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(132);
                    __builder3.AddAttribute(133, "For", "exampleEmail");
                    __builder3.AddAttribute(134, "Class", "mr-sm-2");
                    __builder3.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(136, "Game Category");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.Sales.TypeInference.CreateBSBasicInput_7(__builder3, 138, 139, 
#nullable restore
#line 52 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                 InputType.Select

#line default
#line hidden
#nullable disable
                    , 140, "game_category", 141, "game_category", 142, "Game Category", 143, 
#nullable restore
#line 53 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                               newSales.Game_Category

#line default
#line hidden
#nullable disable
                    , 144, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newSales.Game_Category = __value, newSales.Game_Category)), 145, (__builder4) => {
                        __builder4.AddMarkupContent(146, "<option>Terror</option>\r\n            ");
                        __builder4.AddMarkupContent(147, "<option>Fantasia</option>\r\n            ");
                        __builder4.AddMarkupContent(148, "<option>Lucha</option>\r\n            ");
                        __builder4.AddMarkupContent(149, "<option>Disparos</option>\r\n            ");
                        __builder4.AddMarkupContent(150, "<option>Estrategia</option>\r\n            ");
                        __builder4.AddMarkupContent(151, "<option>Simulacion</option>\r\n            ");
                        __builder4.AddMarkupContent(152, "<option>Deporte</option>\r\n            ");
                        __builder4.AddMarkupContent(153, "<option>Aventura</option>\r\n            ");
                        __builder4.AddMarkupContent(154, "<option>Rol</option>\r\n            ");
                        __builder4.AddMarkupContent(155, "<option>Educacion</option>");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(156, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(157, "<button type=\"submit\">Guardar</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(158, "\r\n\r\n<br>\r\n\r\n\r\n");
            __builder.AddMarkupContent(159, "<h4>Sales</h4>");
#nullable restore
#line 74 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
 if (sales is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(160, "<p><em>Loading...</em></p>");
#nullable restore
#line 77 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
}
else

{


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<SalesModel>>(161);
            __builder.AddAttribute(162, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 82 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(163, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 82 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(164, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 82 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                                                FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 82 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                                                                                                 10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(166, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 82 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                                                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(167, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SalesModel>>(
#nullable restore
#line 83 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
                      sales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(168, "ColumnWidth", "150px");
            __builder.AddAttribute(169, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(170);
                __builder2.AddAttribute(171, "Property", "First_Name");
                __builder2.AddAttribute(172, "Title", "First Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(173, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(174);
                __builder2.AddAttribute(175, "Property", "Last_Name");
                __builder2.AddAttribute(176, "Title", "Last Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(177, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(178);
                __builder2.AddAttribute(179, "Property", "Product_Name");
                __builder2.AddAttribute(180, "Title", "Product Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(181, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(182);
                __builder2.AddAttribute(183, "Property", "Price");
                __builder2.AddAttribute(184, "Title", "Price");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(185, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(186);
                __builder2.AddAttribute(187, "Property", "Quantity");
                __builder2.AddAttribute(188, "Title", "Quantity");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(189, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(190);
                __builder2.AddAttribute(191, "Property", "Product_Category");
                __builder2.AddAttribute(192, "Title", "Product Category");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(193, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(194);
                __builder2.AddAttribute(195, "Property", "Brand_Name");
                __builder2.AddAttribute(196, "Title", "Brand Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(197, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<SalesModel>>(198);
                __builder2.AddAttribute(199, "Property", "Game_Category");
                __builder2.AddAttribute(200, "Title", "Game Category");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 95 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\Sales.razor"
       
    private List<SalesModel> sales;
    private DisplaySalesModel newSales = new DisplaySalesModel();


    protected override async Task OnInitializedAsync()
    {
        sales = await _db.GetSales();
    }

    private async Task InsertSales()
    {
        SalesModel p = new SalesModel
        {
            First_Name = newSales.First_Name,
            Last_Name = newSales.Last_Name,
            Product_Name = newSales.Product_Name,
            Price = newSales.Price,
            Quantity = newSales.Quantity,
            Product_Category = newSales.Product_Category,
            Brand_Name = newSales.Brand_Name,
            Game_Category = newSales.Game_Category
        };

        await _db.InsertSales(p);

        sales.Add(p);

        newSales = new DisplaySalesModel();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesData _db { get; set; }
    }
}
namespace __Blazor.GameShopBlazor.Pages.GameShop.Sales
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBSBasicInput_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

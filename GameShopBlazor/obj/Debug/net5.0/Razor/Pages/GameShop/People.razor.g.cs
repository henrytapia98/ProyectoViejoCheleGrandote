#pragma checksum "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10041f331c79bee210083e08f7fcc4ea1a09082a"
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
#line 2 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
using GSDataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
using GSDataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
using GameShopBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/People")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Productos</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Insertar un nuevo Producto</h4>\r\n");
            __builder.OpenComponent<BlazorStrap.BSForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                newPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                           InsertPerson

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(6);
                __builder2.AddAttribute(7, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(9);
                    __builder3.AddAttribute(10, "For", "exampleEmail");
                    __builder3.AddAttribute(11, "Class", "mr-sm-2");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(13, "Product Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.People.TypeInference.CreateBSBasicInput_0(__builder3, 15, 16, 
#nullable restore
#line 15 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                 InputType.Text

#line default
#line hidden
#nullable disable
                    , 17, "product_name", 18, "product_name", 19, "Product Name", 20, 
#nullable restore
#line 15 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                                                               newPerson.Product_Name

#line default
#line hidden
#nullable disable
                    , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Product_Name = __value, newPerson.Product_Name)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(23);
                __builder2.AddAttribute(24, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(26);
                    __builder3.AddAttribute(27, "For", "examplePassword");
                    __builder3.AddAttribute(28, "class", "mr-sm-2");
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(30, "Price");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.People.TypeInference.CreateBSBasicInput_1(__builder3, 32, 33, 
#nullable restore
#line 19 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                 InputType.Number

#line default
#line hidden
#nullable disable
                    , 34, "price", 35, "price", 36, 
#nullable restore
#line 19 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                        newPerson.Price

#line default
#line hidden
#nullable disable
                    , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Price = __value, newPerson.Price)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(41);
                    __builder3.AddAttribute(42, "For", "exampleFormControlSelect1");
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, "Game Category");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.People.TypeInference.CreateBSBasicInput_2(__builder3, 46, 47, "game_category", 48, 
#nullable restore
#line 23 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                    InputType.Select

#line default
#line hidden
#nullable disable
                    , 49, 
#nullable restore
#line 23 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                   newPerson.Game_Category

#line default
#line hidden
#nullable disable
                    , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Game_Category = __value, newPerson.Game_Category)), 51, (__builder4) => {
                        __builder4.AddMarkupContent(52, "<option>Terror</option>\r\n            ");
                        __builder4.AddMarkupContent(53, "<option>Fantasia</option>\r\n            ");
                        __builder4.AddMarkupContent(54, "<option>Lucha</option>\r\n            ");
                        __builder4.AddMarkupContent(55, "<option>Disparos</option>\r\n            ");
                        __builder4.AddMarkupContent(56, "<option>Estrategia</option>\r\n            ");
                        __builder4.AddMarkupContent(57, "<option>Simulacion</option>\r\n            ");
                        __builder4.AddMarkupContent(58, "<option>Deporte</option>\r\n            ");
                        __builder4.AddMarkupContent(59, "<option>Aventura</option>\r\n            ");
                        __builder4.AddMarkupContent(60, "<option>Rol</option>\r\n            ");
                        __builder4.AddMarkupContent(61, "<option>Educacion</option>");
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSFormGroup>(63);
                __builder2.AddAttribute(64, "Class", "mb-2 mr-sm-2 mb-sm-0");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSLabel>(66);
                    __builder3.AddAttribute(67, "For", "examplePassword");
                    __builder3.AddAttribute(68, "class", "mr-sm-2");
                    __builder3.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(70, "Brand Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n        ");
                    __Blazor.GameShopBlazor.Pages.GameShop.People.TypeInference.CreateBSBasicInput_3(__builder3, 72, 73, 
#nullable restore
#line 38 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                 InputType.Text

#line default
#line hidden
#nullable disable
                    , 74, "brand_name", 75, "brand_name", 76, "Brand Name", 77, 
#nullable restore
#line 38 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                                                         newPerson.Brand_Name

#line default
#line hidden
#nullable disable
                    , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Brand_Name = __value, newPerson.Brand_Name)));
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSDropdown>(80);
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSFormGroup>(82);
                    __builder3.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<BlazorStrap.BSLabel>(84);
                        __builder4.AddAttribute(85, "For", "exampleFormControlSelect1");
                        __builder4.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(87, "Product Category");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(88, "\r\n            ");
                        __Blazor.GameShopBlazor.Pages.GameShop.People.TypeInference.CreateBSBasicInput_4(__builder4, 89, 90, "product_category", 91, 
#nullable restore
#line 43 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                           InputType.Select

#line default
#line hidden
#nullable disable
                        , 92, 
#nullable restore
#line 43 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                          newPerson.Product_Category

#line default
#line hidden
#nullable disable
                        , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPerson.Product_Category = __value, newPerson.Product_Category)), 94, (__builder5) => {
                            __builder5.AddMarkupContent(95, "<option>Consola</option>\r\n                ");
                            __builder5.AddMarkupContent(96, "<option>Juego</option>\r\n                ");
                            __builder5.AddMarkupContent(97, "<option>Accesorio</option>");
                        }
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n    ");
                __builder2.AddMarkupContent(99, "<button type=\"submit\">Guardar</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n<br>\r\n\r\n\r\n");
            __builder.AddMarkupContent(101, "<h4>Productos</h4>");
#nullable restore
#line 56 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
 if (people is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "<p><em>Loading...</em></p>");
#nullable restore
#line 59 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
}
else

{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<PersonModel>>(103);
            __builder.AddAttribute(104, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 63 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 63 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                                                                 10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                                                                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<PersonModel>>(
#nullable restore
#line 64 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
                       people

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "ColumnWidth", "150px");
            __builder.AddAttribute(111, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<PersonModel>>(112);
                __builder2.AddAttribute(113, "Property", "Product_Name");
                __builder2.AddAttribute(114, "Title", "Product Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<PersonModel>>(116);
                __builder2.AddAttribute(117, "Property", "Price");
                __builder2.AddAttribute(118, "Title", "Price");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<PersonModel>>(120);
                __builder2.AddAttribute(121, "Property", "Game_Category");
                __builder2.AddAttribute(122, "Title", "Game Category");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<PersonModel>>(124);
                __builder2.AddAttribute(125, "Property", "Brand_Name");
                __builder2.AddAttribute(126, "Title", "Brand Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(127, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<PersonModel>>(128);
                __builder2.AddAttribute(129, "Property", "Product_Category");
                __builder2.AddAttribute(130, "Title", "Product Category");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 74 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\GameShop\People.razor"
       
    private List<PersonModel> people;
    private DisplayPersonModel newPerson = new DisplayPersonModel(); 

    protected override async Task OnInitializedAsync()
    {
        people = await _db.GetPeople();
    }

    private async Task InsertPerson()
    {
        PersonModel p = new PersonModel
        {
            Product_Name = newPerson.Product_Name,
            Price = newPerson.Price,
            Game_Category = newPerson.Game_Category,
            Brand_Name = newPerson.Brand_Name,
            Product_Category = newPerson.Product_Category
        };

        await _db.InsertPerson(p);

        people.Add(p);

        newPerson = new DisplayPersonModel();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPeopleData _db { get; set; }
    }
}
namespace __Blazor.GameShopBlazor.Pages.GameShop.People
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBSBasicInput_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Id", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "PlaceHolder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Id", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

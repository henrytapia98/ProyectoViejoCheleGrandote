#pragma checksum "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18ab0247ef6984b4b5980e157e18e63808287730"
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
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align:center\">GameShop</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h2 style=\"text-align:center\">Los mejores productos Gamer</h2>\r\n\r\n");
            __builder.OpenComponent<BlazorStrap.BSCarousel>(2);
            __builder.AddAttribute(3, "NumberOfItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                            items.Count

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSCarouselIndicators>(5);
                __builder2.AddAttribute(6, "ActiveIndexChangedEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 8 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                                    indexChanged

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "carousel-inner");
#nullable restore
#line 10 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
         for (int i = 0; i < items.Count; i++)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BlazorStrap.BSCarouselItem>(10);
                __builder2.AddAttribute(11, "src", 
#nullable restore
#line 12 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                  items[i].Source

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(12, "alt", 
#nullable restore
#line 12 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                                         items[i].Alt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(13, "style", "height:500px");
                __builder2.CloseComponent();
#nullable restore
#line 13 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSCarouselControl>(15);
                __builder2.AddAttribute(16, "CarouselDirection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CarouselDirection>(
#nullable restore
#line 15 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                          CarouselDirection.Previous

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSCarouselControl>(18);
                __builder2.AddAttribute(19, "CarouselDirection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CarouselDirection>(
#nullable restore
#line 16 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                          CarouselDirection.Next

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n<br>\r\n");
            __builder.OpenComponent<BlazorStrap.BSCard>(21);
            __builder.AddAttribute(22, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 19 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                  CardType.Deck

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSCard>(24);
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSCard>(26);
                    __builder3.AddAttribute(27, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 21 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                          CardType.Image

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "VerticalAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.VerticalAlignment>(
#nullable restore
#line 21 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                                             VerticalAlignment.Top

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "src", "../css/images/imagep1.jpg");
                    __builder3.AddAttribute(30, "alt", "256x180");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(32);
                    __builder3.AddAttribute(33, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 22 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                          CardType.Body

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<BlazorStrap.BSCard>(35);
                        __builder4.AddAttribute(36, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 23 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Title

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(38, "Sobre Nosotros");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(40);
                        __builder4.AddAttribute(41, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 24 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Subtitle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(43, "Conocenos un poco!");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(44, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(45);
                        __builder4.AddAttribute(46, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 25 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(48, @"Somos una tienda Gamer especializada con más de 8 años de trayectoria en el mercado, destacada por ofrecer a nuestros Gamers la más completa asesoría. En nuestra tienda podrás encontrar una amplia oferta de productos, entre consolas, juegos, accesorios y tecnología en general, con los más altos estándares de calidad y un excelente servicio al cliente. ¡Nos encanta darte gusto!");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(50);
                        __builder4.AddAttribute(51, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 26 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(53, "<small class=\"text-muted\">Last updated 3 mins ago</small>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSCard>(55);
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSCard>(57);
                    __builder3.AddAttribute(58, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 30 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                          CardType.Image

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "VerticalAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.VerticalAlignment>(
#nullable restore
#line 30 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                                             VerticalAlignment.Top

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "src", "../css/images/imagep2.jpg");
                    __builder3.AddAttribute(61, "alt", "256x180");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n        ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(63);
                    __builder3.AddAttribute(64, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 31 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                          CardType.Body

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<BlazorStrap.BSCard>(66);
                        __builder4.AddAttribute(67, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 32 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Title

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(69, "Mision");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(70, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(71);
                        __builder4.AddAttribute(72, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 33 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Subtitle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(74, "Siempre de tu lado!");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(75, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(76);
                        __builder4.AddAttribute(77, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 34 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(79, "Nuestra misión es ofrecer una amplia variedad de productos especializados para satisfacer todas las necesidades y deseos de nuestros Gamers, brindando la mejor experiencia de compra, con excelente servicio y cultura.");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(81);
                        __builder4.AddAttribute(82, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 35 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(84, "<small class=\"text-muted\">Last updated 3 mins ago</small>");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSCard>(86);
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSCard>(88);
                    __builder3.AddAttribute(89, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 39 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                          CardType.Image

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "VerticalAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.VerticalAlignment>(
#nullable restore
#line 39 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                                             VerticalAlignment.Top

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "src", "../css/images/imagep3.jpg");
                    __builder3.AddAttribute(92, "alt", "256x180");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n        ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(94);
                    __builder3.AddAttribute(95, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 40 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                          CardType.Body

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<BlazorStrap.BSCard>(97);
                        __builder4.AddAttribute(98, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 41 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Title

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(100, "Vision");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(101, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(102);
                        __builder4.AddAttribute(103, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 42 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Subtitle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(105, "Siempre avanzando!");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(106, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(107);
                        __builder4.AddAttribute(108, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 43 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(110, "Ser la tienda líder en la ciudad para el año 2020 y posicionarnos en el mercado nacional para el año 2024, apoyados en un proceso de mejora continua y en una excelente cultura de servicio al cliente, con ética, responsabilidad, honestidad e integridad.");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(111, "\r\n            ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(112);
                        __builder4.AddAttribute(113, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 44 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                              CardType.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(115, "<small class=\"text-muted\">Last updated 3 mins ago</small>");
                        }
                        ));
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
            __builder.AddMarkupContent(116, "\r\n<br>\r\n");
            __builder.OpenComponent<BlazorStrap.BSRow>(117);
            __builder.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSTabGroup>(119);
                __builder2.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSCol>(121);
                    __builder3.AddAttribute(122, "SM", "3");
                    __builder3.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<BlazorStrap.BSTabList>(124);
                        __builder4.AddAttribute(125, "IsPills", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(126, "IsList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                              true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(127, "IsVertical", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<BlazorStrap.BSTab>(129);
                            __builder5.AddAttribute(130, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<BlazorStrap.BSTabLabel>(131);
                                __builder6.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(133, "Como LLegar?<i class=\"fas fa-map-marker-alt\" style=\"margin-left: 6px;\"></i>");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(134, "\r\n                    ");
                                __builder6.OpenComponent<BlazorStrap.BSTabContent>(135);
                                __builder6.AddAttribute(136, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(137, @"
                        1 Calle Sur-Este, Masaya <br>
                        Horas:<br>
                        lunes	9:00–17:00<br>
                        martes	9:00–17:00<br>
                        miércoles	9:00–17:00<br>
                        jueves	9:00–17:00<br>
                        viernes	9:00–17:00<br>
                        sábado	10:00–14:30<br>
                        domingo	Cerrado
                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(138, "\r\n                ");
                            __builder5.OpenComponent<BlazorStrap.BSTab>(139);
                            __builder5.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<BlazorStrap.BSTabLabel>(141);
                                __builder6.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(143, "Contact <i class=\"fas fa-id-card\" style=\"margin-left: 6px;\"></i>");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(144, "\r\n                    ");
                                __builder6.OpenComponent<BlazorStrap.BSTabContent>(145);
                                __builder6.AddAttribute(146, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(147, "Telefono: 7677 1947 <br>Correo Electronico: gameshoptienda@gmail.com<br>Fax: 24262578");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(148, "\r\n                ");
                            __builder5.OpenComponent<BlazorStrap.BSTab>(149);
                            __builder5.AddAttribute(150, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<BlazorStrap.BSTabLabel>(151);
                                __builder6.AddAttribute(152, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(153, "Copyright <i class=\"fas fa-copyright\" style=\"margin-left: 6px;\"></i>");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(154, "\r\n                    ");
                                __builder6.OpenComponent<BlazorStrap.BSTabContent>(155);
                                __builder6.AddAttribute(156, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(157, "Copyright © 2021 GS GAMESHOP® By Tapia Agencia");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(158, "\r\n        ");
                    __builder3.OpenComponent<BlazorStrap.BSCol>(159);
                    __builder3.AddAttribute(160, "SM", "9");
                    __builder3.AddAttribute(161, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<BlazorStrap.BSTabSelectedContent>(162);
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
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\HACHE\source\repos\GameShopBlazor\GameShopBlazor\Pages\Index.razor"
       

    IList<Item> items = new List<Item>
{
        new Item {
            Source = "../css/images/image1.jpg",
            Alt ="First Slide",
            Caption = "Slide 1",
            Header = "Slide 1 Header"
        },
        new Item {
            Source = "../css/images/image2.jpg",
            Alt ="Second Slide",
            Caption = "Slide 2",
            Header = "Slide 2 Header"
        },
        new Item {
            Source = "../css/images/image3.jpg",
            Alt ="Third Slide",
            Caption = "Slide 3",
            Header = "Slide 3 Header"
        },
        new Item {
            Source = "../css/images/image4.jpg",
            Alt ="Fourth Slide",
            Caption = "Slide 4",
            Header = "Slide 4 Header"
        }
    };

    class Item
    {
        public string Source { get; set; }
        public string Alt { get; set; }
        public string Caption { get; set; }
        public string Header { get; set; }
    }

    private void indexChanged(int index)
    {
        Console.WriteLine("Index Changed: " + index);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591

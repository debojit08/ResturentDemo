// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Resturent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\internship\Resturent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\internship\Resturent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\internship\Resturent\_Imports.razor"
using Resturent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\internship\Resturent\_Imports.razor"
using Resturent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\internship\Resturent\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\internship\Resturent\Pages\AddVariation.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addVariation")]
    public partial class AddVariation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\internship\Resturent\Pages\AddVariation.razor"
       

    Variation objVariation = new Variation();

    private bool hover = true;
    private DateTime eDate;
    public bool isActive, isAdmin, status;


    protected override void OnInitialized()
    {
        eDate = DateTime.Now;
    }

    void CreateVariation()
    {
        objVariation.VariationId = 0;
        objVariation.EDate = eDate;
        objVariation.MDate = null;
        objVariation.IsActive = isActive ? true : false;
       // objVariation.IsAdmin = isAdmin ? true : false;
        objVariation.Status = status ? true : false;
        objVariationService.Create(objVariation);
        NavigationManager.NavigateTo("variation");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("variation");
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VariationService objVariationService { get; set; }
    }
}
#pragma warning restore 1591

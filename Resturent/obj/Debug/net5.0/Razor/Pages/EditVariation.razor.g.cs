#pragma checksum "D:\internship\Resturent\Pages\EditVariation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51fa034627d08dbbbbae72a04a90e9c7ef5775a"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\internship\Resturent\Pages\EditVariation.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editVariation/{CurrentId}")]
    public partial class EditVariation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddUser</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-md-6");
            __Blazor.Resturent.Pages.EditVariation.TypeInference.CreateMudTextField_0(__builder, 6, 7, "Variation Name", 8, 
#nullable restore
#line 9 "D:\internship\Resturent\Pages\EditVariation.razor"
                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 9 "D:\internship\Resturent\Pages\EditVariation.razor"
                                                                                                                             Margin.Dense

#line default
#line hidden
#nullable disable
            , 10, "form-control", 11, 
#nullable restore
#line 9 "D:\internship\Resturent\Pages\EditVariation.razor"
                                       objVariation.VariationName

#line default
#line hidden
#nullable disable
            , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objVariation.VariationName = __value, objVariation.VariationName)));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-row");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group col-md-3");
            __builder.AddMarkupContent(18, "<label for=\"inputPassword4\">Is Active</label>\r\n            ");
            __builder.OpenElement(19, "label");
            __builder.AddAttribute(20, "class", "switch");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "checkbox");
            __builder.AddAttribute(23, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\internship\Resturent\Pages\EditVariation.razor"
                                              objVariation.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objVariation.IsActive = __value, objVariation.IsActive));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                <span class=\"slider round\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group col-md-3");
            __builder.AddMarkupContent(29, "<label for=\"inputPassword4\">Status</label>\r\n            ");
            __builder.OpenElement(30, "label");
            __builder.AddAttribute(31, "class", "switch");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "checkbox");
            __builder.AddAttribute(34, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\internship\Resturent\Pages\EditVariation.razor"
                                              objVariation.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objVariation.Status = __value, objVariation.Status));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                <span class=\"slider round\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-md-4");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\internship\Resturent\Pages\EditVariation.razor"
                                                                        UpdateVariation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\internship\Resturent\Pages\EditVariation.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\internship\Resturent\Pages\EditVariation.razor"
       
    [Parameter]
    public string CurrentId { get; set; }

    Variation objVariation = new Variation();

    private DateTime mDate;
    protected override void OnInitialized()
    {
        mDate = DateTime.Now;
    }

    protected override async Task OnInitializedAsync()
    {
        objVariation = await Task.Run(() => objaVariationService.GetVariationById(Convert.ToInt32(CurrentId)));
    }

    void UpdateVariation()
    {
        objVariation.MDate = mDate;
        objaVariationService.Update(objVariation);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VariationService objaVariationService { get; set; }
    }
}
namespace __Blazor.Resturent.Pages.EditVariation
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

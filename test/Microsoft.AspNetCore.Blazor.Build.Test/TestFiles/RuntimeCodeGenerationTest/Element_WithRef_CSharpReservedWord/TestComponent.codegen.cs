// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "elem");
            builder.AddElementReferenceCapture(1, (__value) => {
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
             @class = __value;

#line default
#line hidden
            }
            );
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    private Microsoft.AspNetCore.Blazor.ElementRef @class;

#line default
#line hidden
    }
}
#pragma warning restore 1591

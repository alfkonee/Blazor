// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenComponent<Test.MyComponent<string>>(0);
            builder.AddAttribute(1, "Item", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<string>(Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(Value)));
            builder.AddAttribute(2, "ItemChanged", new System.Action<string>(__value => Value = __value));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    string Value;

#line default
#line hidden
    }
}
#pragma warning restore 1591

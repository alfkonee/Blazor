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
            __Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(builder, 0, 1, "hi");
            builder.AddContent(2, "\n");
            __Blazor.Test.TestComponent.TypeInference.CreateMyComponent_1(builder, 3, 4, "how are you?");
            builder.AddContent(5, "\n");
            __Blazor.Test.TestComponent.TypeInference.CreateMyComponent_2(builder, 6, 7, "bye!");
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMyComponent_0<TItem>(global::Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, TItem __arg0)
        {
        builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        builder.AddAttribute(__seq0, "Item", __arg0);
        builder.CloseComponent();
        }
        public static void CreateMyComponent_1<TItem>(global::Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, TItem __arg0)
        {
        builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        builder.AddAttribute(__seq0, "Item", __arg0);
        builder.CloseComponent();
        }
        public static void CreateMyComponent_2<TItem>(global::Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder, int seq, int __seq0, TItem __arg0)
        {
        builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        builder.AddAttribute(__seq0, "Item", __arg0);
        builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

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
            builder.OpenComponent<Test.MyComponent>(0);
            builder.AddAttribute(1, "PersonTemplate", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Blazor.RenderFragment<Test.Person>>((builder2, item) => {
                builder2.OpenElement(2, "div");
                builder2.AddContent(3, item.Name);
                builder2.CloseElement();
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Product\_LeyautMarka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c2e1219114bae72511bb98f546585d8588f50f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__LeyautMarka), @"mvc.1.0.view", @"/Views/Product/_LeyautMarka.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/_LeyautMarka.cshtml", typeof(AspNetCore.Views_Product__LeyautMarka))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\_ViewImports.cshtml"
using RemindWebApp;

#line default
#line hidden
#line 2 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\_ViewImports.cshtml"
using RemindWebApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\_ViewImports.cshtml"
using RemindWebApp.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\_ViewImports.cshtml"
using RemindWebApp.Utlities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c2e1219114bae72511bb98f546585d8588f50f", @"/Views/Product/_LeyautMarka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4db406c6c6455681074dcc1cc431934610e233", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__LeyautMarka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MarkaViewModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Product\_LeyautMarka.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(64, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(68, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f49a197a7a14fa0b13bb458b2f9e32a", async() => {
                BeginContext(94, 9, false);
#line 5 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Product\_LeyautMarka.cshtml"
                        Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 5 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Product\_LeyautMarka.cshtml"
       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Product\_LeyautMarka.cshtml"
}

#line default
#line hidden
            BeginContext(117, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MarkaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

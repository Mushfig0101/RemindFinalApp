#pragma checksum "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5f2f361f73bdb15e6d1ffab72465268b8936e4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialBlog), @"mvc.1.0.view", @"/Views/Shared/_PartialBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialBlog.cshtml", typeof(AspNetCore.Views_Shared__PartialBlog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f2f361f73bdb15e6d1ffab72465268b8936e4f", @"/Views/Shared/_PartialBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4db406c6c6455681074dcc1cc431934610e233", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml"
 foreach (var blog in Model.BlogsCenter)
{

#line default
#line hidden
            BeginContext(71, 95, true);
            WriteLiteral("    <div class=\"col-md-4\">\r\n        <div class=\"post post-sm\">\r\n            <a class=\"post-img\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 166, "\"", 183, 1);
#line 8 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml"
WriteAttributeValue("", 173, blog.Link, 173, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(184, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 189, "\"", 214, 2);
            WriteAttributeValue("", 195, "Img/", 195, 4, true);
#line 8 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml"
WriteAttributeValue("", 199, blog.ImagePath, 199, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(215, 101, true);
            WriteLiteral(" alt=\"\"></a>\r\n            <div class=\"post-body\">\r\n                <h3 class=\"post-title title-sm\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 316, "\"", 333, 1);
#line 10 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml"
WriteAttributeValue("", 323, blog.Link, 323, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(334, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(336, 10, false);
#line 10 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml"
                                                                Write(blog.Title);

#line default
#line hidden
            EndContext();
            BeginContext(346, 76, true);
            WriteLiteral(".</a></h3>\r\n                <ul class=\"post-meta\">\r\n                    <li>");
            EndContext();
            BeginContext(423, 16, false);
#line 12 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml"
                   Write(blog.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(439, 78, true);
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\Users\Code\source\repos\RemindWebApp\RemindWebApp\RemindWebApp\Views\Shared\_PartialBlog.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
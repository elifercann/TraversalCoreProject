#pragma checksum "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06d4b914c31bf6959374ca351c4d5cfd97b6ffe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06d4b914c31bf6959374ca351c4d5cfd97b6ffe4", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5e4f4ee20e66c99cd8182431574b73439134f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"en\"\r\n      class=\"light-style layout-menu-fixed\"\r\n      dir=\"ltr\"\r\n      data-theme=\"theme-default\"\r\n      data-assets-path=\"~/sneat-1.0.0/assets/\"\r\n      data-template=\"vertical-menu-template-free\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/_header.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06d4b914c31bf6959374ca351c4d5cfd97b6ffe44176", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"layout-wrapper layout-content-navbar\">\r\n        <div class=\"layout-container\">\r\n           <aside id=\"layout-menu\" class=\"layout-menu menu-vertical menu bg-menu-theme\">\r\n                ");
#nullable restore
#line 21 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/_appBrandDemo.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <div class=\"menu-inner-shadow\"></div>\r\n\r\n                ");
#nullable restore
#line 25 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/_sideBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </aside>\r\n          \r\n            <div class=\"layout-page\">\r\n      \r\n                ");
#nullable restore
#line 31 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
           Write(await Html.PartialAsync("/Views/Admin/_navbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n              \r\n                <div class=\"content-wrapper\">\r\n                    <div class=\"container-xxl flex-grow-1 container-p-y\">\r\n\r\n                        ");
#nullable restore
#line 37 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    \r\n                    ");
#nullable restore
#line 40 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
               Write(await Html.PartialAsync("/Views/Admin/_footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <div class=\"content-backdrop fade\"></div>\r\n                </div>\r\n              \r\n            </div>\r\n        \r\n        </div>\r\n\r\n        <div class=\"layout-overlay layout-menu-toggle\"></div>\r\n    </div>\r\n    \r\n    ");
#nullable restore
#line 52 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/_script.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
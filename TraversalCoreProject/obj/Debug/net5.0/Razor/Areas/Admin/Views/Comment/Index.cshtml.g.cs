#pragma checksum "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b0628d1bd2bd2634d329813358f424e55d98d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b0628d1bd2bd2634d329813358f424e55d98d1", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a5881ca61041a84e5a8a68c5738a44fa392079", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Yorum Listesi</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Kullanıcı</th>
                    <th>Rota</th>
                    <th>Tarih</th>
                    <th>İşlemler</th>
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 22 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
                 foreach (var item in Model)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 27 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
                       sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 28 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
                   Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>");
#nullable restore
#line 29 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
                           Write(item.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
                   Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
                    Write(((DateTime)item.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td><a class=\"badge bg-label-danger me-1\"");
            BeginWriteAttribute("href", " href=\"", 1083, "\"", 1128, 2);
            WriteAttributeValue("", 1090, "/Comment/DeleteComment/", 1090, 23, true);
#nullable restore
#line 34 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1113, item.CommentId, 1113, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Comment\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n   \r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591

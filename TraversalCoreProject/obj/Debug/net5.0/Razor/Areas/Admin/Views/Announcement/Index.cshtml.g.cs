#pragma checksum "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b044ce09fe922e7ad00528e5f2134ea5e85fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Announcement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
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
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b044ce09fe922e7ad00528e5f2134ea5e85fd5", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3ba439c1cd3d1c10ef89b83b16d4b61227cf10", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Duyuru Listesi</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Başlık</th>
                    <th>İçerik</th>
                    <th>Detaylar</th>
                    <th>İşlemler</th>

                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 23 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
                 foreach (var item in Model)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 28 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
                       sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 29 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
                   Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> <strong>");
#nullable restore
#line 30 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
                   Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                    <td><a class=""badge bg-label-primary me-1"" href=""#"">Detaylar</a></td>
                    <td>
                        <div class=""dropdown"">
                            <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                <i class=""bx bx-dots-vertical-rounded""></i>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 1446, "\"", 1512, 2);
            WriteAttributeValue("", 1453, "/Admin/Announcement/UpdateAnnouncement/", 1453, 39, true);
#nullable restore
#line 40 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 1492, item.AnnouncementId, 1492, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i> Güncelle</a>\r\n                                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1620, "\"", 1686, 2);
            WriteAttributeValue("", 1627, "/Admin/Announcement/DeleteAnnouncement/", 1627, 39, true);
#nullable restore
#line 41 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 1666, item.AnnouncementId, 1666, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-trash me-1\"></i> Sil</a>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n    <br />\r\n    <a class=\"btn btn-primary\" href=\"/Admin/Announcement/AddAnnouncement/\">Yeni Duyuru Oluştur</a>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

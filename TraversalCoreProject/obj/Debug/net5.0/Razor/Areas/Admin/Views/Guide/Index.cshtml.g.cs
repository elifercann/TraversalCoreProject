#pragma checksum "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1321438325e913c1b891470770be7314209ecce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1321438325e913c1b891470770be7314209ecce", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5e4f4ee20e66c99cd8182431574b73439134f4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Rehber Listesi</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Görsel</th>
                    <th>Ad Soyad</th>
                    <th>Açıklama</th>
                    <th>Durum</th>
                    <th>İşlemler</th>

                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 24 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                 foreach (var item in Model)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 29 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                           sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 30 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                       Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 862, "\"", 879, 1);
#nullable restore
#line 31 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 868, item.Image, 868, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"avatar avatar-sm me-3\" alt=\"Image placeholder\" /></td>\r\n                        <td><strong>");
#nullable restore
#line 32 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 38 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                         if (item.Status == true)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a class=\"btn btn-primary\" href=\"#\">Pasif Yap</a>\r\n\r\n                            </td>\r\n");
#nullable restore
#line 46 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a class=\"btn btn-warning\" href=\"#\">Aktif Yap</a>\r\n\r\n                            </td>\r\n");
#nullable restore
#line 53 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td><a class=\"badge bg-label-primary me-1\"");
            BeginWriteAttribute("href", " href=\"", 1687, "\"", 1730, 2);
            WriteAttributeValue("", 1694, "/Admin/Guide/EditGuide/", 1694, 23, true);
#nullable restore
#line 55 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1717, item.GuideId, 1717, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i> Güncelle</a></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Guide\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n\r\n    <br />\r\n    <a class=\"btn btn-primary\" href=\"/Admin/Guide/AddGuide/\">Yeni Rehber Oluştur</a>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0e14fa7121ac442d8e940fb0bac6625d2ebf5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef0e14fa7121ac442d8e940fb0bac6625d2ebf5e", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5e4f4ee20e66c99cd8182431574b73439134f4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card"">
    <h5 class=""card-header"">Kullanıcı Listesi</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Ad Soyad</th>     
                    <th>Kullanıcı Adı</th>
                    <th>Mail</th>
                  
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 23 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                 foreach (var item in Model)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 28 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                       sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 29 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                   Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 30 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                                                                                            Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td><a class=\"badge bg-label-primary me-1\"");
            BeginWriteAttribute("href", " href=\"", 1101, "\"", 1139, 2);
            WriteAttributeValue("", 1108, "/Admin/User/UpdateUser/", 1108, 23, true);
#nullable restore
#line 36 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1131, item.Id, 1131, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i> Güncelle</a></td>\r\n                    <td><a class=\"badge bg-label-primary me-1\"");
            BeginWriteAttribute("href", " href=\"", 1258, "\"", 1296, 2);
            WriteAttributeValue("", 1265, "/Admin/User/DeleteUser/", 1265, 23, true);
#nullable restore
#line 37 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1288, item.Id, 1288, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-refresh\"></i> Sil</a></td>\r\n                    <td><a class=\"badge bg-label-primary me-1\"");
            BeginWriteAttribute("href", " href=\"", 1404, "\"", 1443, 2);
            WriteAttributeValue("", 1411, "/Admin/User/CommentUser/", 1411, 24, true);
#nullable restore
#line 38 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1435, item.Id, 1435, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-comment-detail\"></i> Yorumlar</a></td>\r\n                    <td><a class=\"badge bg-label-primary me-1\"");
            BeginWriteAttribute("href", " href=\"", 1563, "\"", 1606, 2);
            WriteAttributeValue("", 1570, "/Admin/User/ReservationUser/", 1570, 28, true);
#nullable restore
#line 39 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1598, item.Id, 1598, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-navigation\"></i> Tur Geçmişi</a></td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\ercan\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n    <br />\r\n    <a class=\"btn btn-primary\" href=\"/Login/SignUp/\">Yeni Kullanıcı Ekle</a>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

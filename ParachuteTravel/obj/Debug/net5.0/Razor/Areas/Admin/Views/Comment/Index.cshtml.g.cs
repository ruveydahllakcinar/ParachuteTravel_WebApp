#pragma checksum "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9104089efa334d1ab3f113ce566c69775951e230"
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
#line 2 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using ParachuteTravel.Areas.Users.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using ParachuteTravel.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using ParachuteTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9104089efa334d1ab3f113ce566c69775951e230", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520e483728a4e491b69bc7e478ec35ffd6e1e95c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Comment List</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>User</th>
                    <th>Route</th>
                    <th>Date</th>
                    <th>Delete</th>
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 21 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
                 foreach (var comment in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 24 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
                                                                                     Write(comment.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.Destination.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
                       Write(comment.CommentDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>\r\n                           <a");
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1064, 2);
            WriteAttributeValue("", 1017, "/Admin/Comment/DeleteComment/", 1017, 29, true);
#nullable restore
#line 28 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1046, comment.CommentId, 1046, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Comment\Index.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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

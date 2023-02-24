#pragma checksum "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee94bb278ebd2d18dab76dcb1f235c450a9dc3b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
using ParachuteTravel.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using ParachuteTravel.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using ParachuteTravel.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using ParachuteTravel.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using ParachuteTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee94bb278ebd2d18dab76dcb1f235c450a9dc3b7", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce40cfed116b43da6b081e5159eca1ff195e274b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Tour Routes</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>City</th>
                    <th>Price</th>
                    <th>Capacity</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 21 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
                 foreach (var destination in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 24 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
                                                                                 Write(destination.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
                   Write(destination.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
                   Write(destination.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                    <td>
                        <div class=""dropdown"">
                            <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                <i class=""bx bx-dots-vertical-rounded""></i>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 1340, "\"", 1405, 2);
            WriteAttributeValue("", 1347, "/Destination/DestinationDetails/", 1347, 32, true);
#nullable restore
#line 34 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1379, destination.DestinationId, 1379, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-show-alt me-1\"></i> See on Site</a>\r\n                                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1516, "\"", 1584, 2);
            WriteAttributeValue("", 1523, "/Admin/Destination/EditDestination/", 1523, 35, true);
#nullable restore
#line 35 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1558, destination.DestinationId, 1558, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i> Edit</a>\r\n                                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1688, "\"", 1758, 2);
            WriteAttributeValue("", 1695, "/Admin/Destination/DeleteDestination/", 1695, 37, true);
#nullable restore
#line 36 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 1732, destination.DestinationId, 1732, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-trash me-1\"></i> Delete</a>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td></td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Destination\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n        <div class=\"btn-sm mt-2 pl-3 mb-2\">\r\n            <a href=\"/Admin/Destination/AddDestination\" class=\"btn btn-outline-primary\">Add New Tour Route</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\BookingExchange\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b2be3e491de8a663a151e7cddb376b0bdc5d68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BookingExchange_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BookingExchange/Index.cshtml")]
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
#line 3 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

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
using ParachuteTravel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b2be3e491de8a663a151e7cddb376b0bdc5d68", @"/Areas/Admin/Views/BookingExchange/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22faac07af0a76d76fa84614ac41b2f759b384de", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BookingExchange_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingExchangeViewModel2.Exchange_Rates>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\BookingExchange\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Booking Api Rate Information</h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Rate Name</th>
                    <th>Exchange rate</th>
                  
                </tr>
            </thead>
            <tbody class=""table-border-bottom-0"">
");
#nullable restore
#line 19 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\BookingExchange\Index.cshtml"
                 foreach (var rates in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\BookingExchange\Index.cshtml"
                       Write(rates.currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\BookingExchange\Index.cshtml"
                       Write(rates.exchange_rate_buy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\BookingExchange\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingExchangeViewModel2.Exchange_Rates>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "229b822c1ea3f2ed95a436c802cdcff29916dcd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__FeatureLargeCardsViewPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_FeatureLargeCardsViewPartial/Default.cshtml")]
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
#line 1 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\_ViewImports.cshtml"
using ParachuteTravel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\_ViewImports.cshtml"
using ParachuteTravel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229b822c1ea3f2ed95a436c802cdcff29916dcd8", @"/Views/Shared/Components/_FeatureLargeCardsViewPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dae52793dd8346477f0d0df0878fbb18a485ea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__FeatureLargeCardsViewPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FeatureLargeCard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"best-rooms py-5\">\r\n        <div class=\"container py-md-5\">\r\n            <div class=\"ban-content-inf row\">\r\n");
#nullable restore
#line 6 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                  
                    var values1 = Model.Take(1);
                    var values2 = Model.TakeLast(2);
                    string cssCard = null;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                 if (values1.Any(x => x.FeatureLargeCardId == Model[0].FeatureLargeCardId))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"maghny-gd-1 col-lg-6\">\r\n                        <div class=\"maghny-grid\">\r\n                            <figure class=\"effect-lily border-radius  m-0\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 720, "\"", 741, 1);
#nullable restore
#line 16 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
WriteAttributeValue("", 726, Model[0].Image, 726, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 742, "\"", 748, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <figcaption>\r\n                                    <div>\r\n                                        <h4>");
#nullable restore
#line 19 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                                       Write(Model[0].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p>");
#nullable restore
#line 20 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                                      Write(Model[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        <p>");
#nullable restore
#line 21 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                                      Write(Model[0].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $ </p>\r\n                                    </div>\r\n\r\n                                </figcaption>\r\n                            </figure>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"maghny-gd-1 col-lg-6 mt-lg-0 mt-4\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 32 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                         foreach (var item in Model.Skip(1).ToList())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                             if (values2.Any(x => x.FeatureLargeCardId == item.FeatureLargeCardId)) cssCard = "mt-4";
                            else cssCard = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1663, "\"", 1697, 3);
            WriteAttributeValue("", 1671, "maghny-gd-1", 1671, 11, true);
            WriteAttributeValue(" ", 1682, "col-6", 1683, 6, true);
#nullable restore
#line 36 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
WriteAttributeValue(" ", 1688, cssCard, 1689, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"maghny-grid\">\r\n                                    <figure class=\"effect-lily border-radius\">\r\n                                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1902, "\"", 1919, 1);
#nullable restore
#line 39 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
WriteAttributeValue("", 1908, item.Image, 1908, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1920, "\"", 1926, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <figcaption>\r\n                                            <div class=\"mb-4\">\r\n                                                <h4>");
#nullable restore
#line 42 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                <p>");
#nullable restore
#line 43 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                                <p>");
#nullable restore
#line 44 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" $ </p>
                                             
                                            </div>
                                        </figcaption>
                                    </figure>
                                </div>
                            </div>
");
#nullable restore
#line 51 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_FeatureLargeCardsViewPartial\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FeatureLargeCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
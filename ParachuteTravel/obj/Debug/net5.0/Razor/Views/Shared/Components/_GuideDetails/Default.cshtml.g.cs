#pragma checksum "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_GuideDetails\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b35aeefc4be950ef12bca035650d38f372c7cb6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__GuideDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_GuideDetails/Default.cshtml")]
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
#line 3 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35aeefc4be950ef12bca035650d38f372c7cb6a", @"/Views/Shared/Components/_GuideDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dae52793dd8346477f0d0df0878fbb18a485ea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__GuideDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Guide>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"author-card mt-5\">\n    <div class=\"row align-items-center\">\n        <div class=\"col-sm-3 col-6\">\n            <div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b35aeefc4be950ef12bca035650d38f372c7cb6a4337", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 187, "~/GuideImage/", 187, 13, true);
#nullable restore
#line 6 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_GuideDetails\Default.cshtml"
AddHtmlAttributeValue("", 200, Model.Image, 200, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"col-sm-9 mt-sm-0 mt-3\">\n            <h3 class=\"mb-3 title\">");
#nullable restore
#line 10 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_GuideDetails\Default.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <p>\n                ");
#nullable restore
#line 12 "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Views\Shared\Components\_GuideDetails\Default.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
            <ul class=""author-icons mt-4"">
                <li>
                    <a class=""facebook"" href=""#url"">
                        <span class=""fa fa-facebook""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""twitter"" href=""#url"">
                        <span class=""fa fa-twitter""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""google"" href=""#url"">
                        <span class=""fa fa-google-plus""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""linkedin"" href=""#url"">
                        <span class=""fa fa-linkedin""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                   ");
            WriteLiteral(@" <a class=""github"" href=""#url"">
                        <span class=""fa fa-github""
                              aria-hidden=""true""></span>
                    </a>
                </li>
                <li>
                    <a class=""dribbble"" href=""#url"">
                        <span class=""fa fa-dribbble""
                              aria-hidden=""true""></span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Guide> Html { get; private set; }
    }
}
#pragma warning restore 1591
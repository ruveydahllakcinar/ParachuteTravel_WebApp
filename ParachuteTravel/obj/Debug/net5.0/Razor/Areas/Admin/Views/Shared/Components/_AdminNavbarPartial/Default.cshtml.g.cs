#pragma checksum "C:\Users\Ruveyda\source\ParachuteTravel_WebApp\ParachuteTravel\Areas\Admin\Views\Shared\Components\_AdminNavbarPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef4314f04211954e7c72f14adabf72a73eccd3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components__AdminNavbarPartial_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/_AdminNavbarPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef4314f04211954e7c72f14adabf72a73eccd3b", @"/Areas/Admin/Views/Shared/Components/_AdminNavbarPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components__AdminNavbarPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/TraversalTheme_Admin/assets/img/avatars/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-px-40 h-auto rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<nav class=""layout-navbar container-xxl navbar navbar-expand-xl navbar-detached align-items-center bg-navbar-theme""
     id=""layout-navbar"">
    <div class=""layout-menu-toggle navbar-nav align-items-xl-center me-3 me-xl-0 d-xl-none"">
        <a class=""nav-item nav-link px-0 me-xl-4"" href=""javascript:void(0)"">
            <i class=""bx bx-menu bx-sm""></i>
        </a>
    </div>

    <div class=""navbar-nav-right d-flex align-items-center"" id=""navbar-collapse"">
        <!-- Search -->
        <div class=""navbar-nav align-items-center"">
            <div class=""nav-item d-flex align-items-center"">
                <i class=""bx bx-search fs-4 lh-0""></i>
                <input type=""text""
                       class=""form-control border-0 shadow-none""
                       placeholder=""Search...""
                       aria-label=""Search..."" />
            </div>
        </div>
        <!-- /Search -->

        <ul class=""navbar-nav flex-row align-items-center ms-auto"">
            <!-- Place ");
            WriteLiteral(@"this tag where you want the button to render. -->
            <li class=""nav-item lh-1 me-3"">
                <a class=""github-button""
                   href=""https://github.com/themeselection/sneat-html-admin-template-free""
                   data-icon=""octicon-star""
                   data-size=""large""
                   data-show-count=""true""
                   aria-label=""Star themeselection/sneat-html-admin-template-free on GitHub"">Star</a>
            </li>

            <!-- User -->
            <li class=""nav-item navbar-dropdown dropdown-user dropdown"">
                <a class=""nav-link dropdown-toggle hide-arrow"" href=""javascript:void(0);"" data-bs-toggle=""dropdown"">
                    <div class=""avatar avatar-online"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cef4314f04211954e7c72f14adabf72a73eccd3b5620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </a>
                <ul class=""dropdown-menu dropdown-menu-end"">
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <div class=""d-flex"">
                                <div class=""flex-shrink-0 me-3"">
                                    <div class=""avatar avatar-online"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cef4314f04211954e7c72f14adabf72a73eccd3b7170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""flex-grow-1"">
                                    <span class=""fw-semibold d-block"">John Doe</span>
                                    <small class=""text-muted"">Admin</small>
                                </div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""bx bx-user me-2""></i>
                            <span class=""align-middle"">My Profile</span>
                        </a>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""bx bx-cog me-2""></i>
                            <span class=""al");
            WriteLiteral(@"ign-middle"">Settings</span>
                        </a>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <span class=""d-flex align-items-center align-middle"">
                                <i class=""flex-shrink-0 bx bx-credit-card me-2""></i>
                                <span class=""flex-grow-1 align-middle"">Billing</span>
                                <span class=""flex-shrink-0 badge badge-center rounded-pill bg-danger w-px-20 h-px-20"">4</span>
                            </span>
                        </a>
                    </li>
                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""auth-login-basic.html"">
                            <i class=""bx bx-power-off me-2""></i>
                            <span class=""align-middle"">Log Out</span>
                ");
            WriteLiteral("        </a>\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n            <!--/ User -->\r\n        </ul>\r\n    </div>\r\n</nav>\r\n");
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

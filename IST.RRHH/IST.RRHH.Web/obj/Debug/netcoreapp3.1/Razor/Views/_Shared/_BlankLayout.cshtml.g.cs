#pragma checksum "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "091f998a9a08d3481015f283160b9d955fc84a73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Shared__BlankLayout), @"mvc.1.0.view", @"/Views/_Shared/_BlankLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"091f998a9a08d3481015f283160b9d955fc84a73", @"/Views/_Shared/_BlankLayout.cshtml")]
    #nullable restore
    public class Views__Shared__BlankLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091f998a9a08d3481015f283160b9d955fc84a732821", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"" />
    <title>RRHH</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta content=""Premium Multipurpose Admin & Dashboard Template"" name=""description"" />
    <meta content=""Themesbrand"" name=""author"" />
    <!-- App favicon -->
    <link rel=""shortcut icon""");
                BeginWriteAttribute("href", " href=\"", 374, "\"", 437, 2);
#nullable restore
#line 12 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 381, IST.RRHH.Web.AppConfig.UrlWeb, 381, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 411, "/assets/images/favicon.ico", 411, 26, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <!-- Bootstrap Css -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 480, "\"", 546, 2);
#nullable restore
#line 15 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 487, IST.RRHH.Web.AppConfig.UrlWeb, 487, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 517, "/assets/css/bootstrap.min.css", 517, 29, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <!-- Icons Css -->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 602, "\"", 664, 2);
#nullable restore
#line 17 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 609, IST.RRHH.Web.AppConfig.UrlWeb, 609, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 639, "/assets/css/icons.min.css", 639, 25, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <!-- App Css-->\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 717, "\"", 777, 2);
#nullable restore
#line 19 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 724, IST.RRHH.Web.AppConfig.UrlWeb, 724, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 754, "/assets/css/app.min.css", 754, 23, true);
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n\r\n\r\n    ");
#nullable restore
#line 22 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- JAVASCRIPT -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 889, "\"", 958, 2);
#nullable restore
#line 25 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 895, IST.RRHH.Web.AppConfig.UrlWeb, 895, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 925, "/assets/libs/jquery/jquery.min.js", 925, 33, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "091f998a9a08d3481015f283160b9d955fc84a737131", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 30 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n  \r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1028, "\"", 1113, 2);
#nullable restore
#line 33 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1034, IST.RRHH.Web.AppConfig.UrlWeb, 1034, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1064, "/assets/libs/bootstrap/js/bootstrap.bundle.min.js", 1064, 49, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1137, "\"", 1212, 2);
#nullable restore
#line 34 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1143, IST.RRHH.Web.AppConfig.UrlWeb, 1143, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1173, "/assets/libs/metismenu/metisMenu.min.js", 1173, 39, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1236, "\"", 1311, 2);
#nullable restore
#line 35 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1242, IST.RRHH.Web.AppConfig.UrlWeb, 1242, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1272, "/assets/libs/simplebar/simplebar.min.js", 1272, 39, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1335, "\"", 1407, 2);
#nullable restore
#line 36 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1341, IST.RRHH.Web.AppConfig.UrlWeb, 1341, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1371, "/assets/libs/node-waves/waves.min.js", 1371, 36, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    \r\n\r\n    <!-- owl.carousel js -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1469, "\"", 1550, 2);
#nullable restore
#line 40 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1475, IST.RRHH.Web.AppConfig.UrlWeb, 1475, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1505, "/assets/libs/owl.carousel/owl.carousel.min.js", 1505, 45, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- auth-2-carousel init -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1609, "\"", 1685, 2);
#nullable restore
#line 42 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1615, IST.RRHH.Web.AppConfig.UrlWeb, 1615, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1645, "/assets/js/pages/auth-2-carousel.init.js", 1645, 40, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- two-step-verification js -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1748, "\"", 1834, 2);
#nullable restore
#line 44 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1754, IST.RRHH.Web.AppConfig.UrlWeb, 1754, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1784, "/web/assets/js/pages/two-step-verification.init.js", 1784, 50, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n    ");
#nullable restore
#line 46 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- App js -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1929, "\"", 1986, 2);
#nullable restore
#line 48 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_Shared\_BlankLayout.cshtml"
WriteAttributeValue("", 1935, IST.RRHH.Web.AppConfig.UrlWeb, 1935, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1965, "/web/assets/js/app.js", 1965, 21, true);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
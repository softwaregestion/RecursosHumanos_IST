#pragma checksum "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_OldShared\_Alert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d882dc2d3146d195c037ac8601535911ec2ac0c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__OldShared__Alert), @"mvc.1.0.view", @"/Views/_OldShared/_Alert.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d882dc2d3146d195c037ac8601535911ec2ac0c1", @"/Views/_OldShared/_Alert.cshtml")]
    #nullable restore
    public class Views__OldShared__Alert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_OldShared\_Alert.cshtml"
 if (TempData["Error"] != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible container fade show\" style=\"margin-bottom: 60px;\" role=\"alert\">\r\n        <strong>");
#nullable restore
#line 5 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_OldShared\_Alert.cshtml"
           Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n    </div>\r\n");
#nullable restore
#line 8 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_OldShared\_Alert.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_OldShared\_Alert.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible container fade show\" style=\"margin-bottom: 60px;\" role=\"alert\">\r\n        <strong>");
#nullable restore
#line 12 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_OldShared\_Alert.cshtml"
           Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n    </div>\r\n");
#nullable restore
#line 15 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\_OldShared\_Alert.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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

#pragma checksum "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\Client\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3394c7432df3d64bd23ca8cb52205ab0f3741b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Account), @"mvc.1.0.view", @"/Views/Client/Account.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3394c7432df3d64bd23ca8cb52205ab0f3741b6e", @"/Views/Client/Account.cshtml")]
    #nullable restore
    public class Views_Client_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/iCheck/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/iCheck/icheck.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\Client\Account.cshtml"
  
    ViewBag.Title = "Mi cuenta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Administrador de usuarios</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 276, "\"", 311, 1);
#nullable restore
#line 12 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\Client\Account.cshtml"
WriteAttributeValue("", 283, Url.Action("Index", "Home"), 283, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Inicio</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Usuarios</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Mi cuenta</strong>
            </li>
        </ol>
    </div>
</div>

<div class=""wrapper wrapper-content  animated fadeInRight"">


    <div class=""wrapper wrapper-content  animated fadeInRight"">
        <div class=""row"">
            <div class=""col-sm-6 col-sm-offset-3"">
                <div class=""ibox"">
                    <div class=""ibox-content"">



                        <strong>Sistema</strong>
                        <ul class=""list-group clear-list"">

                            <li class=""list-group-item fist-item"">
                                <span class=""float-left""> Perfil  </span>
                                <select class=""form-control"">
                                    <option>Perfil ..</option>
                                    <option>Perfil ..</option>
    ");
            WriteLiteral(@"                            </select>
                            </li>
                            <li class=""list-group-item "">
                                <label>   <input type=""checkbox"" class=""i-checks""> Activo</label>
                                <label>   <input type=""checkbox"" class=""i-checks""> Necesita Autorizaci??n</label>
                            </li>


                        </ul>

                        <strong>Datos</strong>

                        <ul class=""list-group clear-list"">
                            <li class=""list-group-item fist-item"">
                                <span class=""float-left""> Email  </span>
                                <input type=""text"" class=""form-control"" />
                            </li>
                            <li class=""list-group-item "">
                                <span class=""float-left""> Rut  </span>
                                <input type=""text"" class=""form-control"" />
                            </li>
 ");
            WriteLiteral(@"                           <li class=""list-group-item "">
                                <span class=""float-left""> Nombres  </span>
                                <input type=""text"" class=""form-control"" />
                            </li>
                            <li class=""list-group-item "">
                                <span class=""float-left""> Apellido Paterno  </span>
                                <input type=""text"" class=""form-control"" />
                            </li>

                            <li class=""list-group-item "">
                                <span class=""float-left""> Apellido Materno  </span>
                                <input type=""text"" class=""form-control"" />
                            </li>

                            <li class=""list-group-item "">
                                <span class=""float-left""> Cliente  </span>
                                <select class=""form-control"">
                                    <option>Cliente</option>
     ");
            WriteLiteral(@"                           </select>
                            </li>

                            <li class=""list-group-item "">
                                <table class=""table table-responsive"">
                                    <tr>
                                        <td style=""width:30%"">

                                            <strong>Faenas</strong>
                                            <ul class=""list-group clear-list"">

                                                <li class=""list-group-item "">
                                                    <button type=""button"" class=""btn btn-default btn-sm "">
                                                        <i class=""fa fa-save""></i>Agregar
                                                    </button>
                                                </li>

                                            </ul>
                                        </td>

                                        <td style=""width:30%""");
            WriteLiteral(@">

                                            <strong>Contrato</strong>
                                            <ul class=""list-group clear-list"">


                                                <li class=""list-group-item "">
                                                    <button type=""button"" class=""btn btn-default btn-sm"">
                                                        <i class=""fa fa-save""></i>Agregar
                                                    </button>
                                                </li>
                                            </ul>
                                        </td>

                                        <td style=""width:30%"">

                                            <strong>Centro de Almacenes</strong>
                                            <ul class=""list-group clear-list"">

                                                <li class=""list-group-item "">
                                                    <button ");
            WriteLiteral(@"type=""button"" class=""btn btn-default btn-sm"">
                                                        <i class=""fa fa-save""></i>Agregar
                                                    </button>
                                                </li>
                                            </ul>
                                        </td>

                                    </tr>
                                </table>



                            </li>

                        </ul>


                    </div>
                </div>
            </div>
        </div>
    </div>

</div>


");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3394c7432df3d64bd23ca8cb52205ab0f3741b6e10710", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3394c7432df3d64bd23ca8cb52205ab0f3741b6e12049", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document.body).on(""click"", "".client-link"", function (e) {
            e.preventDefault()
            $("".selected .tab-pane"").removeClass('active');
            $($(this).attr('href')).addClass(""active"");

            $('.i-checks').iCheck({
                checkboxClass: 'icheckbox_square-green',
                radioClass: 'iradio_square-green',
            });

        });</script>

");
            }
            );
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

#pragma checksum "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3235e80b47f639eef172cfb488ca24d2a693aa50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyAccount_Index), @"mvc.1.0.view", @"/Views/MyAccount/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3235e80b47f639eef172cfb488ca24d2a693aa50", @"/Views/MyAccount/Index.cshtml")]
    #nullable restore
    public class Views_MyAccount_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IST.RRHH.Web.Models.UserIndexModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/iCheck/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert/dist/sweetalert.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/iCheck/icheck.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sweetalert/dist/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
  
    ViewBag.Title = "Mi cuenta";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .w-100px {
        width: 150px !important;
    }
</style>

<div class=""row wrapper border-bottom white-bg page-heading"">
    <div class=""col-lg-10"">
        <h2>Administrador de usuarios</h2>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a");
            BeginWriteAttribute("href", " href=\"", 393, "\"", 428, 1);
#nullable restore
#line 17 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
WriteAttributeValue("", 400, Url.Action("Index", "Home"), 400, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""color: #702fa0"">Inicio</a>
            </li>
            
            <li class=""active breadcrumb-item"">
                <strong>Mi cuenta</strong>
            </li>
        </ol>
    </div>
</div>

<div class=""mailbox"">
    <!-- BEGIN mailbox-toolbar -->
");
#nullable restore
#line 29 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""mailbox-toolbar"">
            <div class=""mailbox-toolbar-item""><span class=""mailbox-toolbar-text"">Mantén la información actualizada de tu cuenta</span></div>
            <hr />
            <div class=""mailbox-toolbar-item text-center"">

                <button style=""margin-top: -2px; background-color: #702fa0; color: white"" type=""submit"" name=""btnPost"" value=""Grabar"" class=""btn btn-sm btn-block"">
                    <i class=""fa fa-save""></i> Guardar cambios
                </button>


                <a style=""margin-top: -2px; background-color: #cf2484; color: white"" class=""modal-launcher btn btn-sm  btn-block""
                   href=""#""
                   data-url=""");
#nullable restore
#line 44 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                        Write(Url.Action("RecoveryPassword", "User", new { id = Model.UserId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <i class=\"fa fa-mail-forward\"></i> Reestablecer contraseña\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 48 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
             if (User.Identity.IsAuthenticated && User.IsInRole("Adherente"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""mailbox-toolbar-item"">

                    <a style=""margin-top: -2px; background-color: #ff7c00; color: white"" class=""btn btn-sm  btn-block""
                       href=""#""
                       onclick=""editarAdherente()"">
                        <i class=""fa fa-mail-forward""></i> Editar perfil ");
#nullable restore
#line 55 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                                                    Write(Model.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 58 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <hr />
        <!-- END mailbox-toolbar -->
        <!-- BEGIN mailbox-body -->
        <div class=""mailbox-body"">
            <div class=""mailbox-content"">
                <!-- BEGIN scrollbar -->
                <div data-scrollbar=""true"" data-height=""100%"" data-skip-mobile=""true"">
                    <div class=""mailbox-form"">
                        <form action=""#"" method=""POST"" name=""email_form"">
                            <div class=""mailbox-form-header"">

                                ");
#nullable restore
#line 72 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                           Write(Html.HiddenFor(c => c.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 73 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                           Write(Html.HiddenFor(d => d.Rol));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Perfil:</label>
                                    <div class=""col"">
                                        <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 3080, "\"", 3098, 1);
#nullable restore
#line 78 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
WriteAttributeValue("", 3088, Model.Rol, 3088, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" disabled />
                                    </div>
                                </div>
                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Email:</label>
                                    <div class=""col"">
                                        ");
#nullable restore
#line 84 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                   Write(Html.TextBoxFor(c => c.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Rut:</label>
                                    <div class=""col"">
                                        ");
#nullable restore
#line 90 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                   Write(Html.TextBoxFor(c => c.Rut, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Nombres:</label>
                                    <div class=""col"">
                                        ");
#nullable restore
#line 96 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                   Write(Html.TextBoxFor(c => c.Nombres, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Apellido Paterno:</label>
                                    <div class=""col"">
                                        ");
#nullable restore
#line 102 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                   Write(Html.TextBoxFor(c => c.ApellidoPaterno, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Apellido Materno:</label>
                                    <div class=""col"">
                                        ");
#nullable restore
#line 108 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                   Write(Html.TextBoxFor(c => c.ApellidoMaterno, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Teléfono:</label>
                                    <div class=""col"">
                                        ");
#nullable restore
#line 114 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                   Write(Html.TextBoxFor(c => c.Telefono, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row p-1"">
                                    <label class=""col-form-label w-100px ps-2 pe-2 fw-500 text-end"">Dirección:</label>
                                    <div class=""col"">
                                        ");
#nullable restore
#line 120 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                   Write(Html.TextBoxFor(c => c.Direccion, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>




                            </div>

                        </form>
                    </div>
                </div>
                <!-- END scrollbar -->
            </div>
        </div>
        <!-- END mailbox-body -->
");
#nullable restore
#line 136 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<div class=""wrapper wrapper-content  animated fadeInRight"">


    <div class=""wrapper wrapper-content  animated fadeInRight"">
        <div class=""row"">
            <div class=""col-sm-6 col-sm-offset-3"">
                <div class=""ibox"">
                    <div class=""ibox-content"" style=""min-height: 1030px"">

                                             

                    </div>
                </div>
            </div>
        </div>
    </div>

</div>


<div id=""modal-form"" class=""modal fade"" aria-hidden=""true"">
    <div class=""modal-dialog mw-100 w-75"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" id=""modal-close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <iframe class=""col-lg-12 col-md-12 col-sm-12""");
            BeginWriteAttribute("src", " src=\'", 7365, "\'", 7371, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"viewContent\" height=\"800\" frameBorder=\"0\">\r\n                </iframe>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3235e80b47f639eef172cfb488ca24d2a693aa5016737", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3235e80b47f639eef172cfb488ca24d2a693aa5017916", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3235e80b47f639eef172cfb488ca24d2a693aa5019255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3235e80b47f639eef172cfb488ca24d2a693aa5020355", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n        function editarAdherente() {\r\n\r\n            window.location = \'");
#nullable restore
#line 188 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                          Write(IST.RRHH.Web.AppConfig.UrlWeb);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' +\'/Adherente/Edit?userId=\' + \'");
#nullable restore
#line 188 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                                                                                        Write(Model.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n\r\n        }\r\n\r\n        var controller = \'");
#nullable restore
#line 192 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                     Write(ViewContext.RouteData.Values["controller"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n\r\n        var User = {};\r\n        var UserId = \'");
#nullable restore
#line 195 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\MyAccount\Index.cshtml"
                 Write(Model.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

        var topscroll = 0;

        console.log(User);

        $(document.body).on(""click"", "".client-link"", function (e) {
            e.preventDefault()
            $("".selected .tab-pane"").removeClass('active');
            $($(this).attr('href')).addClass(""active"");
        });

        $(document).ready(function () {


            $("".modal-launcher, #modal-background, #modal-close"").click(function () {


                $fancyModal = $('#modal-form');
                $fancyModal.modal('show');
                    var url = $(this).data(""url"");
                    var iframe = document.getElementById(""viewContent"");

                    if ($('#modal-form:visible').length == 0) {
                        iframe.src = url  + ""?"" + (new Date().getTime());
                        topscroll = $(window).scrollTop();
                        $(window).scrollTop(0);
                    }
                    else {
                        iframe.src = """";
                        /");
                WriteLiteral("/llamarApiUsuario(User.UserId);\r\n                        $(window).scrollTop(topscroll);\r\n                    }\r\n\r\n                    $(\"#modal-content,#modal-background\").toggle();\r\n\r\n\r\n\r\n\r\n            });\r\n\r\n\r\n        });\r\n\r\n\r\n\r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IST.RRHH.Web.Models.UserIndexModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

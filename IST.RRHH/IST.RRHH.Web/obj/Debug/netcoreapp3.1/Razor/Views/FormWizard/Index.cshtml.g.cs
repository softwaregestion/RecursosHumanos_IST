#pragma checksum "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\FormWizard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7b6c0eb019848e930661d6001f54a4659687db5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FormWizard_Index), @"mvc.1.0.view", @"/Views/FormWizard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7b6c0eb019848e930661d6001f54a4659687db5", @"/Views/FormWizard/Index.cshtml")]
    #nullable restore
    public class Views_FormWizard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/metismenu/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/simplebar/simplebar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/node-waves/waves.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery-steps/build/jquery.steps.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/form-wizard.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\FormWizard\Index.cshtml"
  
    ViewBag.Title = "Form Wizard";
    ViewBag.pTitle = "Form Wizard";
    ViewBag.pageTitle = "Forms";
    Layout = "~/Views/_Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title mb-4"">Basic Wizard</h4>

                <div id=""basic-example"">
                    <!-- Seller Details -->
                    <h3>Seller Details</h3>
                    <section>
                        <form>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-firstname-input"">First name</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-firstname-input"">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-lastname-input"">Last");
            WriteLiteral(@" name</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-lastname-input"">
                                    </div>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-phoneno-input"">Phone</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-phoneno-input"">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-email-input"">Email</label>
                                        <input type=""email"" class=""form-control"" id=""basicpill-email-input"">
                 ");
            WriteLiteral(@"                   </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-address-input"">Address</label>
                                        <textarea id=""basicpill-address-input"" class=""form-control"" rows=""2""></textarea>
                                    </div>
                                </div>
                            </div>
                        </form>
                    </section>

                    <!-- Company Document -->
                    <h3>Company Document</h3>
                    <section>
                        <form>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <l");
            WriteLiteral(@"abel for=""basicpill-pancard-input"">PAN Card</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-pancard-input"">
                                    </div>
                                </div>

                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-vatno-input"">VAT/TIN No.</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-vatno-input"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-cstno-input"">CST No.</label>
                                        <input type=""text"" class=""form-control"" id=""ba");
            WriteLiteral(@"sicpill-cstno-input"">
                                    </div>
                                </div>

                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-servicetax-input"">Service Tax No.</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-servicetax-input"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-companyuin-input"">Company UIN</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-companyuin-input"">
                                    </div>
                                </div>

    ");
            WriteLiteral(@"                            <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""basicpill-declaration-input"">Declaration</label>
                                        <input type=""text"" class=""form-control"" id=""basicpill-Declaration-input"">
                                    </div>
                                </div>
                            </div>
                        </form>
                    </section>

                    <!-- Bank Details -->
                    <h3>Bank Details</h3>
                    <section>
                        <div>
                            <form>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <label for=""basicpill-namecard-input"">Name on Card</label>
                                            <input ty");
            WriteLiteral(@"pe=""text"" class=""form-control"" id=""basicpill-namecard-input"">
                                        </div>
                                    </div>

                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <label>Credit Card Type</label>
                                            <select class=""form-select"">
                                                <option selected>Select Card Type</option>
                                                <option value=""AE"">American Express</option>
                                                <option value=""VI"">Visa</option>
                                                <option value=""MC"">MasterCard</option>
                                                <option value=""DI"">Discover</option>
                                            </select>
                                        </div>
                                    </div>
       ");
            WriteLiteral(@"                         </div>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <label for=""basicpill-cardno-input"">Credit Card Number</label>
                                            <input type=""text"" class=""form-control"" id=""basicpill-cardno-input"">
                                        </div>
                                    </div>

                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <label for=""basicpill-card-verification-input"">Card Verification Number</label>
                                            <input type=""text"" class=""form-control"" id=""basicpill-card-verification-input"">
                                        </div>
                                    </div>
                                </div>
  ");
            WriteLiteral(@"                              <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <label for=""basicpill-expiration-input"">Expiration Date</label>
                                            <input type=""text"" class=""form-control"" id=""basicpill-expiration-input"">
                                        </div>
                                    </div>

                                </div>
                            </form>
                        </div>
                    </section>

                    <!-- Confirm Details -->
                    <h3>Confirm Detail</h3>
                    <section>
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-6"">
                                <div class=""text-center"">
                                    <div class=""mb-4"">
                                    ");
            WriteLiteral(@"    <i class=""mdi mdi-check-circle-outline text-success display-4""></i>
                                    </div>
                                    <div>
                                        <h5>Confirm Detail</h5>
                                        <p class=""text-muted"">If several languages coalesce, the grammar of the resulting</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>

            </div>
            <!-- end card body -->
        </div>
        <!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title mb-4"">Vertical Wizard</h4>

                <div id=""vertical-example"" class=""vertical-wizard"">
                    <!-- Seller Details -->
      ");
            WriteLiteral(@"              <h3>Seller Details</h3>
                    <section>
                        <form>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-firstname-input"">First name</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-firstname-input"">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-lastname-input"">Last name</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-lastname-input"">
                                    </div>
                                </div>
                            </div>

                ");
            WriteLiteral(@"            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-phoneno-input"">Phone</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-phoneno-input"">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-email-input"">Email</label>
                                        <input type=""email"" class=""form-control"" id=""verticalnav-email-input"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <div class=""mb");
            WriteLiteral(@"-3"">
                                        <label for=""verticalnav-address-input"">Address</label>
                                        <textarea id=""verticalnav-address-input"" class=""form-control"" rows=""2""></textarea>
                                    </div>
                                </div>
                            </div>
                        </form>
                    </section>

                    <!-- Company Document -->
                    <h3>Company Document</h3>
                    <section>
                        <form>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-pancard-input"">PAN Card</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-pancard-input"">
                                    </div>
                                </div>
");
            WriteLiteral(@"
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-vatno-input"">VAT/TIN No.</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-vatno-input"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-cstno-input"">CST No.</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-cstno-input"">
                                    </div>
                                </div>

                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                    ");
            WriteLiteral(@"                    <label for=""verticalnav-servicetax-input"">Service Tax No.</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-servicetax-input"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-companyuin-input"">Company UIN</label>
                                        <input type=""text"" class=""form-control"" id=""verticalnav-companyuin-input"">
                                    </div>
                                </div>

                                <div class=""col-lg-6"">
                                    <div class=""mb-3"">
                                        <label for=""verticalnav-declaration-input"">Declaration</label>
                     ");
            WriteLiteral(@"                   <input type=""text"" class=""form-control"" id=""verticalnav-Declaration-input"">
                                    </div>
                                </div>
                            </div>
                        </form>
                    </section>

                    <!-- Bank Details -->
                    <h3>Bank Details</h3>
                    <section>
                        <div>
                            <form>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <label for=""verticalnav-namecard-input"">Name on Card</label>
                                            <input type=""text"" class=""form-control"" id=""verticalnav-namecard-input"">
                                        </div>
                                    </div>

                                    <div class=""col-lg-6"">
        ");
            WriteLiteral(@"                                <div class=""mb-3"">
                                            <label>Credit Card Type</label>
                                            <select class=""form-select"">
                                                <option selected>Select Card Type</option>
                                                <option value=""AE"">American Express</option>
                                                <option value=""VI"">Visa</option>
                                                <option value=""MC"">MasterCard</option>
                                                <option value=""DI"">Discover</option>
                                            </select>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                     ");
            WriteLiteral(@"                       <label for=""verticalnav-cardno-input"">Credit Card Number</label>
                                            <input type=""text"" class=""form-control"" id=""verticalnav-cardno-input"">
                                        </div>
                                    </div>

                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <label for=""verticalnav-card-verification-input"">Card Verification Number</label>
                                            <input type=""text"" class=""form-control"" id=""verticalnav-card-verification-input"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""mb-3"">
                                            <lab");
            WriteLiteral(@"el for=""verticalnav-expiration-input"">Expiration Date</label>
                                            <input type=""text"" class=""form-control"" id=""verticalnav-expiration-input"">
                                        </div>
                                    </div>

                                </div>
                            </form>
                        </div>
                    </section>

                    <!-- Confirm Details -->
                    <h3>Confirm Detail</h3>
                    <section>
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-6"">
                                <div class=""text-center"">
                                    <div class=""mb-4"">
                                        <i class=""mdi mdi-check-circle-outline text-success display-4""></i>
                                    </div>
                                    <div>
                                        <h5>Confirm D");
            WriteLiteral(@"etail</h5>
                                        <p class=""text-muted"">If several languages coalesce, the grammar of the resulting</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>
        <!-- end card -->
    </div>
    <!-- end col -->
</div>
<!-- end row -->
<!-- JAVASCRIPT -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db527038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db528078", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db529118", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db530158", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db531198", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<!-- jquery step -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db532270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- form wizard init -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db533343", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b6c0eb019848e930661d6001f54a4659687db534387", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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

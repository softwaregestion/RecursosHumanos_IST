#pragma checksum "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\UiDropdowns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa965847b102d945cfb8a4d906bb34fca284b387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UiDropdowns_Index), @"mvc.1.0.view", @"/Views/UiDropdowns/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa965847b102d945cfb8a4d906bb34fca284b387", @"/Views/UiDropdowns/Index.cshtml")]
    #nullable restore
    public class Views_UiDropdowns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/metismenu/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/simplebar/simplebar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/node-waves/waves.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\PROJECTS\IST\RecursosHumanos_IST\IST.RRHH\IST.RRHH.Web\Views\UiDropdowns\Index.cshtml"
  
    ViewBag.Title = "Dropdowns";
    ViewBag.pTitle = "Dropdowns";
    ViewBag.pageTitle = "UI Elements";
    Layout = "~/Views/_Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Single button dropdowns</h4>
                <p class=""card-title-desc"">
                    Any single <code class=""highlighter-rouge"">.btn</code> can be turned into a dropdown
                    toggle with some markup changes. Here???s how you can put them to work
                    with either <code class=""highlighter-rouge"">&lt;button&gt;</code>
                    elements:
                </p>

                <div class=""row"">
                    <div class=""col-sm-6"">
                        <div class=""dropdown"">
                            <button class=""btn btn-secondary"" type=""button"" id=""dropdownMenuButton"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                Dropdown button <i class=""mdi mdi-chevron-down""></i>
                            </button>
                            <div class=""dropdown-menu""");
            WriteLiteral(@" aria-labelledby=""dropdownMenuButton"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Something else here</a>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-6"">
                        <div class=""dropdown mt-4 mt-sm-0"">
                            <a href=""#"" class=""btn btn-secondary"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                Dropdown link <i class=""mdi mdi-chevron-down""></i>
                            </a>

                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Som");
            WriteLiteral(@"ething else here</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Variant</h4>
                <p class=""card-title-desc"">The best part is you can do this with any button variant, too:</p>

                <div class=""d-flex gap-2 flex-wrap"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-primary"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Primary <i class=""mdi mdi-chevron-down""></i></button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
   ");
            WriteLiteral(@"                         <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-secondary"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Secondary <i class=""mdi mdi-chevron-down""></i></button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
          ");
            WriteLiteral(@"              <button type=""button"" class=""btn btn-success"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Success <i class=""mdi mdi-chevron-down""></i></button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-info"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Info <i class=""mdi mdi-chevron-down""></i></button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>");
            WriteLiteral(@"
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-warning"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Warning <i class=""mdi mdi-chevron-down""></i></button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-");
            WriteLiteral(@"item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-danger"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Danger <i class=""mdi mdi-chevron-down""></i></button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                </div>

            </div>
        </div>

    </div> <!-- end col -->
</div> <!-- end row -->


<div class=""row"">
    <div class=""col-xl-6"">
  ");
            WriteLiteral(@"      <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Split button dropdowns</h4>
                <p class=""card-title-desc"">The best part is you can do this with any button variant, too:</p>

                <div class=""d-flex gap-2 flex-wrap"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-primary"">Primary</button>
                        <button type=""button"" class=""btn btn-primary dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-div");
            WriteLiteral(@"ider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-secondary"">Secondary</button>
                        <button type=""button"" class=""btn btn-secondary dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                       ");
            WriteLiteral(@" </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-success"">Success</button>
                        <button type=""button"" class=""btn btn-success dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        ");
            WriteLiteral(@"<button type=""button"" class=""btn btn-info"">Info</button>
                        <button type=""button"" class=""btn btn-info dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-warning"">Warning</button>
                        <button type=""button"" class=""btn btn-warning d");
            WriteLiteral(@"ropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-danger"">Danger</button>
                        <button type=""button"" class=""btn btn-danger dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-do");
            WriteLiteral(@"wn""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div><!-- /btn-group -->
                </div>

            </div>
        </div>
    </div>

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Sizing</h4>
                <p class=""card-title-desc mb-3"">
                    Button dropdowns work with buttons of
                    all sizes, including default and split dropdown buttons.
                </p>

                <div c");
            WriteLiteral(@"lass=""d-flex gap-2 flex-wrap align-items-center"">
                    <!-- Large button groups (default and split) -->
                    <div class=""btn-group"">
                        <button class=""btn btn-primary btn-lg"" type=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            Large button <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div>
                    <div class=""btn-group"">
                        <button class=""btn btn-secondary btn-lg"" typ");
            WriteLiteral(@"e=""button"">
                            Large button
                        </button>
                        <button type=""button"" class=""btn btn-lg btn-secondary dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div>

                    <!-- Small button groups (default and split) -->
                    <div class=""btn-group"">
                        <button class=""btn btn-info btn-sm"" t");
            WriteLiteral(@"ype=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            Small button <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div>
                    <div class=""btn-group"">
                        <button class=""btn btn-secondary btn-sm"" type=""button"">
                            Small button
                        </button>
                        <button type=""button"" class=""btn btn-sm btn-secondary dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded");
            WriteLiteral(@"=""false"">
                            <i class=""mdi mdi-chevron-down""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end col -->
</div> <!-- end row -->


<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Dropup variation</h4>
                <p class=""card-title-desc"">
                    Trigger dropdown menus above elements
          ");
            WriteLiteral(@"          by adding <code class=""highlighter-rouge"">.dropup</code> to the parent
                    element.
                </p>

                <div class=""d-flex gap-2 flex-wrap"">
                    <!-- Default dropup button -->
                    <div class=""btn-group dropup"">
                        <button type=""button"" class=""btn btn-secondary"" data-bs-toggle=""dropdown"" aria-expanded=""false"">Dropup <i class=""mdi mdi-chevron-up""></i></button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div>

                    <!-- Split dropup button -->
  ");
            WriteLiteral(@"                  <div class=""btn-group dropup"">
                        <button type=""button"" class=""btn btn-secondary"">
                            Split dropup
                        </button>
                        <button type=""button"" class=""btn btn-secondary"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-up""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Separated link</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-6");
            WriteLiteral(@""">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Menu alignment</h4>
                <p class=""card-title-desc"">
                    Add <code class=""highlighter-rouge"">.dropdown-menu-end</code>
                    to a <code class=""highlighter-rouge"">.dropdown-menu</code> to right
                    align the dropdown menu.
                </p>

                <div class=""btn-group"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                        Menu is right-aligned <i class=""mdi mdi-chevron-down""></i>
                    </button>
                    <div class=""dropdown-menu dropdown-menu-end"">
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
        ");
            WriteLiteral(@"        </div>

            </div>
        </div>
    </div> <!-- end col -->
</div> <!-- end row -->


<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Dropright variation</h4>
                <p class=""card-title-desc"">
                    Trigger dropdown menus at the right of the elements by adding <code>.dropend</code> to the parent element.
                </p>

                <div class=""d-flex gap-2 flex-wrap"">
                    <!-- Default dropright button -->
                    <div class=""btn-group dropend"">
                        <button type=""button"" class=""btn btn-info waves-effect waves-light"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            Dropright <i class=""mdi mdi-chevron-right""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action<");
            WriteLiteral(@"/a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>

                    <!-- Split dropright button -->
                    <div class=""btn-group dropend"">
                        <button type=""button"" class=""btn btn-info waves-effect waves-light"">
                            Split dropend
                        </button>
                        <button type=""button"" class=""btn btn-info waves-effect waves-light dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-right""></i>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a clas");
            WriteLiteral(@"s=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Dropleft variation</h4>
                <p class=""card-title-desc"">
                    Trigger dropdown menus at the right of the elements by adding <code>.dropstart</code> to the parent element.
                </p>

                <div class=""d-flex gap-2 flex-wrap"">
                    <!-- Default dropright button -->
                    <div class=""btn-group dropstart"">
                        <button type=""button"" class=""btn btn-info waves-effect waves-light"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-chevron-left""></i> Dropleft
                        </button>
                        <div class=""dropdown-menu"">
         ");
            WriteLiteral(@"                   <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>

                    <!-- Split dropright button -->
                    <div class=""btn-group"">
                        <div class=""btn-group dropstart"">
                            <button type=""button"" class=""btn btn-info waves-effect waves-light dropdown-toggle-split"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                <i class=""mdi mdi-chevron-left""></i>
                            </button>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""#"">Action</a>
                                <a class=""dropdown-item"" href=""#"">Another action</a>
                                <a class=""dropdown-item"" href=""#"">Somethi");
            WriteLiteral(@"ng else here</a>
                            </div>
                        </div>

                        <button type=""button"" class=""btn btn-info waves-effect waves-light"">
                            Split dropstart
                        </button>
                    </div>
                </div>

            </div>
        </div>
    </div> <!-- end col -->
</div> <!-- end row -->

<!-- JAVASCRIPT -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa965847b102d945cfb8a4d906bb34fca284b38731949", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa965847b102d945cfb8a4d906bb34fca284b38732989", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa965847b102d945cfb8a4d906bb34fca284b38734029", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa965847b102d945cfb8a4d906bb34fca284b38735069", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa965847b102d945cfb8a4d906bb34fca284b38736109", async() => {
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
            WriteLiteral("\r\n\r\n\r\n<!-- App js -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa965847b102d945cfb8a4d906bb34fca284b38737176", async() => {
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
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

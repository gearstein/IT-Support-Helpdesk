#pragma checksum "C:\Users\ASUS\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\Admin\Helpdesk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2cad79adb0037365e6fa07e175beb9f904ccae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Helpdesk), @"mvc.1.0.view", @"/Views/Admin/Helpdesk.cshtml")]
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
#line 1 "C:\Users\ASUS\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2cad79adb0037365e6fa07e175beb9f904ccae3", @"/Views/Admin/Helpdesk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Helpdesk : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\Admin\Helpdesk.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_DashboardLayoutH";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--Botton Request Ticket-->
<button type=""button"" class=""btn btn-primary mb-2 Register"" data-toggle=""modal"" data-target="".bd-example-modal-lg"">Add Ticket</button>

<!--Table To Request Ticket-->
<div class=""modal fade bd-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""container"">

                <div class=""modal-header"">
                    <center>  <h5 class=""modal-title"">Form Complaint</h5>  </center>
                    <button type=""submit"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2cad79adb0037365e6fa07e175beb9f904ccae35591", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <label for=""title"">Title</label>
                        <input type=""text"" class=""form-control"" id=""title"" aria-describedby=""title"" placeholder=""Create title problem"">
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                        <div class=""invalid-feedback"">
                            Please create title.
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""message"">Message</label>
                        <textarea class=""form-control"" name=""message"" id=""message"" rows=""3""></textarea>
                        <label class=""form-label"" for=""message""></label>
                    </div>

                    <div class=""form-group"">
                        <label for=""startdate"">Complaint Time</label>
                        <input type=""datetime-loca");
                WriteLiteral("l\" class=\"form-control\" id=\"startdate\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2000, "\"", 2014, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                        <div class=""invalid-feedback"">
                            Please choose a Date.
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""starttime"">Update Time</label>
                        <input type=""datetime-local"" class=""form-control"" id=""updatedate""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2517, "\"", 2531, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                        <div class=""invalid-feedback"">
                            Please choose a time.
                        </div>
                    </div>

");
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"nik\">NIK</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"nik\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3656, "\"", 3670, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                        <div class=""invalid-feedback"">
                            Please choose a nik.
                        </div>
                    </div>

                    <div class=""form-group"">
                    </div>
                    <button class=""btn btn-primary mb-3"" id=""saved"" type=""submit"">Create Ticket</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
    </div>
</div>




<!--Datatable For Table-->
<div class=""table-responsive"">
    <table class=""table table-striped table-hover"" id=""registerData1"">
        <thead>
            <tr>
                <th scope=""col"">Title</th>
                <th scope=""col"">Complaint Time</th>
                <th scope=""col"">Update Complaint Time</th>
                <th scope=""col"">Id Ticket</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Aksi</th>
            </tr>
        </thead>
        <!--Show isi data table link to ajax js-->
        <tbody id=""showData"">
        </tbody>
    </table>
</div>


<!--Create Chart bottom table-->
<!--<div class=""row mt-4"">-->
<!-- Pie Chart -->
<!--<div class=""col-xl-5"">
    <div class=""card shadow mb-4"">-->
<!-- Card Header - Dropdown -->
<!--<div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
    <h6 class=""m-0 font-weight-bold text-primary"">Top ");
            WriteLiteral(@"Gender</h6>
</div>-->
<!-- Card Body -->
<!--<div class=""card-body"">
            <div id=""piechart""></div>
        </div>
    </div>
</div>

<div class=""col-xl-7"">
    <div class=""card shadow mb-4"">-->
<!-- Card Header - Dropdown -->
<!--<div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
    <h6 class=""m-0 font-weight-bold text-primary"">Top University</h6>
</div>-->
<!-- Card Body -->
<!--<div class=""card-body"">
                <div id=""barChart""></div>
            </div>
        </div>
    </div>
</div>-->


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2cad79adb0037365e6fa07e175beb9f904ccae312182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("\r\n\r\n");
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

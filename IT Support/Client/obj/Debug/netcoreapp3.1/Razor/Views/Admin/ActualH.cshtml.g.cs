#pragma checksum "I:\METRODATA\PROJECT\Tugas\git-hub\IT-Support-Helpdesk\IT Support\Client\Views\Admin\ActualH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "233adda3d523986565ea53eb139a8dcb90276e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ActualH), @"mvc.1.0.view", @"/Views/Admin/ActualH.cshtml")]
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
#line 1 "I:\METRODATA\PROJECT\Tugas\git-hub\IT-Support-Helpdesk\IT Support\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\METRODATA\PROJECT\Tugas\git-hub\IT-Support-Helpdesk\IT Support\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233adda3d523986565ea53eb139a8dcb90276e26", @"/Views/Admin/ActualH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ActualH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DashboardHelpdesk.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "I:\METRODATA\PROJECT\Tugas\git-hub\IT-Support-Helpdesk\IT Support\Client\Views\Admin\ActualH.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_DashboardLayoutH";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Ticket Table</h1>
</div>

<!--Modal Detail-->
<div class=""modal fade"" id=""getrequest"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Detail Tiket Komplain</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""idticket"" class=""col-form-label"">ID Ticket :</label>
                    <h3 id=""IDTicket""></h3>
                </div>
                <div class=""form-group"">
                    <label for=""title"" class=""col-form-label"">Title :</label>
                 ");
            WriteLiteral(@"   <h3 id=""Title""></h3>
                </div>
                <div class=""form-group"">
                    <label for=""startdate"" class=""col-form-label"">Start Date :</label>
                    <h3 id=""StartDate""></h3>
                </div>
                <div class=""form-group"">
                    <label for=""updatedate"" class=""col-form-label"">Update Date :</label>
                    <h3 id=""UpdateDate""></h3>
                </div>
                <div class=""form-group"">
                    <label for=""detail"" class=""col-form-label"">Detail :</label>
                    <h3 id=""Detail""></h3>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<!--Datatable For Table-->
<div class=""table-responsive"">
    <table class=""table table-striped table-hover"" id=""registerData"">
        <thead>
         ");
            WriteLiteral(@"   <tr>
                <th scope=""col"">No</th>
                <th scope=""col"">Id Ticket</th>
                <th scope=""col"">title</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Complaint Time</th>
                <th scope=""col"">Update Complaint Time</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Aksi</th>
                <th scope=""col"">No. Telp</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Message</th>
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
    <h6 class=""m-0 font-weight-bold text-primary"">Top");
            WriteLiteral(@" Gender</h6>
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
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "233adda3d523986565ea53eb139a8dcb90276e268099", async() => {
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

#pragma checksum "C:\Users\badan penghubung\OneDrive\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\Admin\Actual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cfe13239036e9e169632c3674af4c528ff0a1fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Actual), @"mvc.1.0.view", @"/Views/Admin/Actual.cshtml")]
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
#line 1 "C:\Users\badan penghubung\OneDrive\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\badan penghubung\OneDrive\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cfe13239036e9e169632c3674af4c528ff0a1fc", @"/Views/Admin/Actual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Actual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DashboardAdmin.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\badan penghubung\OneDrive\Documents\GitHub\IT-Support-Helpdesk\IT Support\Client\Views\Admin\Actual.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_DashboardLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Ticket Table</h1>

</div>


<!--Botton Request Ticket-->
<button type=""button"" class=""btn btn-primary mb-2"" data-toggle=""modal"" data-target="".bd-example-modal-lg"">Add Complaint</button>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cfe13239036e9e169632c3674af4c528ff0a1fc5814", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <label for=""title"">Title</label>
                        <input type=""text"" class=""form-control"" id=""title"" aria-describedby=""title"" placeholder=""Create title problem"" required>
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                        <div class=""invalid-feedback"">
                            Please create title !
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""message"">Message</label>
                        <textarea class=""form-control"" name=""message"" id=""message"" rows=""3"" required></textarea>
                        <div class=""valid-feedback"">
                            Looks good!
                        </div>
                        <div class=""invalid-feedback"">
                            Please create message !
                ");
                WriteLiteral(@"        </div>

                        <label class=""form-label"" for=""message""></label>
                    </div>
                    <div class=""form-group"">
                    </div>
                    <button class=""btn btn-primary mb-3"" id=""submitRequest"" type=""submit"">Create</button>
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




<!-- Large modal -->

<div class=""modal fade bd-example-modal-lg"" id=""getdetail"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">


        <div class=""modal-content"">
            <div class=""modal-header text-center text-black"">
                <h5 class=""modal-title"">Complaint Ticket Detail</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

                <section class=""row"">
                    <div class=""col-lg"">
                        <div class=""card"">
                            <div class=""card-header text-center"">

                                <h4> <span class=""text-primary""><i class=""bi bi-person""></i></span>Complaint Data</h4>
                   ");
            WriteLiteral(@"         </div>
                            <div class=""card-body"">
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">Id Ticket</div>
                                    <div class=""col fw-bold profil"" id=""idTicket""></div>
                                </div>
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">Title</div>
                                    <div class=""col fw-bold profil"" id=""title1""></div>
                                </div>
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">Complain Time</div>
                                    <div class=""col fw-bold profil"" id=""startDate""></div>
                                </div>
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">Complain Update</div>
                                    <di");
            WriteLiteral(@"v class=""col fw-bold profil"" id=""updateDate""></div>
                                </div>
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">Status</div>
                                    <div class=""col fw-bold profil"" id=""detail""></div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg"">
                        <div class=""card"">
                            <div class=""card-header text-center"">
                                <h4> <span class=""text-primary""><i class=""bi bi-briefcase""></i></span>Personal Data</h4>
                            </div>
                            <div class=""card-body"">
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">Name</div>
                                    <div class=""col fw-bold profil"" id=""firstname""></div>");
            WriteLiteral(@"
                                </div>
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">No Telp</div>
                                    <div class=""col fw-bold profil"" id=""phoneNumber""></div>
                                </div>
                                <div class=""row p-2"">
                                    <div class=""col-lg-6"">Email</div>
                                    <div class=""col fw-bold profil"" id=""email""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>


                <div class=""container mt-3"">
                    <p class=""text-justify"">Message<br><span class=""profil text-break"" id=""message1""></span></p>
                </div>

            </div>

            <div class=""modal-footer"">

            </div>

        </div>
    </div>
</div>



<!--Datatable For Table-->");
            WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table table-striped table-hover"" id=""registerData"">
        <thead>
            <tr>
                <th scope=""col"">No</th>
                <th scope=""col"">Id Ticket</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Complaint Time</th>
                <th scope=""col"">Update Complaint Time</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Action</th>

            </tr>
        </thead>
        <!--Show isi data table link to ajax js-->
        <tbody id=""showData"">
        </tbody>
    </table>
</div>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cfe13239036e9e169632c3674af4c528ff0a1fc14024", async() => {
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

#pragma checksum "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e118ad186bedbfeb147cb84d3a50bf4545503b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pay_Payslip), @"mvc.1.0.view", @"/Views/Pay/Payslip.cshtml")]
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
#line 1 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\_ViewImports.cshtml"
using Paycompute;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\_ViewImports.cshtml"
using Paycompute.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e118ad186bedbfeb147cb84d3a50bf4545503b9", @"/Views/Pay/Payslip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b159a1e9feef9039727131d2d4070f602f1724", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pay_Payslip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentRecordDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
   ViewBag.Title = "Payslip";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
   Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e118ad186bedbfeb147cb84d3a50bf4545503b94401", async() => {
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

<div class=""row"">
    <div class=""col-md-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""container-fluid d-flex justify-content-between"">
                    <div class=""col-md-3 pl-0"">
                        <p class=""mt-5 mb-2""><b>PayCompute Ltd</b></p>
                        <p>11 Downing Street<br />London<br />W1C 2XB</p>
                    </div>
                    <div class=""col-md-3 pr-0"">
                        <p class=""mt-5 mb-2 text-right""><b>Pay Date: ");
#nullable restore
#line 19 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                                                                Write(Model.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n                        <p class=\"text-right\">Tax Code: ");
#nullable restore
#line 20 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                                                   Write(Model.TaxCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />Year: ");
#nullable restore
#line 20 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                                                                             Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />HMRC</p>\n                    </div>\n                </div><br /><br />\n\n                <div class=\"col-md-12 row\">\n                    <div class=\"col-md-8\"><h5>Employee\'s Name : ");
#nullable restore
#line 25 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                                                           Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></div>\n                    <div class=\"col-md-4\"><h5>National Insurance Number : ");
#nullable restore
#line 26 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                                                                     Write(Model.NiNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5></div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-12 table-responsive-md"">
                    <table class=""table table-striped"">
                        <thead class=""table-dark"">
                            <tr>
                                <th>Earnings</th>
                                <th>Hours</th>
                                <th>Rates</th>
                                <th>Amount</th>
                                <th>Deductions</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td><b>Basic :</b></td>
                                <td>");
#nullable restore
#line 46 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.ContractualHours.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 47 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.HourlyRate.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 48 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.ContractualEarnings.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td><b>Tax :</b></td>\n                                <td>");
#nullable restore
#line 50 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.Tax.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td><b>Overtime :</b></td>\n                                <td>");
#nullable restore
#line 54 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeHours.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 55 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeRate.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 56 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.OvertimeEarnings.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td><b>NIC :</b></td>\n                                <td>");
#nullable restore
#line 58 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.NIC.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>Union :</b></td>
                                <td>");
#nullable restore
#line 66 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.UnionFee.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><b>SLC :</b></td>
                                <td>");
#nullable restore
#line 74 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.SLC.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td><b>Total :</b></td>\n                                <td>");
#nullable restore
#line 78 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.HoursWorked);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td></td>\n                                <td>");
#nullable restore
#line 80 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.TotalEarnings.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td></td>\n                                <td>");
#nullable restore
#line 82 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                               Write(Model.TotalDeduction.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td class=""table-dark""><b>NET PAY :</b></td>
                                <td class=""table-dark"">");
#nullable restore
#line 92 "C:\Users\hikmatdell\Desktop\Paycompute-main\Paycompute-main\Paycompute\Views\Pay\Payslip.cshtml"
                                                  Write(Model.NetPayment.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n                        </tfoot>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentRecordDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d2b30af2411453012af43abf0144177d246e4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inbox_Index), @"mvc.1.0.view", @"/Views/Inbox/Index.cshtml")]
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
#line 1 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d2b30af2411453012af43abf0144177d246e4f", @"/Views/Inbox/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626a901b78c9ba6ddfd16d789cbc1ba6b4a4e185", @"/Views/_ViewImports.cshtml")]
    public class Views_Inbox_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AtoVen_MVC_UI.Models.Inbox>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/custom/modals/create-app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/custom/modals/upgrade-plan.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "_AdminLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--begin::Inbox App - Messages -->
<div class=""d-flex flex-column flex-lg-row"">
    <!--begin::Sidebar-->
    <!--end::Sidebar-->
    <!--begin::Content-->
    <div class=""flex-lg-row-fluid ms-lg-7 ms-xl-10"">
        <!--begin::Card-->
        <div class=""card"">
            <div class=""card-header align-items-center py-5 gap-2 gap-md-5"">
                <!--begin::Actions-->
                <div class=""card-title"">
                    <h3 class=""m-0 text-gray-800"">Inbox</h3>
                </div>
                <div class=""d-flex flex-wrap gap-1"">
                    <!--begin::Checkbox-->
                    <!--end::Checkbox-->
                    <!--begin::Filter-->
                    <!--end::Filter-->
                    <!--begin::Reload-->
                    <!--end::Reload-->
                    <!--begin::Archive-->
                    <!--end::Archive-->
                    <!--begin::Delete-->
                    <!--end::Delete-->
                    <!--begin::Mark");
            WriteLiteral(@" as read-->
                    <!--end::Mark as read-->
                    <!--begin::Move-->
                    <!--end::Move-->
                </div>
                <!--end::Actions-->
                <!--begin::Pagination-->
                <div class=""d-flex align-items-center flex-wrap gap-2"">
                    <!--begin::Search-->
                    <div class=""d-flex align-items-center position-relative"">
                        <!--begin::Svg Icon | path: icons/duotune/general/gen021.svg-->
                        <span class=""svg-icon svg-icon-2 position-absolute ms-4"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                <rect opacity=""0.5"" x=""17.0365"" y=""15.1223"" width=""8.15546"" height=""2"" rx=""1"" transform=""rotate(45 17.0365 15.1223)"" fill=""black"" />
                                <path d=""M11 19C6.55556 19 3 15.4444 3 11C3 6.55556 6.55556 3 11 3C15.4444 3 19 6.55556 19 11C1");
            WriteLiteral(@"9 15.4444 15.4444 19 11 19ZM11 5C7.53333 5 5 7.53333 5 11C5 14.4667 7.53333 17 11 17C14.4667 17 17 14.4667 17 11C17 7.53333 14.4667 5 11 5Z"" fill=""black"" />
                            </svg>
                        </span>
                        <!--end::Svg Icon-->
                        <input type=""text"" data-kt-inbox-listing-filter=""search"" class=""form-control form-control-sm form-control-solid mw-100 min-w-150px min-w-md-200px ps-12"" placeholder=""Search Inbox"" />
                    </div>
                    <!--end::Search-->
                    <!--begin::Sort-->
                    <!--end::Sort-->
                    <!--begin::Settings-->
                    <!--end::Settings-->
                </div>
                <!--end::Pagination-->
            </div>
            <div class=""col-lg-12"">

                <div class=""card-body p-0"">
                    <!--begin::Table-->
                    <table class=""table table-row-dashed "" id=""kt_inbox_listing"">
                   ");
            WriteLiteral(@"     <!--begin::Table head-->
                        <thead class=""d-none"">
                            <tr>

                                <th>Actions</th>
                                <th>Author</th>
                                <th>Title</th>
                                <th>Date</th>
                            </tr>
                        </thead>
                        <!--end::Table head-->
                        <!--begin::Table body-->
                        <tbody>
");
#nullable restore
#line 80 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr>


                                    <!--begin::Author-->
                                    <td class=""w-200px w-md-150px m-10"">

                                        <!--begin::Avatar-->
                                        <div class=""symbol symbol-35px px-8 me-3 m-2"">
                                            <div>
                                                <span class=""text-danger""> ");
#nullable restore
#line 91 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.companyRegisterNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </div>
                                        </div>


                                    </td>
                                    <!--end::Author-->
                                    <!--begin::Title-->
                                    <td>
                                        <div class=""text-dark m-1 p-1"">
                                            <!--begin::Heading-->

                                            <span>You have a vendor request approval from:  ");
#nullable restore
#line 103 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
                                                                                       Write(Html.DisplayFor(modelItem => item.companyName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                                            <!--end::Heading-->
                                        </div>

                                    </td>
                                    <!--end::Title-->
                                    <!--begin::Date-->
                                    <td class=""w-100px text-end fs-7 p-6"">
                                        <span class=""fw-bold"">  ");
#nullable restore
#line 112 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
                                                           Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", item.recordDate)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
                                    </td>

                                    <td class=""w-250px text-left"">
                                        <!--begin::Star-->
                                        <!--begin::Svg Icon | path: icons/duotune/general/gen029.svg-->
");
            WriteLiteral("\r\n                                        <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("href", " href=\"", 5866, "\"", 5950, 1);
#nullable restore
#line 120 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
WriteAttributeValue("", 5873, Url.Action("Proceed", "Inbox",new { id = item.id, companyID=item.companyID}), 5873, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Proceed\r\n                                        </a>\r\n");
#nullable restore
#line 123 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
                                         if (item.isDuplicateEntry)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-sm btn-danger getAllDUp\" id=\"aDuplicate\"");
            BeginWriteAttribute("title", " title=\"", 6267, "\"", 6299, 3);
#nullable restore
#line 125 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
WriteAttributeValue("", 6275, item.companyID, 6275, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6290, "-", 6290, 1, true);
#nullable restore
#line 125 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
WriteAttributeValue("", 6291, item.id, 6291, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                Duplicate\r\n                                            </a>\r\n");
#nullable restore
#line 128 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                    </td>\r\n                                    <!--end::Date-->\r\n                                </tr>\r\n");
#nullable restore
#line 135 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                        <!--end::Table body-->
                    </table>
                    <!--end::Table-->
                </div>
            </div>
            <!--end::Card-->
        </div>
        <!--end::row-->
    </div>
    <!--end::Content-->
</div>
<!--end::Inbox App - Messages -->
<!-- The Modal -->
<style>
    .modal-lg {
        max-width: 90% !important;
    }
</style>
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">

            <!-- Modal Header -->
");
            WriteLiteral("\r\n            <!-- Modal body -->\r\n            <div class=\"modal-body\" id=\'myModalContent\'>\r\n\r\n            </div>\r\n\r\n            <!-- Modal footer -->\r\n");
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0d2b30af2411453012af43abf0144177d246e4f14466", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0d2b30af2411453012af43abf0144177d246e4f15566", async() => {
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
                WriteLiteral(@"
    <script>
        var ajaxCallURL = '/Inbox/Duplicate';

        $(function () {
            $("".getAllDUp"").click(function () {
                var $buttonClicked = $(this);
                var id = $(this).attr('title');
                var options = {
                    ""backdrop"": ""static"",
                    keyboard: true
                };
                $.ajax({
                    type: ""GET"",
                    url: ajaxCallURL,
                    data: ""id="" + id,
                    contentType: ""application/json; charset=utf-8"",
                    datatype: ""json"",
                    success: function (data) {
                        debugger;
                        $('#myModalContent').html(data);
                        $('#myModal').modal(options);
                        $('#myModal').modal('show');
                    },
                    error: function () {
                        alert(""Content load failed."");
                    }
                ");
                WriteLiteral("});\r\n            });\r\n\r\n            $(\"#closbtn\").click(function () {\r\n                debugger;\r\n                $(\'#myModal\').modal(\'hide\');\r\n            });\r\n        });\r\n\r\n       \r\n    </script>\r\n\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AtoVen_MVC_UI.Models.Inbox>> Html { get; private set; }
    }
}
#pragma warning restore 1591

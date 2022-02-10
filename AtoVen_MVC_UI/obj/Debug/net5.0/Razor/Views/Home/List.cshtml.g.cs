#pragma checksum "F:\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f713e9bf2dfbff61721cf33f74b3b95dd070db1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#line 1 "F:\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f713e9bf2dfbff61721cf33f74b3b95dd070db1", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626a901b78c9ba6ddfd16d789cbc1ba6b4a4e185", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/global/plugins.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/scripts.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
  
    ViewBag.Title = "Users List";
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
                <div class=""d-flex flex-wrap gap-1"">
                    <a href=""/Home/Create"" class=""btn btn-primary"">Create</a>
                </div>
                <!--end::Actions-->
                <!--begin::Pagination-->
                <div class=""d-flex align-items-center flex-wrap gap-2"">
                    <!--begin::Search-->
                    <div class=""d-flex align-items-center position-relative"">
                        <!--begin::Svg Icon | path: icons/duotune/general/gen021.svg-->
                        <span class=""svg-icon svg-icon-2 position-absolute ms-4"">
                            <sv");
            WriteLiteral(@"g xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                <rect opacity=""0.5"" x=""17.0365"" y=""15.1223"" width=""8.15546"" height=""2"" rx=""1"" transform=""rotate(45 17.0365 15.1223)"" fill=""black"" />
                                <path d=""M11 19C6.55556 19 3 15.4444 3 11C3 6.55556 6.55556 3 11 3C15.4444 3 19 6.55556 19 11C19 15.4444 15.4444 19 11 19ZM11 5C7.53333 5 5 7.53333 5 11C5 14.4667 7.53333 17 11 17C14.4667 17 17 14.4667 17 11C17 7.53333 14.4667 5 11 5Z"" fill=""black"" />
                            </svg>
                        </span>
                        <!--end::Svg Icon-->
                        <input type=""text"" data-kt-inbox-listing-filter=""search"" class=""form-control form-control-sm form-control-solid mw-100 min-w-150px min-w-md-200px ps-12"" placeholder=""Search Inbox"" />
                    </div>
                </div>
                <!--end::Pagination-->
            </div>
            <div class=""card-body"">
       ");
            WriteLiteral(@"         <!--begin::Table-->
                <table class=""table table-row-dashed "" id=""role_listing"">
                    <!--begin::Table head-->
                    <thead>
                        <tr>
                            <th>Company Id</th>
                            <th>Company Name</th>
                            <th>CR Number</th>
                            <th>VAT No</th>
                            <th>Email</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <!--end::Table head-->
                    <!--begin::Table body-->
                    <tbody class=""InfoTBody"">
                    </tbody>
                    <!--end::Table body-->
                </table>
                <!--end::Table-->
            </div>
        </div>
        <!--end::Card-->
    </div>
    <!--end::Content-->
</div>
<!--end::Inbox App - Messages -->
<script>var hostUrl = ""~/assets/"";</script>
<!--begin::J");
            WriteLiteral("avascript-->\r\n<!--begin::Global Javascript Bundle(used by all pages)-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f713e9bf2dfbff61721cf33f74b3b95dd070db17279", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f713e9bf2dfbff61721cf33f74b3b95dd070db18318", async() => {
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
    $(document).ready(function () {
        var urlRequest = ""/Home/GetList""
        $.post(urlRequest, function (data) { // do ajax getrequest
            console.log(data);
            var rows = '';
            $.each(data, function (index, item) { //build tbody content using each function
               
                rows += ""<tr>"";
                rows += ""<td>"" + item.id + ""</td>"";
                rows += ""<td>"" + item.companyName + ""</td>"";
                rows += ""<td>"" + item.commercialRegistrationNo + ""</td>"";
                rows += ""<td>"" + item.vatNo + ""</td>"";
                rows += ""<td>"" + item.email  + ""</td>"";
                rows += ""<td><a class='btn btn-sm btn-primary' href='/Home/Edit/"" + item.id + ""'>Edit</a></td>"";
                rows += ""</tr>"";
            });
            $('.InfoTBody').html(rows);
        }).done(function () {
            $('#role_listing').DataTable();
        })
    });

</script>
");
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

#pragma checksum "C:\Users\habee\Source\Repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0854a448791e80f7476f93e9ecf1f9c2c001266"
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
#line 1 "C:\Users\habee\Source\Repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\habee\Source\Repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0854a448791e80f7476f93e9ecf1f9c2c001266", @"/Views/Inbox/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626a901b78c9ba6ddfd16d789cbc1ba6b4a4e185", @"/Views/_ViewImports.cshtml")]
    public class Views_Inbox_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/../demo4/apps/inbox/reply.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex align-items-center text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\habee\Source\Repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Inbox\Index.cshtml"
  
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
                    <!--begin::Mark as read-->
                    <!--end::Mark as read-->
                    <!--begin::Move-->
                    <!--end::");
            WriteLiteral(@"Move-->
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
                                <path d=""M11 19C6.55556 19 3 15.4444 3 11C3 6.55556 6.55556 3 11 3C15.4444 3 19 6.55556 19 11C19 15.4444 15.4444 19 11 19ZM11 5C7.53333 5 5 7.53333 5 11C5 14.4667 7.53333 17 11 17C14.4667 17 17 14.4667 17 11C17 7.53333 14.4");
            WriteLiteral(@"667 5 11 5Z"" fill=""black"" />
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
            <div class=""card-body p-0"">
                <!--begin::Table-->
                <table class=""table table-row-dashed "" id=""kt_inbox_listing"">
                    <!--begin::Table head-->
                    <thead class=""d-none"">
                        <tr>

                            <th>Actions</th>
                            <t");
            WriteLiteral(@"h>Author</th>
                            <th>Title</th>
                            <th>Date</th>
                        </tr>
                    </thead>
                    <!--end::Table head-->
                    <!--begin::Table body-->
                    <tbody>
                        <tr>


                            <!--begin::Author-->
                            <td class=""w-150px w-md-175px m-10"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0854a448791e80f7476f93e9ecf1f9c2c0012668120", async() => {
                WriteLiteral(@"
                                    <!--begin::Avatar-->
                                    <div class=""symbol symbol-35px me-3 m-2"">
                                        <div class=""symbol-label bg-light-danger"">
                                            <span class=""text-danger"">M</span>
                                        </div>
                                    </div>
                                    <!--end::Avatar-->
                                    <!--begin::Name-->
                                    <span class=""fw-bold"">Melody Macy</span>
                                    <!--end::Name-->
                                ");
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
                            </td>
                            <!--end::Author-->
                            <!--begin::Title-->
                            <td>
                                <div class=""text-dark mb-1"">
                                    <!--begin::Heading-->
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0854a448791e80f7476f93e9ecf1f9c2c00126610276", async() => {
                WriteLiteral(@"
                                        <span class=""fw-bolder"">Digital PPV Customer Confirmation</span>
                                        <span class=""fw-bolder d-none d-md-inine"">-</span>
                                        <span class=""d-none d-md-inine text-muted"">Thank you for ordering UFC 240 Holloway vs Edgar Alternate camera angles...</span>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <!--end::Heading-->
                                </div>

                            </td>
                            <!--end::Title-->
                            <!--begin::Date-->
                            <td class=""w-100px text-end fs-7 pe-9"">
                                <span class=""fw-bold"">8:30 PM</span>
                            </td>

                            <td>
                                <!--begin::Star-->
                                <a href=""#"" data-bs-toggle=""tooltip"" title=""Proceed"">
                                    <!--begin::Svg Icon | path: icons/duotune/general/gen029.svg-->
                                    <input type=""button"" value=""Proceed"" class=""btn btn-success  btn-sm w-10 p-3 "" />


                                    <!--end::Svg Icon-->
                                </a>
                                <!--end::Star-->
                                <!--begin::Important-->
                 ");
            WriteLiteral(@"               <a href=""#"" data-bs-toggle=""tooltip"" data-bs-placement=""right"" title=""Duplicate"">
                                    <!--begin::Svg Icon | path: icons/duotune/general/gen056.svg-->
                                    <input type=""button"" value=""Duplicate"" class=""btn btn-primary  btn-sm w-10 p-3"" />
                                    <!--end::Svg Icon-->
                                </a>
                                <!--end::Important-->
                            </td>
                            <!--end::Date-->
                        </tr>
                        <tr>

                            <!--begin::Author-->
                            <td class=""w-150px w-md-175px"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0854a448791e80f7476f93e9ecf1f9c2c00126613681", async() => {
                WriteLiteral(@"
                                    <!--begin::Avatar-->
                                    <div class=""symbol symbol-35px me-3 m-2"">
                                        <span class=""symbol-label"" style=""background-image:url(~/assets/media/avatars/300-1.jpg)""></span>
                                    </div>
                                    <!--end::Avatar-->
                                    <!--begin::Name-->
                                    <span class=""fw-bold"">Max Smith</span>
                                    <!--end::Name-->
                                ");
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
                            </td>
                            <!--end::Author-->
                            <!--begin::Title-->
                            <td>
                                <div class=""text-dark mb-1"">
                                    <!--begin::Heading-->
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0854a448791e80f7476f93e9ecf1f9c2c00126615763", async() => {
                WriteLiteral(@"
                                        <span class=""fw-bolder"">Your iBuy.com grocery shopping confirmation</span>
                                        <span class=""fw-bolder d-none d-md-inine"">-</span>
                                        <span class=""d-none d-md-inine text-muted"">Please make sure that you have one of the following cards with you when we deliver your order...</span>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <!--end::Heading-->
                                </div>
                            </td>
                            <!--end::Title-->
                            <!--begin::Date-->
                            <td class=""w-100px text-end fs-7 pe-9"">
                                <span class=""fw-bold"">day ago</span>
                            </td>
                            <!--end::Date-->
                            <td>
                                <!--begin::Star-->
                                <a href=""#"" data-bs-toggle=""tooltip"" title=""Proceed"">
                                    <!--begin::Svg Icon | path: icons/duotune/general/gen029.svg-->
                                    <input type=""button"" value=""Proceed"" class=""btn btn-success  btn-sm w-10 p-3 "" />


                                    <!--end::Svg Icon-->
                                </a>
                                <!--end::Star-->
                                ");
            WriteLiteral(@"<!--begin::Important-->
                                <a href=""#"" data-bs-toggle=""tooltip"" data-bs-placement=""right"" title=""Duplicate"">
                                    <!--begin::Svg Icon | path: icons/duotune/general/gen056.svg-->
                                    <input type=""button"" value=""Duplicate"" class=""btn btn-primary btn-sm w-10 p-3"" />
                                    <!--end::Svg Icon-->
                                </a>
                                <!--end::Important-->
                            </td>

                        </tr>
                        <tr>


                            <!--begin::Author-->
                            <td class=""w-150px w-md-175px"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0854a448791e80f7476f93e9ecf1f9c2c00126619198", async() => {
                WriteLiteral(@"
                                    <!--begin::Avatar-->
                                    <div class=""symbol symbol-35px me-3 m-2"">
                                        <span class=""symbol-label"" style=""background-image:url(~/assets/media/avatars/300-5.jpg)""></span>
                                    </div>
                                    <!--end::Avatar-->
                                    <!--begin::Name-->
                                    <span class=""fw-bold"">Sean Bean</span>
                                    <!--end::Name-->
                                ");
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
                            </td>
                            <!--end::Author-->
                            <!--begin::Title-->
                            <td>
                                <div class=""text-dark mb-1"">
                                    <!--begin::Heading-->
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0854a448791e80f7476f93e9ecf1f9c2c00126621280", async() => {
                WriteLiteral(@"
                                        <span class=""fw-bolder"">Your Order #224820998666029 has been Confirmed</span>
                                        <span class=""fw-bolder d-none d-md-inine"">-</span>
                                        <span class=""d-none d-md-inine text-muted"">Your Order #224820998666029 has been placed on Saturday, 29 June</span>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <!--end::Heading-->
                                </div>
                            </td>
                            <!--end::Title-->
                            <!--begin::Date-->
                            <td class=""w-100px text-end fs-7 pe-9"">
                                <span class=""fw-bold text-muted"">11:20 PM</span>
                            </td>
                            <!--end::Date-->
                            <td>
                                <!--begin::Star-->
                                <a href=""#"" data-bs-toggle=""tooltip"" title=""Proceed"">
                                    <!--begin::Svg Icon | path: icons/duotune/general/gen029.svg-->
                                    <input type=""button"" value=""Proceed"" class=""btn btn-success  btn-sm w-10 p-3"" />


                                    <!--end::Svg Icon-->
                                </a>
                                <!--end::Star-->
                     ");
            WriteLiteral(@"           <!--begin::Important-->
                                <a href=""#"" data-bs-toggle=""tooltip"" data-bs-placement=""right"" title=""Duplicate"">
                                    <!--begin::Svg Icon | path: icons/duotune/general/gen056.svg-->
                                    <input type=""button"" value=""Duplicate"" class=""btn btn-primary btn-sm w-10 p-3"" />
                                    <!--end::Svg Icon-->
                                </a>
                                <!--end::Important-->
                            </td>

                        </tr>

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

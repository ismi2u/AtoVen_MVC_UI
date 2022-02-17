#pragma checksum "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48243a3fd51264a1f15271646948de6cdff5daac"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48243a3fd51264a1f15271646948de6cdff5daac", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626a901b78c9ba6ddfd16d789cbc1ba6b4a4e185", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AtoVen_MVC_UI.Models.propVendor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
  
    ViewBag.Title = "Vendors List";
    Layout = "_ApproverLayout";


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
                    <h3>Approved Vendor List</h3>
                </div>
                <!--end::Actions-->
                <!--begin::Pagination-->
                <div class=""d-flex align-items-center flex-wrap gap-2"">
                    <!--begin::Search-->
                    <div class=""d-flex align-items-center position-relative"">
                        <!--begin::Svg Icon | path: icons/duotune/general/gen021.svg-->
                        <span class=""svg-icon svg-icon-2 position-absolute ms-4"">
                            <svg xmlns=""http://www.w3.org/2");
            WriteLiteral(@"000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                <rect opacity=""0.5"" x=""17.0365"" y=""15.1223"" width=""8.15546"" height=""2"" rx=""1"" transform=""rotate(45 17.0365 15.1223)"" fill=""black"" />
                                <path d=""M11 19C6.55556 19 3 15.4444 3 11C3 6.55556 6.55556 3 11 3C15.4444 3 19 6.55556 19 11C19 15.4444 15.4444 19 11 19ZM11 5C7.53333 5 5 7.53333 5 11C5 14.4667 7.53333 17 11 17C14.4667 17 17 14.4667 17 11C17 7.53333 14.4667 5 11 5Z"" fill=""black"" />
                            </svg>
                        </span>
                        <!--end::Svg Icon-->
                        <input type=""text"" id=""VendorList"" data-kt-inbox-listing-filter=""search"" class=""form-control form-control-sm form-control-solid mw-100 min-w-150px min-w-md-200px ps-12"" placeholder=""Search Inbox"" />
                    </div>
                </div>
                <!--end::Pagination-->
            </div>
            <div class=""card-body"">
                <!-");
            WriteLiteral(@"-begin::Table-->
                <table class=""table table-row-dashed "" id=""kt_inbox_listing"">
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
");
#nullable restore
#line 57 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td> ");
#nullable restore
#line 60 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
                            Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                            <td> ");
#nullable restore
#line 61 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
                            Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 62 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
                            Write(Html.DisplayFor(modelItem => item.CommercialRegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 63 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
                            Write(Html.DisplayFor(modelItem => item.VATNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 64 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
                            Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3442, "\"", 3497, 1);
#nullable restore
#line 65 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
WriteAttributeValue("", 3449, Url.Action("Edit", "Home", new { id = item.Id}), 3449, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Edit\" title=\"Edit\"><i class=\"bi bi-pencil\"></i></a>&nbsp;&nbsp;&nbsp;<a");
            BeginWriteAttribute("class", " class=\'", 3575, "\'", 3583, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3584, "\"", 3642, 1);
#nullable restore
#line 65 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
WriteAttributeValue("", 3591, Url.Action("Detail", "Home", new { id = item.Id }), 3591, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"View\" title=\"View\"><i class=\"bi bi-eye\"></i></a>&nbsp;</td>\r\n                           \r\n                        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\habee\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Home\List.cshtml"
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
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
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        //$(document).ready(function () {
        //    var urlRequest = ""/Home/GetList""
        //    $.post(urlRequest, function (data) { // do ajax getrequest
        //        console.log(data);
        //        var rows = '';
        //        $.each(data, function (index, item) { //build tbody content using each function

        //            rows += ""<tr>"";
        //            rows += ""<td>"" + item.id + ""</td>"";
        //            rows += ""<td>"" + item.companyName + ""</td>"";
        //            rows += ""<td>"" + item.commercialRegistrationNo + ""</td>"";
        //            rows += ""<td>"" + item.vatNo + ""</td>"";
        //            rows += ""<td>"" + item.email + ""</td>"";
        //            rows += ""<td><a class='btn btn-sm btn-primary' href='/Home/Edit/"" + item.id + ""'>Edit</a>&nbsp;<a class='btn btn-sm btn-primary' href='/Home/Detail/"" + item.id + ""'>View</a>&nbsp;</td>"";
        //            rows += ""</tr>"";
        //        });
        //        $('.In");
                WriteLiteral("foTBody\').html(rows);\r\n        //    }).done(function () {\r\n        //        $(\'#kt_inbox_listing\').DataTable();\r\n        //    })\r\n        //});\r\n\r\n\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AtoVen_MVC_UI.Models.propVendor>> Html { get; private set; }
    }
}
#pragma warning restore 1591

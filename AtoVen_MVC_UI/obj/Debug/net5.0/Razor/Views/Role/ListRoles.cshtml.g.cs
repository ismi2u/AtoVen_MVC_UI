#pragma checksum "C:\Users\FAKEER\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Role\ListRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67aee3ae40c857613cb4dc4724b160defc3ff902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_ListRoles), @"mvc.1.0.view", @"/Views/Role/ListRoles.cshtml")]
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
#line 1 "C:\Users\FAKEER\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FAKEER\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\_ViewImports.cshtml"
using AtoVen_MVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67aee3ae40c857613cb4dc4724b160defc3ff902", @"/Views/Role/ListRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"626a901b78c9ba6ddfd16d789cbc1ba6b4a4e185", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_ListRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\FAKEER\source\repos\AtoVen_MVC_UI\AtoVen_MVC_UI\Views\Role\ListRoles.cshtml"
  
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
                   
                </div>
                <!--end::Actions-->
                <!--begin::Pagination-->
                <div class=""d-flex align-items-center flex-wrap gap-2"">
                    <!--begin::Search-->
                    <div class=""d-flex align-items-center position-relative"">
                        <!--begin::Svg Icon | path: icons/duotune/general/gen021.svg-->
                        <span class=""svg-icon svg-icon-2 position-absolute ms-4"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24");
            WriteLiteral(@""" viewBox=""0 0 24 24"" fill=""none"">
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
            <div class=""card-body p-0"">
                <!--begin::Table-->
                <table c");
            WriteLiteral(@"lass=""table table-row-dashed "" id=""kt_inbox_listing"">
                    <!--begin::Table head-->
                    <thead class=""d-none"">
                        <tr>
                            <th>Role Name</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <!--end::Table head-->
                    <!--begin::Table body-->
                    <tbody>
                        

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

<script>
    $(function () {
        
        $.ajax({
            type: ""POST"",
            url: ""/Role/ListRoles"",
            data: '{}',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: functio");
            WriteLiteral(@"n (response) {
                console.log(response)
                
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
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

#pragma checksum "F:\PornHub\WebSiteHocTap\WebApp\Areas\Admin\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7665ed1a6c604a202bad74e2e71796c19f8eec45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__MenuPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_MenuPartial.cshtml")]
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
#line 1 "F:\PornHub\WebSiteHocTap\WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7665ed1a6c604a202bad74e2e71796c19f8eec45", @"/Areas/Admin/Views/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157a527780a79be07ea5f9836751adb2bedf89d1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

        <!-- Sidebar - Brand -->
        <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
            <div class=""sidebar-brand-icon rotate-n-15"">
                <i class=""fas fa-laugh-wink""></i>
            </div>
            <div class=""sidebar-brand-text mx-3""> Admin Web </div>
        </a>

        <!-- Divider -->
        <hr class=""sidebar-divider my-0"">

        <!-- Nav Item - Dashboard -->
        <li class=""nav-item"">
            <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 627, "\"", 634, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <i class=""fas fa-fw fa-tachometer-alt""></i>
                <span>Chức Năng</span>
            </a>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider"">

        <!-- Heading -->
        <div class=""sidebar-heading"">
            Interface
        </div>

        <!-- Nav Item - Pages Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Quản Lý Khoá Học</span>
            </a>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    <a class=""collapse-item""");
            BeginWriteAttribute("href", " href=\"", 1583, "\"", 1590, 0);
            EndWriteAttribute();
            WriteLiteral(@">Danh Sách Khoá Học</a>
                </div>
            </div>
        </li>

        <!-- Nav Item - Utilities Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities"" aria-expanded=""true"" aria-controls=""collapseUtilities"">
                <i class=""fas fa-fw fa-wrench""></i>
                <span>Tài Khoản Thành Viên</span>
            </a>
            <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Chức Năng</h6>
                    <a class=""collapse-item""");
            BeginWriteAttribute("href", " href=\"", 2349, "\"", 2356, 0);
            EndWriteAttribute();
            WriteLiteral(@">Danh Sách Tài Khoản Thành Viên</a>>
                </div>
            </div>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider"">

        <!-- Heading -->
        <div class=""sidebar-heading"">
            Addons
        </div>

        <!-- Nav Item - Pages Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages"">
                <i class=""fas fa-fw fa-folder""></i>
                <span>Pages</span>
            </a>
            <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Login Screens:</h6>
                    <a class=""collapse-item""");
            BeginWriteAttribute("href", " href=\"", 3257, "\"", 3264, 0);
            EndWriteAttribute();
            WriteLiteral(">Login</a>\r\n                    <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 3321, "\"", 3328, 0);
            EndWriteAttribute();
            WriteLiteral(">Register</a>\r\n                    <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 3388, "\"", 3395, 0);
            EndWriteAttribute();
            WriteLiteral(">Forgot Password</a>\r\n                    <div class=\"collapse-divider\"></div>\r\n                    <h6 class=\"collapse-header\">Other Pages:</h6>\r\n                    <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 3587, "\"", 3594, 0);
            EndWriteAttribute();
            WriteLiteral(">404 Page</a>\r\n                    <a class=\"collapse-item\"");
            BeginWriteAttribute("href", " href=\"", 3654, "\"", 3661, 0);
            EndWriteAttribute();
            WriteLiteral(@">Blank Page</a>
                </div>
            </div>
        </li>

        <!-- Nav Item - Charts -->
        <li class=""nav-item"">
            <a class=""nav-link"" href=""charts.html"">
                <i class=""fas fa-fw fa-chart-area""></i>
                <span>Charts</span>
            </a>
        </li>

        <!-- Nav Item - Tables -->
        <li class=""nav-item"">
            <a class=""nav-link"" href=""tables.html"">
                <i class=""fas fa-fw fa-table""></i>
                <span>Tables</span>
            </a>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider d-none d-md-block"">

        <!-- Sidebar Toggler (Sidebar) -->
        <div class=""text-center d-none d-md-inline"">
            <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
        </div>

    </ul>
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

#pragma checksum "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "435e3721b6fcde29ac7714495523dfecf4c8501d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomeAdmin_Statistical), @"mvc.1.0.view", @"/Areas/Admin/Views/HomeAdmin/Statistical.cshtml")]
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
#line 1 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"435e3721b6fcde29ac7714495523dfecf4c8501d", @"/Areas/Admin/Views/HomeAdmin/Statistical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157a527780a79be07ea5f9836751adb2bedf89d1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HomeAdmin_Statistical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Models.LessonModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Statistical", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HomeAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
  
    ViewData["Title"] = "Statistical";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Thống kê bài giãng được nhiều tương tác nhất theo từng khoá học</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "435e3721b6fcde29ac7714495523dfecf4c8501d4937", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label\">Nhập Khoá Học</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "435e3721b6fcde29ac7714495523dfecf4c8501d5301", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 10 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.IdCourse;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Tìm\" class=\"btn btn-primary w-100\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
           Write(Html.DisplayNameFor(model => model.LessonName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
           Write(Html.DisplayNameFor(model => model.Video));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
           Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
           Write(Html.DisplayNameFor(model => model.Coach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"overflow-auto\">\r\n");
#nullable restore
#line 45 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 49 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
               Write(Html.DisplayFor(modelItem => item.LessonName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 52 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 55 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
               Write(Html.DisplayFor(modelItem => item.Video));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 58 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
               Write(Html.Raw(item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 61 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
               Write(Html.DisplayFor(modelItem => item.Course.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 67 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
               Write(Html.DisplayFor(modelItem => item.CommemtLessons.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 70 "D:\N_3_HK_1\LT WEB ASP.NET core\DoAn\Project\WebApp\Areas\Admin\Views\HomeAdmin\Statistical.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Models.LessonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
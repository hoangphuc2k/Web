#pragma checksum "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4273ca74a9b0269c977001001df598a334fab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailLesson), @"mvc.1.0.view", @"/Views/Home/DetailLesson.cshtml")]
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
#line 1 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4273ca74a9b0269c977001001df598a334fab5", @"/Views/Home/DetailLesson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819e68de9bbbc7d89a0314828859c43ca94fcae9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DetailLesson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Areas.Admin.Models.LessonModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailLesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("be-ava-comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
  
    ViewData["Title"] = "Lesson Page";
    var listLesson = ViewBag.ListLesson as IEnumerable<WebApp.Areas.Admin.Models.LessonModel>;
    var listComment = ViewBag.ListComment as IEnumerable<WebApp.Areas.Admin.Models.CommemtLessonModel>;

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral(@"
    <style>
        .be-comment-block {
            margin-bottom: 50px !important;
            border: 1px solid #edeff2;
            border-radius: 2px;
            padding: 50px 70px;
            border: 1px solid #ffffff;
        }

        .comments-title {
            font-size: 16px;
            color: #262626;
            margin-bottom: 15px;
            font-family: 'Conv_helveticaneuecyr-bold';
        }

        .be-img-comment {
            width: 60px;
            height: 60px;
            float: left;
            margin-bottom: 15px;
        }

        .be-ava-comment {
            width: 60px;
            height: 60px;
            border-radius: 50%;
        }

        .be-comment-content {
            margin-left: 80px;
        }

            .be-comment-content span {
                display: inline-block;
                width: 49%;
                margin-bottom: 15px;
            }

        .be-comment-name {
            font-size: 13px;
          ");
                WriteLiteral(@"  font-family: 'Conv_helveticaneuecyr-bold';
        }

        .be-comment-content a {
            color: #383b43;
        }

        .be-comment-content span {
            display: inline-block;
            width: 49%;
            margin-bottom: 15px;
        }

        .be-comment-time {
            text-align: right;
        }

        .be-comment-time {
            font-size: 11px;
            color: #b4b7c1;
        }

        .be-comment-text {
            font-size: 13px;
            line-height: 18px;
            color: #7a8192;
            display: block;
            background: #f6f6f7;
            border: 1px solid #edeff2;
            padding: 15px 20px 20px 20px;
        }

        .form-group.fl_icon .icon {
            position: absolute;
            top: 1px;
            left: 16px;
            width: 48px;
            height: 48px;
            background: #f6f6f7;
            color: #b5b8c2;
            text-align: center;
            line-height: 50p");
                WriteLiteral(@"x;
            -webkit-border-top-left-radius: 2px;
            -webkit-border-bottom-left-radius: 2px;
            -moz-border-radius-topleft: 2px;
            -moz-border-radius-bottomleft: 2px;
            border-top-left-radius: 2px;
            border-bottom-left-radius: 2px;
        }

        .form-group .form-input {
            font-size: 13px;
            line-height: 50px;
            font-weight: 400;
            color: #b4b7c1;
            width: 100%;
            height: 50px;
            padding-left: 20px;
            padding-right: 20px;
            border: 1px solid #edeff2;
            border-radius: 3px;
        }

        .form-group.fl_icon .form-input {
            padding-left: 70px;
        }

        .form-group textarea.form-input {
            height: 150px;
        }
    </style>
");
            }
            );
            WriteLiteral(@"<div class=""row"">

    <div class=""col-xl-8 col-lg-7"">

        <!-- Area Chart -->
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Video hướng dẫn</h6>
            </div>
            <div class=""card-body"">
                <iframe class=""w-100"" height=""415"" src=""https://www.youtube.com/embed/ewFmBXXVKG8"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            </div>

        </div>
    </div>
    <!-- Donut Chart -->
    <div class=""col-xl-4 col-lg-5 h-50"">
        <div class=""card shadow mb-4"" style=""height:515px"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Danh sách bài giảng</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body overflow-auto"">
");
#nullable restore
#line 145 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                 foreach (var item in listLesson)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc4273ca74a9b0269c977001001df598a334fab510825", async() => {
#nullable restore
#line 147 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 148 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<div class=""col-xl-12 col-lg-12"">

    <!-- Area Chart -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Nội Dung</h6>
        </div>
        <div class=""card-body overflow-auto"">
            ");
#nullable restore
#line 161 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
       Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!-- Phan Comment-->\r\n<div class=\"be-comment-block\">\r\n    <h1 class=\"comments-title\">Bình Luận (");
#nullable restore
#line 170 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                                     Write(listComment.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n    <ul id=\"CommentPlace\">\r\n");
#nullable restore
#line 172 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
         foreach (var item in listComment)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div class=\"be-comment\">\r\n                    <div class=\"be-img-comment\">\r\n                        <a href=\"blog-detail-2.html\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4273ca74a9b0269c977001001df598a334fab514872", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5226, "~/Img//User/", 5226, 12, true);
#nullable restore
#line 178 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
AddHtmlAttributeValue("", 5238, item.User.Img, 5238, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"be-comment-content\">\r\n                        <span class=\"be-comment-name\">\r\n                            <h5>\r\n                                ");
#nullable restore
#line 184 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                           Write(item.User.AccountName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h5>\r\n                        </span>\r\n                        <p class=\"be-comment-text\">\r\n                            ");
#nullable restore
#line 188 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                       Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 193 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12 col-sm-12\">\r\n                <div class=\"form-group\">\r\n                    <input class=\"form-input\"");
            BeginWriteAttribute("required", " required=\"", 5992, "\"", 6003, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Nội dung bình luận\" id=\"messageInput\" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xs-12\">\r\n");
#nullable restore
#line 202 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                 if (Context.User.Identity.IsAuthenticated)
                {
                    //Lay du lieu ve tai khoan dang dang nhap
                    string img = "";
                    string id = "";
                    img = Context.User.Claims.ToList()[3].Value;
                    id = Context.User.Claims.ToList()[2].Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input class=\"btn btn-primary text-white\" type=\"button\" id=\"sendButton\" value=\"Send Message\" />\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6647, "\"", 6682, 1);
#nullable restore
#line 210 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
WriteAttributeValue("", 6655, Context.User.Identity.Name, 6655, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"userInput\" />\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6743, "\"", 6765, 2);
            WriteAttributeValue("", 6751, "/Img/User/", 6751, 10, true);
#nullable restore
#line 211 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
WriteAttributeValue("", 6761, img, 6761, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"avatarInput\" />\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6828, "\"", 6839, 1);
#nullable restore
#line 212 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
WriteAttributeValue("", 6836, id, 6836, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"idInput\" />\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6898, "\"", 6927, 1);
#nullable restore
#line 213 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
WriteAttributeValue("", 6906, ViewData["IdLesson"], 6906, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"idLessonInput\" />\r\n");
#nullable restore
#line 214 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 215 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                 if (!Context.User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc4273ca74a9b0269c977001001df598a334fab521096", async() => {
                WriteLiteral("content");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 218 "E:\Do an\DoAnAspNet\WebSiteHocTap\WebApp\Views\Home\DetailLesson.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Areas.Admin.Models.LessonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

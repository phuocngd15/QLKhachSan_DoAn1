#pragma checksum "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e824bf91ecf4b8beff21a6cb1fc4cf792a8b5530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DatPhong_DatPhongDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/DatPhong/DatPhongDetail.cshtml")]
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
#line 1 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\_ViewImports.cshtml"
using CaChepFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\_ViewImports.cshtml"
using CaChepFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\_ViewImports.cshtml"
using CaChepFinal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\_ViewImports.cshtml"
using CaChepFinal.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e824bf91ecf4b8beff21a6cb1fc4cf792a8b5530", @"/Areas/Admin/Views/DatPhong/DatPhongDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb2e3f9bd1dbb47f3cd93a939938343719290bc", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DatPhong_DatPhongDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DatPhongTongHop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
  
ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>Thong Tin Chi tiet dat phong</h1>

<div>
    <dl class=""row"">
        <dt class=""col-sm-5"">
            <h4>Thong tin nguoi dat</h4>
        </dt>
        <dt class=""col-sm-7"">
            Danh Sach Phong
        </dt>
    </dl>
    <hr>
    <dl class=""row"">
        <dt class=""col-sm-5"">
            <dl class=""row"">
                <dt class=""col-sm-6"">
                    ");
#nullable restore
#line 23 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].TenNguoiDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 26 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].TenNguoiDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 29 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 32 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 35 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 38 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 41 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].CMND));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 44 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].CMND));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 47 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 50 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 53 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].TienDatCoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 56 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].TienDatCoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 59 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].ThoiGianNhanPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 62 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].ThoiGianNhanPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 65 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].ThoiGianTraPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 68 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].ThoiGianTraPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 72 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayNameFor(model => model.datPhongs[0].UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
#nullable restore
#line 76 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
               Write(Html.DisplayFor(model => model.datPhongs[0].UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </dd>\r\n            </dl>\r\n        </dt>\r\n        <dt class=\"col-sm-7\">\r\n\r\n            <table class=\"table\">\r\n                <thead>\r\n\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 88 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayNameFor(model => model.chiTietDatPhongs[0].TongSoNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 91 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayNameFor(model => model.chiTietDatPhongs[0].GiaTienMotNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 94 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayNameFor(model => model.chiTietDatPhongs[0].Phong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 97 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayNameFor(model => model.chiTietDatPhongs[0].DatPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 103 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                     foreach (var item in Model.chiTietDatPhongs) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 106 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TongSoNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 109 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GiaTienMotNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 112 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Phong.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 115 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DatPhong.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e824bf91ecf4b8beff21a6cb1fc4cf792a8b553015739", async() => {
                WriteLiteral("Edit");
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
#line 118 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
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
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e824bf91ecf4b8beff21a6cb1fc4cf792a8b553017937", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
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
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e824bf91ecf4b8beff21a6cb1fc4cf792a8b553020141", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 123 "D:\MyGit\QLKhachSan_DoAn1\CaChepFinal\Areas\Admin\Views\DatPhong\DatPhongDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </dt>\r\n    </dl>\r\n\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e824bf91ecf4b8beff21a6cb1fc4cf792a8b553022715", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DatPhongTongHop> Html { get; private set; }
    }
}
#pragma warning restore 1591
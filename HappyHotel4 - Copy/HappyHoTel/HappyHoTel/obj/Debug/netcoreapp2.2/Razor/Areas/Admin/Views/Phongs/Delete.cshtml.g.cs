#pragma checksum "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cad59c3fc424aa91b86c681224b70c9f564e402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Phongs_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Phongs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Phongs/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Phongs_Delete))]
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
#line 1 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\_ViewImports.cshtml"
using HappyHoTel;

#line default
#line hidden
#line 2 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\_ViewImports.cshtml"
using HappyHoTel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cad59c3fc424aa91b86c681224b70c9f564e402", @"/Areas/Admin/Views/Phongs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8cb9c2cd0f91f5048714cb5a461a72269cd1eeb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Phongs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HappyHoTel.Models.Phong>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(76, 175, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Phong</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(252, 44, false);
#line 15 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TenPhong));

#line default
#line hidden
            EndContext();
            BeginContext(296, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(360, 40, false);
#line 18 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TenPhong));

#line default
#line hidden
            EndContext();
            BeginContext(400, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(463, 49, false);
#line 21 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SoNguoiOToiDa));

#line default
#line hidden
            EndContext();
            BeginContext(512, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(576, 45, false);
#line 24 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SoNguoiOToiDa));

#line default
#line hidden
            EndContext();
            BeginContext(621, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(684, 45, false);
#line 27 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTaPhong));

#line default
#line hidden
            EndContext();
            BeginContext(729, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(793, 41, false);
#line 30 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MoTaPhong));

#line default
#line hidden
            EndContext();
            BeginContext(834, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(897, 48, false);
#line 33 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CachTinhTien));

#line default
#line hidden
            EndContext();
            BeginContext(945, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1009, 44, false);
#line 36 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CachTinhTien));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1116, 42, false);
#line 39 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhuThu));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1222, 38, false);
#line 42 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhuThu));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1323, 50, false);
#line 45 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TinhTrangPhong));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1437, 46, false);
#line 48 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TinhTrangPhong));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1546, 46, false);
#line 51 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LoaiPhongs));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1656, 55, false);
#line 54 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LoaiPhongs.TenLoaiPhong));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1755, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cad59c3fc424aa91b86c681224b70c9f564e40211495", async() => {
                BeginContext(1781, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1791, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cad59c3fc424aa91b86c681224b70c9f564e40211888", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "E:\GitHub\QLKhachSan_DoAn1\HappyHotel4 - Copy\HappyHoTel\HappyHoTel\Areas\Admin\Views\Phongs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhongId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1832, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1915, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cad59c3fc424aa91b86c681224b70c9f564e40213826", async() => {
                    BeginContext(1937, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1953, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1966, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HappyHoTel.Models.Phong> Html { get; private set; }
    }
}
#pragma warning restore 1591

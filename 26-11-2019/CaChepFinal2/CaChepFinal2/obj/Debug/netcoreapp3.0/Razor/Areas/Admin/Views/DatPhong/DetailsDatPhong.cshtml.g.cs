#pragma checksum "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a865f5f970bfc8c6ce8ab9e07f79ebb5ac9583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DatPhong_DetailsDatPhong), @"mvc.1.0.view", @"/Areas/Admin/Views/DatPhong/DetailsDatPhong.cshtml")]
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
#line 1 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\_ViewImports.cshtml"
using CaChepFinal2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\_ViewImports.cshtml"
using CaChepFinal2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a865f5f970bfc8c6ce8ab9e07f79ebb5ac9583", @"/Areas/Admin/Views/DatPhong/DetailsDatPhong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35060116620cbe369d37211287ae914f3aa4763c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DatPhong_DetailsDatPhong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaChepFinal2.Areas.Admin.Models.DatPhongDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexPhong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexDichVu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Chi Tiết Phiếu đặt Phòng</h1>\r\n\r\n\r\n<div>\r\n    <h4>DatPhong</h4>\r\n    <div>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63a865f5f970bfc8c6ce8ab9e07f79ebb5ac95834592", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.TenNguoiDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.TenNguoiDat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.CMND));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.CMND));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.TienDatCoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.TienDatCoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.ThoiGianNhanPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.ThoiGianNhanPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.GetDatPhong.ThoiGianTraPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayFor(model => model.GetDatPhong.ThoiGianTraPhongDuKien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("<h2>Danh sách Phòng</h2>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63a865f5f970bfc8c6ce8ab9e07f79ebb5ac958311692", async() => {
                WriteLiteral("Them Phong");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr><th>\r\n                ");
#nullable restore
#line 80 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayNameFor(model => model.ChiTietPhongDatPhongs[0].Phong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 83 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayNameFor(model => model.ChiTietPhongDatPhongs[0].TongSoNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 86 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayNameFor(model => model.ChiTietPhongDatPhongs[0].GiaTienMotNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 89 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayNameFor(model => model.ChiTietPhongDatPhongs[0].DatPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 96 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
         foreach (var item in Model.ChiTietPhongDatPhongs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>\r\n                    ");
#nullable restore
#line 99 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phong.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
               Write(Html.DisplayFor(modelItem => item.TongSoNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
               Write(Html.DisplayFor(modelItem => item.GiaTienMotNgay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
               Write(Html.DisplayFor(modelItem => item.DatPhong.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 117 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            WriteLiteral("\r\n<h2>Danh sách Dịch Vụ</h2>\r\n<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63a865f5f970bfc8c6ce8ab9e07f79ebb5ac958316672", async() => {
                WriteLiteral("Them Dich Vu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 131 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.ChiTietDichVuDatPhongs[0].SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 134 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.ChiTietDichVuDatPhongs[0].GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 137 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.ChiTietDichVuDatPhongs[0].GetDatPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 140 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
       Write(Html.DisplayNameFor(model => model.ChiTietDichVuDatPhongs[0].GetDichVu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 146 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
     foreach (var item in Model.ChiTietDichVuDatPhongs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 150 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 153 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayFor(modelItem => item.GiaTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 156 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayFor(modelItem => item.GetDatPhong.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 159 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
           Write(Html.DisplayFor(modelItem => item.GetDichVu.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 167 "E:\Học Kì 5\Đồ án 1\26-11-2019\CaChepFinal2\CaChepFinal2\Areas\Admin\Views\DatPhong\DetailsDatPhong.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaChepFinal2.Areas.Admin.Models.DatPhongDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591

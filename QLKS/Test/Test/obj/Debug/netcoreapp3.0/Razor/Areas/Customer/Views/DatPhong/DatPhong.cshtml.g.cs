#pragma checksum "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0823d7923a2d6e3639989564351e1af1d3f90e4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_DatPhong_DatPhong), @"mvc.1.0.view", @"/Areas/Customer/Views/DatPhong/DatPhong.cshtml")]
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
#line 1 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0823d7923a2d6e3639989564351e1af1d3f90e4a", @"/Areas/Customer/Views/DatPhong/DatPhong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_DatPhong_DatPhong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.Models.ViewModel.PhongTinhTrangViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DatPhong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Phiếu đặt phòng</h1>

<h3>Thông tin phiếu đặt phòng</h3>
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <div>
                <dl class=""row"">
                    <dt class=""col-md-2"">
                        ");
#nullable restore
#line 16 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phongs[0].TenPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayFor(model => model.Phongs[0].TenPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phongs[0].SoNguoiOToiDa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayFor(model => model.Phongs[0].SoNguoiOToiDa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phongs[0].MoTaPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayFor(model => model.Phongs[0].MoTaPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phongs[0].CachTinhTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayFor(model => model.Phongs[0].CachTinhTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phongs[0].PhuThu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayFor(model => model.Phongs[0].PhuThu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 46 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phongs[0].TinhTrangPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 49 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayFor(model => model.Phongs[0].TinhTrangPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phongs[0].LoaiPhongs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                   Write(Html.DisplayFor(model => model.Phongs[0].LoaiPhongs.TenLoaiPhong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0823d7923a2d6e3639989564351e1af1d3f90e4a11470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 64 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"form-group form-check\">\r\n                        <label class=\"form-check-label\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0823d7923a2d6e3639989564351e1af1d3f90e4a13238", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 67 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhieuDatPhong.TinhTrang);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 67 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
                                                                                            Write(Html.DisplayNameFor(model => model.PhieuDatPhong.TinhTrang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n");
            WriteLiteral("                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n    <br />\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\"></div>\r\n        <div class=\"col-sm\">\r\n            <div class=\"col-sm\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0823d7923a2d6e3639989564351e1af1d3f90e4a15566", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0823d7923a2d6e3639989564351e1af1d3f90e4a15845", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 102 "C:\Users\JackieLeIV\Desktop\QLKS\Test\Test\Areas\Customer\Views\DatPhong\DatPhong.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phongs[0].PhongId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Dat Phong\" class=\"btn btn-danger\" /> |\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0823d7923a2d6e3639989564351e1af1d3f90e4a17684", async() => {
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
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Models.ViewModel.PhongTinhTrangViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

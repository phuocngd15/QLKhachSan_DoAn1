#pragma checksum "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc38cca239a1ea8037623abbbf574bdb65bb6872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_PhongCustomer_IndexRoom), @"mvc.1.0.view", @"/Areas/Customer/Views/PhongCustomer/IndexRoom.cshtml")]
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
#line 1 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\_ViewImports.cshtml"
using CaChepFinal2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\_ViewImports.cshtml"
using CaChepFinal2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc38cca239a1ea8037623abbbf574bdb65bb6872", @"/Areas/Customer/Views/PhongCustomer/IndexRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35060116620cbe369d37211287ae914f3aa4763c", @"/Areas/Customer/_ViewImports.cshtml")]
    public class Areas_Customer_Views_PhongCustomer_IndexRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaChepFinal2.Data.DataModel.Phong>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PhongCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
    }

    .layout {
        background-image: url(""~/images/layoyut/AnhChinh.png"");
        width: 100%;
        height: 50rem;
    }
</style>

<br />
<br />

<div class=""row"">
");
#nullable restore
#line 26 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-4"">
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <h4 class=""my-0 font-weight-normal"">
                        <label style=""font-size:23px;color:steelblue;"">
                            ");
#nullable restore
#line 33 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml"
                       Write(Html.DisplayFor(modelItem => product.LoaiPhong.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                    </h4>\r\n                </div>\r\n\r\n                <img class=\"card-img-top\" style=\"height:100%;\"");
            BeginWriteAttribute("src", " src=\"", 946, "\"", 968, 1);
#nullable restore
#line 38 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml"
WriteAttributeValue("", 952, product.HinhUrl, 952, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Card Image"" />
                <div class=""card-body"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <label style=""font-size:20px; color:#a51313"">
                                ");
#nullable restore
#line 43 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml"
                           Write(Html.DisplayFor(modelItem => product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </label>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc38cca239a1ea8037623abbbf574bdb65bb68727051", async() => {
                WriteLiteral(" View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml"
                                                                                                                                         WriteLiteral(product.Id);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\thanh\Desktop\Chắc cái cuối\CaChepFinal2\CaChepFinal2\Areas\Customer\Views\PhongCustomer\IndexRoom.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaChepFinal2.Data.DataModel.Phong>> Html { get; private set; }
    }
}
#pragma warning restore 1591

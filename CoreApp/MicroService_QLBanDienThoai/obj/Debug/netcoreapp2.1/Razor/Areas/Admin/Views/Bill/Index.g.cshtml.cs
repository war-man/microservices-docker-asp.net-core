#pragma checksum "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96502a77b126d67a4a6cce4f88831e23b9e97af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bill_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Bill/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Bill/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Bill_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96502a77b126d67a4a6cce4f88831e23b9e97af", @"/Areas/Admin/Views/Bill/Index.cshtml")]
    public class Areas_Admin_Views_Bill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MicroService_QLBanDienThoai.Areas.Customer.Models.ViewOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(223, 234, true);
            WriteLiteral("\r\n<h1 class=\"page-header\">DANH SÁCH ĐƠN HÀNG</h1>\r\n<hr>\r\n\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-body\">\r\n        <!-- Search form -->\r\n        <div class=\"row\">\r\n             <div class=\"col-lg-3\">\r\n                ");
            EndContext();
            BeginContext(457, 571, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72cab942bf074719b43de6aee06f39a8", async() => {
                BeginContext(521, 500, true);
                WriteLiteral(@"
                    <div class=""input-group custom-search-form"">
                        <input type=""text"" class=""form-control"" id=""searchList"" placeholder=""Tìm kiếm..."" name=""search"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""submit"">
                                <i class=""fa fa-search""></i>
                            </button>
                        </span>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1028, 661, true);
            WriteLiteral(@"
            </div>

            <!-------------------------------------------------------- MAIN TABLE ---------------------------------------------------------->
        </div>
        <br />
        <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Mã hóa đơn</th>
                    <th>Mã khách hàng</th>
                    <th>Tổng tiền</th>
                    <th>Ngày mua</th>
                    <th>Chức Năng</th>
                </tr>
            </thead>
            <tbody class=""body-content"">
");
            EndContext();
#line 43 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
                  
                    if (Model != null && Model.Count > 0)
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1871, 124, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td width=\"10%\" class=\"item-AccountID\">");
            EndContext();
            BeginContext(1996, 7, false);
#line 49 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
                                                                  Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2003, 81, true);
            WriteLiteral(" </td>\r\n                                <td width=\"10%\" class=\"item-AccountName\">");
            EndContext();
            BeginContext(2085, 14, false);
#line 50 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
                                                                    Write(item.AccountID);

#line default
#line hidden
            EndContext();
            BeginContext(2099, 65, true);
            WriteLiteral("</td>\r\n                                <td class=\"item-Password\">");
            EndContext();
            BeginContext(2165, 31, false);
#line 51 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
                                                     Write(item.Amount.ToString("#.# VND"));

#line default
#line hidden
            EndContext();
            BeginContext(2196, 68, true);
            WriteLiteral("</td>\r\n                                <td class=\"item-PhoneNumber\">");
            EndContext();
            BeginContext(2265, 14, false);
#line 52 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
                                                        Write(item.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(2279, 83, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2362, "\"", 2396, 2);
            WriteAttributeValue("", 2369, "/Admin/Bill/Detail/", 2369, 19, true);
#line 54 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2388, item.Id, 2388, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2397, 110, true);
            WriteLiteral(" class=\"btn btn-info\">Chi Tiết</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 57 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
            BeginContext(2576, 110, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <!-- /.table-responsive -->\r\n        <!-- /.panel-body -->\r\n\r\n");
            EndContext();
#line 65 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
         if (ViewBag.ThongBao != null)
        {

#line default
#line hidden
            BeginContext(2737, 37, true);
            WriteLiteral("            <script>\r\n        alert(\"");
            EndContext();
            BeginContext(2775, 26, false);
#line 68 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
          Write(Html.Raw(ViewBag.ThongBao));

#line default
#line hidden
            EndContext();
            BeginContext(2801, 28, true);
            WriteLiteral("\");\r\n            </script>\r\n");
            EndContext();
#line 70 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Bill\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2840, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MicroService_QLBanDienThoai.Areas.Customer.Models.ViewOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
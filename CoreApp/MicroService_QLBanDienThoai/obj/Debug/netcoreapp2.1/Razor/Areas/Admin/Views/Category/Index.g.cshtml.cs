#pragma checksum "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7969c61d9f678332d2f584b9d3a239087ff28dc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7969c61d9f678332d2f584b9d3a239087ff28dc7", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MicroService_QLBanDienThoai.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Không Khoá", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Khoá", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(216, 639, true);
            WriteLiteral(@"

<h1 class=""page-header"">DANH SÁCH LOẠI SẢN PHẨM</h1>
<hr>

<div class=""panel panel-default"">
    <div class=""panel-body"">
        <!-- Search form -->
        <div class=""row"">
            <!-------------------------------------------------------- INSERT ---------------------------------------------------------->
            <div class=""col-lg-1"">
                <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#themModal"">Thêm</button>
            </div>
            <!-------------------------------------------------------- SEARCH CATEGORY ---------------------------------------------------------->
");
            EndContext();
            BeginContext(1780, 195, true);
            WriteLiteral("            <!-------------------------------------------------------- SEARCH BAR ---------------------------------------------------------->\r\n            <div class=\"col-lg-3\">\r\n                ");
            EndContext();
            BeginContext(1975, 574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25e77cccc86b4aeaaadbb5350b6a2247", async() => {
                BeginContext(2040, 502, true);
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
            BeginContext(2549, 618, true);
            WriteLiteral(@"
            </div>

            <!-------------------------------------------------------- MAIN TABLE ---------------------------------------------------------->
        </div>
        <br/>
        <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Mã Loại</th>
                    <th>Tên Loại</th>
                    <th>Trạng Thái</th>

                    <th>Chức Năng</th>

                </tr>
            </thead>
            <tbody class=""body-content"">
");
            EndContext();
#line 64 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3232, 89, true);
            WriteLiteral("                <tr class=\"odd gradeX\">\r\n                    <td class=\"item-CategoryID\">");
            EndContext();
            BeginContext(3322, 15, false);
#line 67 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
                                           Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(3337, 57, true);
            WriteLiteral("</td>\r\n                    <td class=\"item-CategoryName\">");
            EndContext();
            BeginContext(3395, 17, false);
#line 68 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
                                             Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3412, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 69 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
                     if (@item.IsActive == 1)
                    {

#line default
#line hidden
            BeginContext(3489, 67, true);
            WriteLiteral("                        <td class=\"item-IsActive\">Không Khoá</td>\r\n");
            EndContext();
#line 72 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3628, 68, true);
            WriteLiteral("                        <td class=\"item-IsActive\"><b>Khoá</b></td>\r\n");
            EndContext();
#line 76 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3719, 171, true);
            WriteLiteral("\r\n                    <td>\r\n                        <button class=\"btn btn-primary btnSuaCategory\" type=\"button\" data-toggle=\"modal\" data-target=\"#suaModal\">Sửa</button>\r\n");
            EndContext();
            BeginContext(4047, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 83 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4116, 409, true);
            WriteLiteral(@"            </tbody>
        </table>
        <!-- /.table-responsive -->
        <!-- /.panel-body -->
        <!-------------------------------------------------------- INSERT MODAL ---------------------------------------------------------->

        <div class=""modal fade"" id=""themModal"" role=""dialog"">
            <div class=""modal-dialog"">
                <!-- Modal content-->
                ");
            EndContext();
            BeginContext(4525, 2482, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "246880f38f9249039977e59207382697", async() => {
                BeginContext(4599, 264, true);
                WriteLiteral(@"
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h4 class=""modal-title""><b>LOẠI SẢN PHẨM</b></h4>
                        </div>
                        <div class=""modal-body"">
");
                EndContext();
                BeginContext(5159, 288, true);
                WriteLiteral(@"                            <div class=""form-group"">
                                <label>Tên Loại</label>
                                <input type=""text"" class=""form-control"" id=""item-them-CategoryName"" name=""item_them_CategoryName"" required>
                            </div>
");
                EndContext();
                BeginContext(5731, 113, true);
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <label>Trạng Thái</label>\r\n");
                EndContext();
                BeginContext(5981, 158, true);
                WriteLiteral("                                <select class=\"form-control\" id=\"item-them-IsActive\" name=\"item_them_IsActive\" required>\r\n                                    ");
                EndContext();
                BeginContext(6139, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a4f170de4344789736e09b581abd20", async() => {
                    BeginContext(6166, 10, true);
                    WriteLiteral("Không Khoá");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6185, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(6223, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454292eb97894edeb170d6199ee977aa", async() => {
                    BeginContext(6244, 4, true);
                    WriteLiteral("Khoá");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6257, 83, true);
                WriteLiteral("\r\n\r\n                                </select>\r\n                            </div>\r\n");
                EndContext();
                BeginContext(6621, 379, true);
                WriteLiteral(@"                        </div>
                        <div class=""modal-footer"">
                            <button type=""submit"" class=""btn btn-warning"" id=""btnThemCategory"">Thêm</button>
                            <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Đóng</button>
                        </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7007, 336, true);
            WriteLiteral(@"
            </div>
        </div>
        <!-------------------------------------------------------- UPDATE MODAL ---------------------------------------------------------->
        <div class=""modal fade"" id=""suaModal"" role=""dialog"">
            <div class=""modal-dialog"">
                <!-- Modal content-->
                ");
            EndContext();
            BeginContext(7343, 2468, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55d034ff9384d26ace058a15cd300a5", async() => {
                BeginContext(7415, 103, true);
                WriteLiteral("\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n");
                EndContext();
                BeginContext(7625, 737, true);
                WriteLiteral(@"                            <h4 class=""modal-title""><b>LOẠI SẢN PHẨM</b></h4>
                        </div>
                        <div class=""modal-body"">
                            <div class=""form-group"">
                                <label>Mã Loại</label>
                                <input type=""text"" class=""form-control"" id=""item-sua-CategoryID"" name=""item_sua_CategoryID"" required readonly>
                            </div>
                            <div class=""form-group"">
                                <label>Tên Loại</label>
                                <input type=""text"" class=""form-control"" id=""item-sua-CategoryName"" name=""item_sua_CategoryName"" required>
                            </div>
");
                EndContext();
                BeginContext(8608, 313, true);
                WriteLiteral(@"                                    <div class=""form-group"">
                                        <label>Trạng Thái</label>
                                        <select type=""text"" class=""form-control"" id=""item-sua-IsActive"" name=""item_sua_IsActive"" required>
                                            ");
                EndContext();
                BeginContext(8921, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4ede90f91744d5a2fac2ab159683c8", async() => {
                    BeginContext(8948, 10, true);
                    WriteLiteral("Không Khoá");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8967, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(9013, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0bf8ce66264bfc8b3c4cba3734a231", async() => {
                    BeginContext(9034, 4, true);
                    WriteLiteral("Khoá");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9047, 101, true);
                WriteLiteral("\r\n                                            </select>\r\n                                    </div>\r\n");
                EndContext();
                BeginContext(9427, 377, true);
                WriteLiteral(@"                        </div>
                        <div class=""modal-footer"">
                            <button type=""submit"" class=""btn btn-warning"" id=""btnSuaCategory"">Sửa</button>
                            <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Đóng</button>
                        </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9811, 40, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
#line 176 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
         if (ViewBag.ThongBao != null)
        {

#line default
#line hidden
            BeginContext(9902, 37, true);
            WriteLiteral("            <script>\r\n        alert(\"");
            EndContext();
            BeginContext(9940, 26, false);
#line 179 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
          Write(Html.Raw(ViewBag.ThongBao));

#line default
#line hidden
            EndContext();
            BeginContext(9966, 28, true);
            WriteLiteral("\");\r\n            </script>\r\n");
            EndContext();
#line 181 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Admin\Views\Category\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(10005, 872, true);
            WriteLiteral(@"

        <script>
            $("".btnSuaCategory"").click(function () {
                let CategoryID = $(this).closest('tr').find('.item-CategoryID').text();
                let CategoryName = $(this).closest('tr').find('.item-CategoryName').text();
                let Quantity = $(this).closest('tr').find('.item-Quantity').text();
                let IsActive = $(this).closest('tr').find('.item-IsActive').text();
                let Archive = $(this).closest('tr').find('.item-Archive').text();


                $(""#item-sua-CategoryID"").val(CategoryID.trim());
                $(""#item-sua-CategoryName"").val(CategoryName.trim());
                $(""#item-sua-Quantity"").val(Quantity.trim());
                $(""#item-sua-IsActive"").val(IsActive.trim());
                $(""#item-sua-Archive"").val(Archive.trim());


    });
        </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MicroService_QLBanDienThoai.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591

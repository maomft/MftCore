#pragma checksum "F:\转正资料归档\手机审核\2020年7月31日\TradeAudit\TradeAudit\Views\TaskNodeL\MobileGetTaskNodeLstByPageView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "037d8cc876a1826e0e41dfe8f13010909839c3bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskNodeL_MobileGetTaskNodeLstByPageView), @"mvc.1.0.view", @"/Views/TaskNodeL/MobileGetTaskNodeLstByPageView.cshtml")]
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
#line 1 "F:\转正资料归档\手机审核\2020年7月31日\TradeAudit\TradeAudit\Views\_ViewImports.cshtml"
using TradeAuditWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\转正资料归档\手机审核\2020年7月31日\TradeAudit\TradeAudit\Views\_ViewImports.cshtml"
using TradeAuditWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037d8cc876a1826e0e41dfe8f13010909839c3bb", @"/Views/TaskNodeL/MobileGetTaskNodeLstByPageView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a56a28670106722b3881eb5bbf610b3e8e1020", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskNodeL_MobileGetTaskNodeLstByPageView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("BaseFormId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-form-pane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("first"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\转正资料归档\手机审核\2020年7月31日\TradeAudit\TradeAudit\Views\TaskNodeL\MobileGetTaskNodeLstByPageView.cshtml"
   ViewData["Title"] = "审批数据列表"; 

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/TaskNodeL/MobileGetTaskNodeLstByPageView.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<style>
    .layui-field-title {
        margin-top: 30px;
    }

    .grid-demo {
        padding: 10px;
        line-height: 50px;
        text-align: center;
        background-color: #79C48C;
        color: #fff;
    }

    .grid-demo-bg1 {
        background-color: #63BA79;
    }

    .grid-demo-bg2 {
        background-color: #49A761;
    }

    .grid-demo-bg3 {
        background-color: #38814A;
    }

    td.details-control {
        background: url(""/lib/jquerydatatable/images/details_open.png"") no-repeat center center;
        cursor: pointer;
    }

    tr.shown td.details-control {
        background: url('/lib/jquerydatatable/images/details_close.png') no-repeat center center;
    }
</style>
<div class=""layui-fluid"">
    <div class=""layui-container"" style=""width: 100%"">
        <div class=""layui-card"" style=""width: 100%"">
            <div class=""layui-card-header"">
                <h1>交易审批</h1>
            </div>
            <div class=""layui-tab"">
       ");
            WriteLiteral("         <ul class=\"layui-tab-title\">\r\n                    <li class=\"layui-this\"><a");
            BeginWriteAttribute("href", " href=\"", 1245, "\"", 1309, 1);
#nullable restore
#line 48 "F:\转正资料归档\手机审核\2020年7月31日\TradeAudit\TradeAudit\Views\TaskNodeL\MobileGetTaskNodeLstByPageView.cshtml"
WriteAttributeValue("", 1252, Url.Action("MobileGetTaskNodeLstByPageView","TaskNodeL"), 1252, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">审批数据列表</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1354, "\"", 1414, 1);
#nullable restore
#line 49 "F:\转正资料归档\手机审核\2020年7月31日\TradeAudit\TradeAudit\Views\TaskNodeL\MobileGetTaskNodeLstByPageView.cshtml"
WriteAttributeValue("", 1361, Url.Action("MobileGetTaskNodeGroupView","TaskNodeL"), 1361, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">审批数据分组</a></li>\r\n                </ul>\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"layui-card-body\">\r\n                <div class=\"layui-row\" style=\"width: 100%\">\r\n                    <div class=\"layui-col-xs12\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037d8cc876a1826e0e41dfe8f13010909839c3bb7181", async() => {
                WriteLiteral(@"
                            <div class=""layui-row layui-col-space10 layui-form-item"">
                                <div class=""layui-col-lg3"">
                                    <div class=""layui-form-item"">
                                        <label class=""layui-form-label"">装饰A</label>
                                        <div class=""layui-input-block"">
                                            <input type=""text"" name=""FStockName"" autocomplete=""off"" class=""layui-input"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""layui-col-lg3"">
                                    <div class=""layui-form-item"">
                                        <label class=""layui-form-label"">装饰B</label>
                                        <div class=""layui-input-block"">
                                            <input type=""text"" name=""FMaterialName"" autocomplete=""off"" class=");
                WriteLiteral(@"""layui-input"">
                                        </div>
                                    </div>
                                </div>

                                <div class=""layui-inline"">
                                    <div class=""layui-input-block"">
                                        <button class=""layui-btn layuiadmin-btn-list"" lay-filter=""*"" id=""SumitBtnId"">
                                            <i class=""layui-icon layui-icon-search layuiadmin-button-btn""></i>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""layui-card"" style=""width: 100%"">
            <div class=""layui-card-body"">

                <div class=""layui-row"" style=""width: 100%"">
                    <div class=""layui-col-xs12"">
                        <div class=""layui-table-tool"">
                            <div class=""layui-table-tool-temp"">
                                <div class=""layui-btn-container"">
                                    <button id=""BatchSumitButton"" class=""layui-btn layui-btn-sm"" lay-event=""getCheckData"">批量审核</button>
                                    <button id=""BatchRefuseButton"" class=""layui-btn layui-btn-sm"" lay-event=""getCheckLength"">批量拒绝</button>
                                </div>
                            </div>
                        </div>
                        <table id=""baseTable"" class=""cell-border hover"" style=""width: 100%"">
                            <thead>
                    ");
            WriteLiteral(@"            <tr>
                                    <th><input type=""checkbox"" name=""select_all"" id=""select-all"" class=""filled-in chk-col-blue"" /><label for=""select-all""></label></th>
                                    <th></th>
                                    <th>审批编号</th>
                                    <th>审批节点编号</th>
                                    <th>审批角色编号，审批用户</th>
                                    <th>交易编号</th>
                                    <th>是否会签角色</th>
                                    <th>交易方向</th>
                                    <th>交易日期</th>
                                    <th>操作</th>
                                </tr>
                            </thead>

                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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

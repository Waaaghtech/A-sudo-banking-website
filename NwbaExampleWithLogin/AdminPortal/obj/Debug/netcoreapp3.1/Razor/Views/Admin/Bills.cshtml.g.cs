#pragma checksum "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d742110857d67293cf3d20105b8082f720d8f974"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Bills), @"mvc.1.0.view", @"/Views/Admin/Bills.cshtml")]
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
#line 1 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\_ViewImports.cshtml"
using AdminPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\_ViewImports.cshtml"
using AdminPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d742110857d67293cf3d20105b8082f720d8f974", @"/Views/Admin/Bills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7762539535b843c42841939b460dcdaf13e7229b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Bills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminPortal.Models.Bill>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
  
    ViewData["Title"] = "Bills";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>User ");
#nullable restore
#line 7 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
    Write(ViewBag.UserId.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bills</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.BillID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.PayeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.ScheduleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.Period));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.BillID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.PayeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.ScheduleDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.Period));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
               Write(Html.DisplayFor(modelItem => item.ModifyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 68 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
                     if (item.Status == BillStatus.Active)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
                   Write(Html.ActionLink("Block", "BlockBill", new { id = item.BillID, User = ViewBag.UserId }, new { @class="btn btn-warning" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
                     if (item.Status == BillStatus.Blocked)
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
                   Write(Html.ActionLink("UnBlock", "UnBlockbill", new { id = item.BillID, User = ViewBag.UserId }, new { @class="btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\2020Summer\WDT\Assignments\A2\NwbaExampleWithLogin\AdminPortal\Views\Admin\Bills.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n    </tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d742110857d67293cf3d20105b8082f720d8f97411266", async() => {
                WriteLiteral("Back to User List");
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminPortal.Models.Bill>> Html { get; private set; }
    }
}
#pragma warning restore 1591

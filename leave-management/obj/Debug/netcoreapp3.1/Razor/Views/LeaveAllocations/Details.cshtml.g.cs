#pragma checksum "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "238e5e4e7819dc80e4ae2453afce5f868aeac421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveAllocations_Details), @"mvc.1.0.view", @"/Views/LeaveAllocations/Details.cshtml")]
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
#line 1 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\_ViewImports.cshtml"
using leave_management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\_ViewImports.cshtml"
using leave_management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238e5e4e7819dc80e4ae2453afce5f868aeac421", @"/Views/LeaveAllocations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00e77ddfc85c045f6de54f7f6f5b70fff5cde1b1", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveAllocations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<leave_management.Models.ViewAllocationsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Details for - ");
#nullable restore
#line 10 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
                 Write(Model.Employee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
                                           Write(Model.Employee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<hr />\r\n<h2>Leave Allocations</h2>\r\n");
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n        <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 56 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
             foreach (var item in Model.LeaveAllocations)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    <h6>");
#nullable restore
#line 60 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
                   Write(item.LeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <span class=\"badge badge-secondary\">");
#nullable restore
#line 60 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
                                                                             Write(item.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </h6>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238e5e4e7819dc80e4ae2453afce5f868aeac42110512", async() => {
                WriteLiteral("<i class=\"fa fa-pencil\"></i>Edit");
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
#line 61 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 63 "C:\Users\Natacha\source\repos\leave-management\leave-management\Views\LeaveAllocations\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238e5e4e7819dc80e4ae2453afce5f868aeac42113132", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<leave_management.Models.ViewAllocationsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
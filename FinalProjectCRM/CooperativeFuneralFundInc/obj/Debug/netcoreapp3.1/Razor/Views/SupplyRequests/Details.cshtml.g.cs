#pragma checksum "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca979f871d4d8d0d96e760d02bf1ebd4c606d59b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupplyRequests_Details), @"mvc.1.0.view", @"/Views/SupplyRequests/Details.cshtml")]
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
#line 1 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\_ViewImports.cshtml"
using CooperativeFuneralFundInc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\_ViewImports.cshtml"
using CooperativeFuneralFundInc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
using CooperativeFuneralFundInc.Models.SupplyRequest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca979f871d4d8d0d96e760d02bf1ebd4c606d59b", @"/Views/SupplyRequests/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38963efe61eb7c403293e180183734795d526bda", @"/Views/_ViewImports.cshtml")]
    public class Views_SupplyRequests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>SupplyRequest</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SupplyRequestOrigin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.SupplyRequestOrigin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>

<table>
    <thead>
        <tr>
            <th width=""40%"">
                Note
            </th>
            <th width=""30%"">
                Created By
            </th>
            <th width=""20%"">
                Created Date
            </th>
            <th>
                Archived
            </th>
        </tr>
    </thead>
    <tbody>
");
            WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
         foreach (ListTaskSupplyR note in ViewBag.notesList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 106 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
               Write(note.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 109 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
               Write(note.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 112 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
               Write(note.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 115 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
               Write(Html.CheckBoxFor(model => @note.Archived));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 119 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<div>\r\n");
#nullable restore
#line 126 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
     if (User.IsInRole("Visitor"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca979f871d4d8d0d96e760d02bf1ebd4c606d59b15714", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 129 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca979f871d4d8d0d96e760d02bf1ebd4c606d59b17155", async() => {
                WriteLiteral("Edit");
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
#line 132 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
                               WriteLiteral(Model.SupplyRequestId);

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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca979f871d4d8d0d96e760d02bf1ebd4c606d59b19372", async() => {
                WriteLiteral(" Back to List");
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
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Views\SupplyRequests\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11cc4680da211bcedb46c5e9182f2f287b58a29c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SupplyRequests_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/SupplyRequests/Details.cshtml")]
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
#line 100 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
using CooperativeFuneralFundInc.Models.SupplyRequest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11cc4680da211bcedb46c5e9182f2f287b58a29c", @"/Areas/Admin/Views/SupplyRequests/Details.cshtml")]
    public class Areas_Admin_Views_SupplyRequests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>SupplyRequest</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SupplyRequestOrigin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.SupplyRequestOrigin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
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
#line 102 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
         foreach (ListTaskSupplyR note in ViewBag.notesList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 106 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
               Write(note.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 109 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
               Write(note.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 112 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
               Write(note.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 115 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
               Write(Html.CheckBoxFor(model => @note.Archived));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 119 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3558, "\"", 3595, 1);
#nullable restore
#line 125 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Details.cshtml"
WriteAttributeValue("", 3573, Model.SupplyRequestId, 3573, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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

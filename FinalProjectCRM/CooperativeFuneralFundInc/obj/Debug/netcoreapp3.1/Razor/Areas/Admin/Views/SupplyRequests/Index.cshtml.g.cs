#pragma checksum "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098b0ee48371f55c8dfc484c08389985d15ff810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SupplyRequests_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SupplyRequests/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098b0ee48371f55c8dfc484c08389985d15ff810", @"/Areas/Admin/Views/SupplyRequests/Index.cshtml")]
    public class Areas_Admin_Views_SupplyRequests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Requests</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StatusComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SupplyRequestOrigin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StatusComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SupplyRequestOrigin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequestType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2649, "\"", 2685, 1);
#nullable restore
#line 87 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
WriteAttributeValue("", 2664, item.SupplyRequestId, 2664, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2738, "\"", 2774, 1);
#nullable restore
#line 88 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
WriteAttributeValue("", 2753, item.SupplyRequestId, 2753, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2829, "\"", 2865, 1);
#nullable restore
#line 89 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
WriteAttributeValue("", 2844, item.SupplyRequestId, 2844, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 92 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591

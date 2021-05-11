#pragma checksum "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae10e982b6533ba42c0bedf5525aea88eaaca7be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SupplyRequests_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/SupplyRequests/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae10e982b6533ba42c0bedf5525aea88eaaca7be", @"/Areas/Admin/Views/SupplyRequests/Edit.cshtml")]
    public class Areas_Admin_Views_SupplyRequests_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>SupplyRequest</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""SupplyRequestId"" />
            <div class=""form-group"">
                <label asp-for=""Status"" class=""control-label""></label>
                <select asp-for=""Status"" class=""form-control"" asp-items=""ViewBag.Status""></select>
                <span asp-validation-for=""Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StatusComments"" class=""control-label""></label>
                <input asp-for=""StatusComments"" class=""form-control"" />
                <span asp-validation-for=""StatusComments"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderItemsID"" class=""control-label""></label>
                <select as");
            WriteLiteral(@"p-for=""OrderItemsID"" class=""form-control"" asp-items=""ViewBag.OrderItemsID""></select>
                <span asp-validation-for=""OrderItemsID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RequestOriginId"" class=""control-label""></label>
                <select asp-for=""RequestOriginId"" class=""form-control"" asp-items=""ViewBag.RequestOriginId""></select>
                <span asp-validation-for=""RequestOriginId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RequestType"" class=""control-label""></label>
                <select asp-for=""RequestType"" class=""form-control"" asp-items=""ViewBag.RequestType""></select>
                <span asp-validation-for=""RequestType"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ClientSupplierID"" class=""control-label""></label>
                <select asp-for=""Client");
            WriteLiteral(@"SupplierID"" class=""form-control"" asp-items=""ViewBag.ClientSupplierID""></select>
                <span asp-validation-for=""ClientSupplierID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Owner"" class=""control-label""></label>
                <select asp-for=""Owner"" class=""form-control"" asp-items=""ViewBag.Owner""></select>
                <span asp-validation-for=""Owner"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedBy"" class=""control-label""></label>
                <input asp-for=""CreatedBy"" class=""form-control"" />
                <span asp-validation-for=""CreatedBy"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreateTime"" class=""control-label""></label>
                <input asp-for=""CreateTime"" class=""form-control"" />
                <span asp-validation-for=""CreateTime"" class=""te");
            WriteLiteral(@"xt-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedBy"" class=""control-label""></label>
                <input asp-for=""UpdatedBy"" class=""form-control"" />
                <span asp-validation-for=""UpdatedBy"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedTime"" class=""control-label""></label>
                <input asp-for=""UpdatedTime"" class=""form-control"" />
                <span asp-validation-for=""UpdatedTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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

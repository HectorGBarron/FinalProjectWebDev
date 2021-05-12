#pragma checksum "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1675fb8b1cce7b80956e4fac5550bf99d9da914"
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
#nullable restore
#line 78 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
using CooperativeFuneralFundInc.Models.SupplyRequest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1675fb8b1cce7b80956e4fac5550bf99d9da914", @"/Areas/Admin/Views/SupplyRequests/Edit.cshtml")]
    public class Areas_Admin_Views_SupplyRequests_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CooperativeFuneralFundInc.Models.SupplyRequest.SupplyRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
  
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

");
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
 foreach (ListTaskSupplyR note in ViewBag.notesList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <form>\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-5\">\r\n                <label>\r\n                    Note\r\n                </label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4307, "\"", 4325, 1);
#nullable restore
#line 88 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
WriteAttributeValue("", 4315, note.Note, 4315, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group col-md-2\">\r\n                <label>\r\n                    Created Date\r\n                </label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4538, "\"", 4563, 1);
#nullable restore
#line 94 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
WriteAttributeValue("", 4546, note.CreatedDate, 4546, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group col-md-4\">\r\n                <label>\r\n                    Created By\r\n                </label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 4776, "\"", 4799, 1);
#nullable restore
#line 101 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
WriteAttributeValue("", 4784, note.CreatedBy, 4784, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group col-md-1\">\r\n                <label>\r\n                    Archived\r\n                </label>\r\n                <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5008, "\"", 5030, 1);
#nullable restore
#line 107 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
WriteAttributeValue("", 5016, note.Archived, 5016, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"invisible\">\r\n                ");
#nullable restore
#line 110 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
           Write(note.ListTaskSupplyRId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </form>\r\n");
#nullable restore
#line 116 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 123 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\SupplyRequests\Edit.cshtml"
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

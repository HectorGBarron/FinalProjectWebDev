#pragma checksum "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50b49460903b3b69d5f75c26d04e82a84bfb8656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Owners_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Owners/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50b49460903b3b69d5f75c26d04e82a84bfb8656", @"/Areas/Admin/Views/Owners/Details.cshtml")]
    public class Areas_Admin_Views_Owners_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CooperativeFuneralFundInc.Models.DropDownMenu.Owner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Owner</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 451, "\"", 480, 1);
#nullable restore
#line 22 "C:\Users\Banso\OneDrive\Desktop\Pull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Details.cshtml"
WriteAttributeValue("", 466, Model.OwnerId, 466, 14, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CooperativeFuneralFundInc.Models.DropDownMenu.Owner> Html { get; private set; }
    }
}
#pragma warning restore 1591

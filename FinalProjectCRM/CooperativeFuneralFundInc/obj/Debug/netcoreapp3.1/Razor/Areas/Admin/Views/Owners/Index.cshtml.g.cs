#pragma checksum "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d7b455dbdd8d475feaadb3dfd08047a03a5a35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Owners_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Owners/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d7b455dbdd8d475feaadb3dfd08047a03a5a35", @"/Areas/Admin/Views/Owners/Index.cshtml")]
    public class Areas_Admin_Views_Owners_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CooperativeFuneralFundInc.Models.DropDownMenu.Owner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 606, "\"", 634, 1);
#nullable restore
#line 28 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
WriteAttributeValue("", 621, item.OwnerId, 621, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 687, "\"", 715, 1);
#nullable restore
#line 29 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
WriteAttributeValue("", 702, item.OwnerId, 702, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 770, "\"", 798, 1);
#nullable restore
#line 30 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
WriteAttributeValue("", 785, item.OwnerId, 785, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Banso\OneDrive\Desktop\temPull\FinalProjectWebDev\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Owners\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CooperativeFuneralFundInc.Models.DropDownMenu.Owner>> Html { get; private set; }
    }
}
#pragma warning restore 1591

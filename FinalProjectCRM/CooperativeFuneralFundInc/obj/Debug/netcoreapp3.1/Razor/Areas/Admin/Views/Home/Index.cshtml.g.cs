#pragma checksum "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77542c3712b3a8aba6e53db4feb4d6752878a4af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 11 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Home\Index.cshtml"
using CooperativeFuneralFundInc.Models.UserManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77542c3712b3a8aba6e53db4feb4d6752878a4af", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to the Admin Section</h1>\r\n\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Home\Index.cshtml"
 if (signInManager.IsSignedIn(User))
{
    // signed-in user - shows the menu

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n\r\n        <a class=\"nav-link btn btn-outline-secondary text-white\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 464, "\"", 475, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"TaskManagements\" asp-action=\"Create\">Create Task</a>\r\n    </li>\r\n");
#nullable restore
#line 23 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Home\Index.cshtml"
}
else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        To begin please sign in\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Hector\Google Drive\Software Engineering\Web Development II\Final Project\FinalProjectCRM\CooperativeFuneralFundInc\Areas\Admin\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; }
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

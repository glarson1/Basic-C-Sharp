#pragma checksum "C:\Users\gabri\OneDrive\Documents\GitHub\Basic-C-Sharp\ChallengeSubmission\ChallengeSubmission\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279efceb005cbb92e422bc9ef5ccbd674d04e739"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChallengeSubmission.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ChallengeSubmission.Pages
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
#line 1 "C:\Users\gabri\OneDrive\Documents\GitHub\Basic-C-Sharp\ChallengeSubmission\ChallengeSubmission\Pages\_ViewImports.cshtml"
using ChallengeSubmission;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279efceb005cbb92e422bc9ef5ccbd674d04e739", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aebe13d89973ebdcba9e63fe3ad967214a01283", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gabri\OneDrive\Documents\GitHub\Basic-C-Sharp\ChallengeSubmission\ChallengeSubmission\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\gabri\OneDrive\Documents\GitHub\Basic-C-Sharp\ChallengeSubmission\ChallengeSubmission\Pages\Index.cshtml"
     var serverTime = DateTime.Now; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <h1> The server time is ");
#nullable restore
#line 14 "C:\Users\gabri\OneDrive\Documents\GitHub\Basic-C-Sharp\ChallengeSubmission\ChallengeSubmission\Pages\Index.cshtml"
                     Write(serverTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n  \r\n");
#nullable restore
#line 17 "C:\Users\gabri\OneDrive\Documents\GitHub\Basic-C-Sharp\ChallengeSubmission\ChallengeSubmission\Pages\Index.cshtml"
     var msg = " and here are some numbers 3453534";

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2> Here is some text ");
#nullable restore
#line 18 "C:\Users\gabri\OneDrive\Documents\GitHub\Basic-C-Sharp\ChallengeSubmission\ChallengeSubmission\Pages\Index.cshtml"
                    Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32cf66e95c4507fabeff72667eda5b87f4eddc81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LocalisationDemo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace LocalisationDemo.Pages
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
#line 1 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\_ViewImports.cshtml"
using LocalisationDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\_ViewImports.cshtml"
using LocalisationDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\_ViewImports.cshtml"
using LocalisationDemo.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cf66e95c4507fabeff72667eda5b87f4eddc81", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fefd9e3a4a2a453a0111426a501ee3b5013a838", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var requestCultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
    var requestCulture = requestCultureFeature.RequestCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div class=\"text-center\">\r\n");
            WriteLiteral("        <p>");
#nullable restore
#line 14 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
      Write(htmlLocalizer["Learn"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <table class=\"table culture-table\">\r\n            <tr>\r\n                <td style=\"width:50%;\">Culture</td>\r\n                <td>");
#nullable restore
#line 20 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
               Write(requestCulture.Culture.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" {");
#nullable restore
#line 20 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
                                                    Write(requestCulture.Culture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("}</td>\r\n            </tr>\r\n            <tr>\r\n                <td>UI Culture</td>\r\n                <td>");
#nullable restore
#line 24 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
               Write(requestCulture.UICulture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>UICulture Parent</td>\r\n                <td>");
#nullable restore
#line 28 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
               Write(requestCulture.UICulture.Parent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Date</td>\r\n                <td>");
#nullable restore
#line 32 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
               Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Currency</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
                Write(12345.00.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Number</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\software_developer\asp.net-core\browser-language\BrowserLanguage\LocalisationDemo\Pages\Index.cshtml"
                Write(123.45m.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<IndexModel> htmlLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<IndexModel> localizer { get; private set; }
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

#pragma checksum "D:\Amit\dotnet\azure\dotnet-docker-master\samples\aspnetapp\aspnetapp\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a7af7554c7e7b775d81593b77fb6a6a4aacafda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "D:\Amit\dotnet\azure\dotnet-docker-master\samples\aspnetapp\aspnetapp\Views\_ViewImports.cshtml"
using aspnetapp;

#line default
#line hidden
#line 2 "D:\Amit\dotnet\azure\dotnet-docker-master\samples\aspnetapp\aspnetapp\Views\_ViewImports.cshtml"
using aspnetapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a7af7554c7e7b775d81593b77fb6a6a4aacafda", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4283e6f91aef2c575f4199e5587c4dde41a7c0f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Amit\dotnet\azure\dotnet-docker-master\samples\aspnetapp\aspnetapp\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(40, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(45, 17, false);
#line 4 "D:\Amit\dotnet\azure\dotnet-docker-master\samples\aspnetapp\aspnetapp\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(62, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(73, 19, false);
#line 5 "D:\Amit\dotnet\azure\dotnet-docker-master\samples\aspnetapp\aspnetapp\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(92, 170, true);
            WriteLiteral("</h3>\n\n<address>\n    U.S. Bank\n</address>\n\n<address>\n    <strong>Support:</strong> <a href=\"mailto:amit.mahadar@usbank.com\">amit.mahadar@usbank.com</a><br />\n </address>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

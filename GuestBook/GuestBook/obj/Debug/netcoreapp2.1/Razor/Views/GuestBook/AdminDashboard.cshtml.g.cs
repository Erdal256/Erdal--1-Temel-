#pragma checksum "C:\Users\ERDAL-PC\Desktop\GIT\YMS8518-master\GuestBook\GuestBook\Views\GuestBook\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8996e156032a6cfc7d266711fb6daadfc87484bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GuestBook_AdminDashboard), @"mvc.1.0.view", @"/Views/GuestBook/AdminDashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GuestBook/AdminDashboard.cshtml", typeof(AspNetCore.Views_GuestBook_AdminDashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8996e156032a6cfc7d266711fb6daadfc87484bc", @"/Views/GuestBook/AdminDashboard.cshtml")]
    public class Views_GuestBook_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ERDAL-PC\Desktop\GIT\YMS8518-master\GuestBook\GuestBook\Views\GuestBook\AdminDashboard.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 3, true);
            WriteLiteral("\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 32, "\"", 78, 1);
#line 5 "C:\Users\ERDAL-PC\Desktop\GIT\YMS8518-master\GuestBook\GuestBook\Views\GuestBook\AdminDashboard.cshtml"
WriteAttributeValue("", 39, Url.Action("LogoutAction","GuestBook"), 39, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(79, 14, true);
            WriteLiteral(">Çıkış Yap</a>");
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

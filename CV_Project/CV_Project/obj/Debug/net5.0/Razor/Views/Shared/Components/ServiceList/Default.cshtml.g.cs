#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ServiceList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04fdd2c4213fca89e61c55bb1634374b5f472983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/_ViewImports.cshtml"
using CV_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/_ViewImports.cshtml"
using CV_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ServiceList/Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fdd2c4213fca89e61c55bb1634374b5f472983", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"services\">\n\t<div class=\"container-narrow\">\n\t\t<div class=\"text-center mb-5\">\n\t\t\t<h2 class=\"marker marker-center\">Hizmetlerim</h2>\n\t\t</div>\n\t\t<div class=\"row py-3\">\n");
#nullable restore
#line 10 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ServiceList/Default.cshtml"
             foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-md-3 text-center\" data-aos=\"fade-up\" data-aos-delay=\"100\">\n\t\t\t\t<img class=\"mb-2\"");
            BeginWriteAttribute("src", " src=\"", 405, "\"", 425, 1);
#nullable restore
#line 13 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ServiceList/Default.cshtml"
WriteAttributeValue("", 411, item.ImageUrl, 411, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"web design\" />\n\t\t\t\t<div class=\"h5\">");
#nullable restore
#line 14 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ServiceList/Default.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t\t</div>\n");
#nullable restore
#line 16 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ServiceList/Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\n\t</div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591

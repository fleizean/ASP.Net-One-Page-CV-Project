#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad87220bf7ff847abece4d60389756723a634864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialMediaFooterList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SocialMediaFooterList/Default.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad87220bf7ff847abece4d60389756723a634864", @"/Views/Shared/Components/SocialMediaFooterList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SocialMediaFooterList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"social-nav\">\n    <nav role=\"navigation\">\n        <ul class=\"nav justify-content-center\">\n");
#nullable restore
#line 7 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
             foreach (var item in Model)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
                 if (item.Status == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\"><a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 338, "\"", 354, 1);
#nullable restore
#line 11 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
WriteAttributeValue("", 345, item.Url, 345, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 355, "\"", 373, 1);
#nullable restore
#line 11 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
WriteAttributeValue("", 363, item.Name, 363, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 377, "\"", 402, 3);
            WriteAttributeValue("", 385, "fab", 385, 3, true);
            WriteAttributeValue(" ", 388, "fa-", 389, 4, true);
#nullable restore
#line 11 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
WriteAttributeValue("", 392, item.Icon, 392, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><span class=\"menu-title sr-only\">");
#nullable restore
#line 11 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
                                                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\n");
#nullable restore
#line 12 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/SocialMediaFooterList/Default.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n    </nav>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4678b22e4106f5148c923a24fdcad3d2ac69069c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialsList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialsList/Default.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4678b22e4106f5148c923a24fdcad3d2ac69069c", @"/Views/Shared/Components/TestimonialsList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TestimonialsList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonials>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"testimonials\">\n    <div class=\"container-narrow\">\n        <div class=\"text-center mb-5\">\n            <h2 class=\"marker marker-center\">Müşteri Yorumları</h2>\n        </div>\n        <div class=\"row\">\n");
#nullable restore
#line 10 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
             for (int i = 0; i < Model.Count; i += 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 mb-5\" data-aos=\"fade-right\" data-aos-delay=\"100\">\n                <div class=\"d-flex ms-md-3\"><span><i class=\"fas fa-2x fa-quote-left\"></i></span><span class=\"m-2\">");
#nullable restore
#line 13 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                                                                                                             Write(Model[i].Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n                <div class=\"d-flex justify-content-end align-items-end\">\n                    <div class=\"text-end me-2\">\n                        <div class=\"fw-bolder\">");
#nullable restore
#line 16 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                                          Write(Model[i].ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div class=\"text-small\">");
#nullable restore
#line 17 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                                           Write(Model[i].Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div><img class=\"me-md-3 rounded\"");
            BeginWriteAttribute("src", " src=\"", 917, "\"", 941, 1);
#nullable restore
#line 18 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
WriteAttributeValue("", 923, Model[i].ImageUrl, 923, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"client 1\" />\n                </div>\n            </div>\n");
#nullable restore
#line 21 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
             if (i + 1 < Model.Count)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 mb-5\" data-aos=\"fade-left\" data-aos-delay=\"300\">\n                <div class=\"d-flex ms-md-3\"><span><i class=\"fas fa-2x fa-quote-left\"></i></span><span class=\"m-2\">");
#nullable restore
#line 24 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                                                                                                             Write(Model[i + 1].Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n                <div class=\"d-flex justify-content-end align-items-end\">\n                    <div class=\"text-end me-2\">\n                        <div class=\"fw-bolder\">");
#nullable restore
#line 27 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                                          Write(Model[i + 1].ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div class=\"text-small\">");
#nullable restore
#line 28 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                                           Write(Model[i + 1].Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div><img class=\"me-md-3 rounded\"");
            BeginWriteAttribute("src", " src=\"", 1642, "\"", 1670, 1);
#nullable restore
#line 29 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
WriteAttributeValue("", 1648, Model[i + 1].ImageUrl, 1648, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"client 1\" />\n                </div>\n            </div>\n");
#nullable restore
#line 32 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/TestimonialsList/Default.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonials>> Html { get; private set; }
    }
}
#pragma warning restore 1591

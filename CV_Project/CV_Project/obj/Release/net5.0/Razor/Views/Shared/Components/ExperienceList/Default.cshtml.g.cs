#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c534d73a55ebfc425ff4e74025f6440c9940518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c534d73a55ebfc425ff4e74025f6440c9940518", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ExperienceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"experience\">\n\t<div class=\"container-narrow\">\n\t\t<div class=\"text-center mb-5\">\n\t\t\t<h2 class=\"marker marker-center\">Deneyimlerim</h2>\n\t\t</div>\n\t\t<div class=\"row\">\n");
#nullable restore
#line 10 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
             for (int i = 0; i < Model.Count; i += 2)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-6\">\n\t\t\t\t\t<div class=\"card mb-3\" data-aos=\"fade-right\" data-aos-delay=\"100\">\n\t\t\t\t\t\t<div class=\"card-header px-3 py-2\">\n\t\t\t\t\t\t\t<div class=\"d-flex justify-content-between\">\n\t\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t\t<h3 class=\"h5 mb-1\">");
#nullable restore
#line 17 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                                                   Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t\t\t\t\t\t\t\t<div class=\"text-muted text-small\"><small>(");
#nullable restore
#line 18 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                                                                          Write(Model[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small></div>\n\t\t\t\t\t\t\t\t</div><img");
            BeginWriteAttribute("src", " src=\"", 663, "\"", 687, 1);
#nullable restore
#line 19 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
WriteAttributeValue("", 669, Model[i].ImageUrl, 669, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" height=\"48\" alt=\"ui-ux\" />\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t<div class=\"card-body px-3 py-2\">\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 23 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                          Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n");
#nullable restore
#line 27 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                 if (i + 1 < Model.Count)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"col-md-6\">\n\t\t\t\t\t\t<div class=\"card mb-3\" data-aos=\"fade-left\" data-aos-delay=\"300\">\n\t\t\t\t\t\t\t<div class=\"card-header px-3 py-2\">\n\t\t\t\t\t\t\t\t<div class=\"d-flex justify-content-between\">\n\t\t\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t\t\t<h3 class=\"h5 mb-1\">");
#nullable restore
#line 34 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                                                       Write(Model[i + 1].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t\t\t\t\t\t\t\t\t<div class=\"text-muted text-small\"><small>(");
#nullable restore
#line 35 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                                                                              Write(Model[i + 1].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small></div>\n\t\t\t\t\t\t\t\t\t</div><img");
            BeginWriteAttribute("src", " src=\"", 1274, "\"", 1302, 1);
#nullable restore
#line 36 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
WriteAttributeValue("", 1280, Model[i + 1].ImageUrl, 1280, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" height=\"48\" alt=\"app development\" />\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"card-body px-3 py-2\">\n                                <p>");
#nullable restore
#line 40 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                              Write(Model[i + 1].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\t\t\t\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n");
#nullable restore
#line 44 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/ExperienceList/Default.cshtml"
                         
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\n\t\t</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591

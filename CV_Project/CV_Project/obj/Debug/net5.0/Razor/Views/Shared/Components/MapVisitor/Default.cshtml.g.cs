#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/MapVisitor/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb4c4f46bd7d7ded5b0997744a9eead2ba77eee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MapVisitor_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MapVisitor/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb4c4f46bd7d7ded5b0997744a9eead2ba77eee", @"/Views/Shared/Components/MapVisitor/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MapVisitor_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Ziyaret Edilen Ülkeler</h4>
                <div class=""row"">
                    <div class=""col-md-5"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <tbody>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-tr""></i>
                                        </td>
                                        <td>Türkiye</td>
                                        <td class=""text-right""> 1500 </td>
                                        <td class=""text-right font-weight-medium""> 56.35% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag");
            WriteLiteral(@"-icon flag-icon-de""></i>
                                        </td>
                                        <td>Almanya</td>
                                        <td class=""text-right""> 800 </td>
                                        <td class=""text-right font-weight-medium""> 33.25% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-au""></i>
                                        </td>
                                        <td>Avustralya</td>
                                        <td class=""text-right""> 760 </td>
                                        <td class=""text-right font-weight-medium""> 15.45% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-gb""></i>
                            ");
            WriteLiteral(@"            </td>
                                        <td>İngiltere</td>
                                        <td class=""text-right""> 450 </td>
                                        <td class=""text-right font-weight-medium""> 25.00% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-ro""></i>
                                        </td>
                                        <td>Romanya</td>
                                        <td class=""text-right""> 620 </td>
                                        <td class=""text-right font-weight-medium""> 10.25% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-br""></i>
                                        </td>
                                    ");
            WriteLiteral(@"    <td>Brezilya</td>
                                        <td class=""text-right""> 230 </td>
                                        <td class=""text-right font-weight-medium""> 75.00% </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-md-7"">
                        <div id=""audience-map"" class=""vector-map""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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

#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/StatisticsDashboard2/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8eb82783909730b5f3f80167720bac38ecfe62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_StatisticsDashboard2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/StatisticsDashboard2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8eb82783909730b5f3f80167720bac38ecfe62", @"/Views/Shared/Components/StatisticsDashboard2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_StatisticsDashboard2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Proje Sayısı</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 9 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/StatisticsDashboard2/Default.cshtml"
                                        Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Aktif ve tamamlanan proje sayısı</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-codepen text-primary ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Mesaj Sayısı</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 27 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/StatisticsDashboard2/Default.cshtml"
                                        Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Son 1 aydaki mesajlar</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-wallet-travel text-danger ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Hizmetler</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
#nullable restore
#line 45 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Shared/Components/StatisticsDashboard2/Default.cshtml"
                                        Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Verilen hizmet sayısı</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-monitor text-success ml-auto""></i>
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

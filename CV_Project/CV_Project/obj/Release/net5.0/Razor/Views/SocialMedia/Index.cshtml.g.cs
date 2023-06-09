#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9adca1edadcfd33690b1803b59fc6c427af41f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedia_Index), @"mvc.1.0.view", @"/Views/SocialMedia/Index.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9adca1edadcfd33690b1803b59fc6c427af41f03", @"/Views/SocialMedia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_SocialMedia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                            <th>Sosyal Medya</th>
                            <th>Url</th>
                            <th>Icon İsim</th>
                            <th>Durum</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td style=\"color:white; font-weight:bold\">");
#nullable restore
#line 27 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                                                                     Write(item.SocialMediaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td style=\"color:white\">");
#nullable restore
#line 28 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td style=\"color:blueviolet\"><a");
            BeginWriteAttribute("href", " href=\"", 1169, "\"", 1185, 1);
#nullable restore
#line 29 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
WriteAttributeValue("", 1176, item.Url, 1176, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Tıkla</a></td>\n                                <td style=\"color:white\">fab fa-<strong>");
#nullable restore
#line 30 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                                                                  Write(item.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n");
#nullable restore
#line 31 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                                 if (item.Status == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"label label-success\" style=\"color:green; font-weight:bold\">Aktif</span></td>\n");
#nullable restore
#line 34 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"label label-warning\" style=\"color: red; font-weight: bold\">Pasif</span></td>\n");
#nullable restore
#line 38 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1843, "\"", 1900, 2);
            WriteAttributeValue("", 1850, "/SocialMedia/DeleteSocialMedia/", 1850, 31, true);
#nullable restore
#line 39 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
WriteAttributeValue("", 1881, item.SocialMediaID, 1881, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" onclick=\"return confirm(\'Gerçekten silmek istiyor musunuz?\')\">Sil</a></td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2046, "\"", 2101, 2);
            WriteAttributeValue("", 2053, "/SocialMedia/EditSocialMedia/", 2053, 29, true);
#nullable restore
#line 40 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
WriteAttributeValue("", 2082, item.SocialMediaID, 2082, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\n                            </tr>\n");
#nullable restore
#line 42 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/SocialMedia/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <div style=""text-align: left;"">
                    <br />
                    <a href=""/SocialMedia/AddSocialMedia/"" class=""btn btn-outline-info"">Yeni Sosyal Medya Ekle</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591

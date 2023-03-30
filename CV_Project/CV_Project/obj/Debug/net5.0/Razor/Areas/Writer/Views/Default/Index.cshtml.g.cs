#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcd6d2e8f3815255df76bd2e8d07dfa018c2b3d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/Index.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd6d2e8f3815255df76bd2e8d07dfa018c2b3d7", @"/Areas/Writer/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
   string color = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Duyurular</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Konu</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
                         foreach (var item in Model)
                            {
                                if(item.Status == "Duyuru")
                                {
                                    color = "badge badge-danger";
                                }
                                else if(item.Status == "Önemli Duyuru")
                                {
                                    color = "badge badge-warning";
                                }
                                else if (item.Status == "İlk Duyuru")
                                {
                                    color = "badge badge-success";
                                }
                                else if (item.Status == "Yeni Referans" || item.Status == "Yeni Servis")
                                {
                                    color = "badge badge-info";
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 44 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
                           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 45 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
                            Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><label");
            BeginWriteAttribute("class", " class=\"", 1969, "\"", 1983, 1);
#nullable restore
#line 47 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
WriteAttributeValue("", 1977, color, 1977, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
                                                 Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2046, "\"", 2097, 2);
            WriteAttributeValue("", 2053, "/Writer/Default/AnnouncementDetails/", 2053, 36, true);
#nullable restore
#line 48 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
WriteAttributeValue("", 2089, item.ID, 2089, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detayı Gör</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 50 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Areas/Writer/Views/Default/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591

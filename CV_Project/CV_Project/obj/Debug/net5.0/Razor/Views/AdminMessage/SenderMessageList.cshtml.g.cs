#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab72fdcfcfc9c4dc89106cca1534dcc5da5a5d85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_SenderMessageList), @"mvc.1.0.view", @"/Views/AdminMessage/SenderMessageList.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab72fdcfcfc9c4dc89106cca1534dcc5da5a5d85", @"/Views/AdminMessage/SenderMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMessage_SenderMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SenderReceiverMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
  
    ViewData["Title"] = "SenderMessageList";
    Layout = "/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Giden Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Alıcı</th>
                            <th>Tarih</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 23 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
                         foreach (var group in Model.GroupBy(x => x.Sender))
                        {
                            var sender = group.Key;
                            var message = group.First();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <th>");
#nullable restore
#line 28 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
                               Write(message.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                <td>");
#nullable restore
#line 29 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
                               Write(message.Receiver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 30 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
                                Write(((DateTime)message.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1208, "\"", 1303, 4);
            WriteAttributeValue("", 1215, "/AdminMessage/SenderMessageListDetails?sender=", 1215, 46, true);
#nullable restore
#line 31 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
WriteAttributeValue("", 1261, message.Sender, 1261, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1276, "&receiver=", 1276, 10, true);
#nullable restore
#line 31 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
WriteAttributeValue("", 1286, message.Receiver, 1286, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Mesajı Gör</a></td>\n                            </tr>\n");
#nullable restore
#line 33 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/AdminMessage/SenderMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SenderReceiverMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591

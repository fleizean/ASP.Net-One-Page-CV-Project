#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Service/AddService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e7823a02c00c6330142bc7c8a119b8c87f3303"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_AddService), @"mvc.1.0.view", @"/Views/Service/AddService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e7823a02c00c6330142bc7c8a119b8c87f3303", @"/Views/Service/AddService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_AddService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Service>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Service/AddService.cshtml"
  
    ViewData["Title"] = "AddService";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"col-12 grid-margin stretch-card\">\n    <div class=\"card\">\n        <div class=\"card-body\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e7823a02c00c6330142bc7c8a119b8c87f33034318", async() => {
                WriteLiteral("\n                <div class=\"form-group\">\n                    <label>Başlık</label>\n                    ");
#nullable restore
#line 14 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Service/AddService.cshtml"
               Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <label>Görsel</label>\n                    ");
#nullable restore
#line 18 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Service/AddService.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <button type=\"submit\" class=\"btn btn-primary mr-2\">Kaydet</button>\n                <button type=\"button\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 816, "\"", 873, 3);
                WriteAttributeValue("", 826, "location.href=\'", 826, 15, true);
#nullable restore
#line 21 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Service/AddService.cshtml"
WriteAttributeValue("", 841, Url.Action("Index", "Service"), 841, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 872, "\'", 872, 1, true);
                EndWriteAttribute();
                WriteLiteral(">İptal</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Service> Html { get; private set; }
    }
}
#pragma warning restore 1591

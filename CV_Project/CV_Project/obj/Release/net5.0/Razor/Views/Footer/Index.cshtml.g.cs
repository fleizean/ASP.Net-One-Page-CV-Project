#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Footer/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fba1e43f4db18be2111ba2e67c546ec0f0577c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Footer_Index), @"mvc.1.0.view", @"/Views/Footer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fba1e43f4db18be2111ba2e67c546ec0f0577c1", @"/Views/Footer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dce1652973fe689b8e473050606de95c6a86ce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Footer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Footer>
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
#nullable restore
#line 2 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Footer/Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"col-12 grid-margin stretch-card\">\n\t<div class=\"card\">\n\t\t<div class=\"card-body\">\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fba1e43f4db18be2111ba2e67c546ec0f0577c14226", async() => {
                WriteLiteral("\n\t\t\t\t<div class=\"form-group\">\n\t\t\t\t\t<label>ID</label>\n\t\t\t\t\t");
#nullable restore
#line 13 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Footer/Index.cshtml"
               Write(Html.TextBoxFor(x => x.FooterID, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"form-group\">\n\t\t\t\t\t<label>Başlık</label>\n\t\t\t\t\t");
#nullable restore
#line 17 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Footer/Index.cshtml"
               Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"form-group\">\n\t\t\t\t\t<label>Açıklama</label>\n\t\t\t\t\t");
#nullable restore
#line 21 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Footer/Index.cshtml"
               Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"form-group\">\n\t\t\t\t\t<label>Alt Açıklama</label>\n\t\t\t\t\t");
#nullable restore
#line 25 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Footer/Index.cshtml"
               Write(Html.TextBoxFor(x => x.SubDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<button type=\"submit\" class=\"btn btn-success mr-2\">Güncelle</button>\n\t\t\t\t<button type=\"button\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 970, "\"", 1029, 3);
                WriteAttributeValue("", 980, "location.href=\'", 980, 15, true);
#nullable restore
#line 28 "/Users/fleizean/Desktop/Self-Project/Asp.Net/CV_Project/CV_Project/Views/Footer/Index.cshtml"
WriteAttributeValue("", 995, Url.Action("Index", "Dashboard"), 995, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1028, "\'", 1028, 1, true);
                EndWriteAttribute();
                WriteLiteral(">İptal</button>\n\t\t\t");
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
            WriteLiteral("\n\t\t</div>\n\t</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Footer> Html { get; private set; }
    }
}
#pragma warning restore 1591

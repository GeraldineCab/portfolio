#pragma checksum "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\LetsTalk.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915d77eb3e24ba22cd8e9b485bf4684ec4f9df6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PersonalWebsite.Pages.Pages_LetsTalk), @"mvc.1.0.razor-page", @"/Pages/LetsTalk.cshtml")]
namespace PersonalWebsite.Pages
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
#line 1 "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\_ViewImports.cshtml"
using PersonalWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\LetsTalk.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915d77eb3e24ba22cd8e9b485bf4684ec4f9df6d", @"/Pages/LetsTalk.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f433f8c1562ea99707f041812471bc667fce2ced", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LetsTalk : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/email.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-icon mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/linkedin.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\LetsTalk.cshtml"
  
    ViewData["Title"] = Localizer["PagesTitle"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-12\">\r\n        <h5 class=\"font-weight-bold text-center\">");
#nullable restore
#line 13 "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\LetsTalk.cshtml"
                                            Write(Localizer["WriteMe"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"text-muted text-center\">");
#nullable restore
#line 14 "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\LetsTalk.cshtml"
                                     Write(Localizer["ContactIntroduction"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
    <div class=""col-12 col-lg-3 mt-5"">
        <a href=""mailto:geraldinecaby@gmail.com"" class=""text-white text-decoration-none"">
            <div class=""main-color-bg text-white rounded-lg p-3 d-flex flex-column align-items-center contact-button"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "915d77eb3e24ba22cd8e9b485bf4684ec4f9df6d5544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\LetsTalk.cshtml"
           Write(Localizer["WriteEmail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </a>
    </div>
    <div class=""col-12 col-lg-3 mt-5"">
        <a href=""https://www.linkedin.com/in/geraldinecabrera/"" target=""_blank"" class=""text-white text-decoration-none"">
            <div class=""main-color-bg text-white rounded-lg p-3 d-flex flex-column align-items-center contact-button"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "915d77eb3e24ba22cd8e9b485bf4684ec4f9df6d7275", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\Geraldine Cabrera\Documents\Git\portfolio\PersonalWebsite\Pages\LetsTalk.cshtml"
           Write(Localizer["LinkedInContact"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </a>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalWebsite.LetsTalkModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonalWebsite.LetsTalkModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonalWebsite.LetsTalkModel>)PageContext?.ViewData;
        public PersonalWebsite.LetsTalkModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

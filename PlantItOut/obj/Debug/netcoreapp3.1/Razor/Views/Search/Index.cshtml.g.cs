#pragma checksum "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "375cd583a39d18c9bf0da641d8acbe97c99be91b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PlantItOut.Pages.Search.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
namespace PlantItOut.Pages.Search
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
#line 1 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\_ViewImports.cshtml"
using PlantItOut;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"375cd583a39d18c9bf0da641d8acbe97c99be91b", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb86dbb3a943fd0c1dfff658b7fc20eb61bddf42", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search/results"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container body-content\">\r\n\r\n    <h1>");
#nullable restore
#line 3 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
   Write(ViewBag.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "375cd583a39d18c9bf0da641d8acbe97c99be91b4041", async() => {
                WriteLiteral("\r\n        <h2>Search by:</h2>\r\n\r\n        <p>\r\n");
#nullable restore
#line 9 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
             foreach (var column in ViewBag.columns)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span>\r\n                    <input type=\"radio\" name=\"searchType\"");
                BeginWriteAttribute("id", " id=\"", 316, "\"", 332, 1);
#nullable restore
#line 12 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
WriteAttributeValue("", 321, column.Key, 321, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 333, "\"", 352, 1);
#nullable restore
#line 12 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
WriteAttributeValue("", 341, column.Key, 341, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\"", 353, "\"", 383, 3);
#nullable restore
#line 12 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
WriteAttributeValue("", 363, column.Key, 363, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 374, "==", 375, 3, true);
                WriteAttributeValue(" ", 377, "\'all\'", 378, 6, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 415, "\"", 432, 1);
#nullable restore
#line 13 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
WriteAttributeValue("", 421, column.Key, 421, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
                                        Write(column.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </span>\r\n");
#nullable restore
#line 15 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n\r\n        <p>\r\n            <label for=\"searchTerm\">Keyword:</label>\r\n            <input type=\"text\" name=\"searchTerm\" id=\"searchTerm\" />\r\n        </p>\r\n\r\n        <input type=\"submit\" value=\"Search\" />\r\n    ");
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
            WriteLiteral("\r\n\r\n    <hr />\r\n\r\n");
#nullable restore
#line 29 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
     if (ViewBag.plants != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n");
#nullable restore
#line 32 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
             foreach (var plant in ViewBag.plants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <p>ID: ");
#nullable restore
#line 36 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
                          Write(plant.PlantId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Name: ");
#nullable restore
#line 37 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
                            Write(plant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Decription: ");
#nullable restore
#line 38 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
                                  Write(plant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 43 "C:\Users\joeki\Documents\LC101\C#\FinalProject\PlantItOut\PlantItOut\Views\Search\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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

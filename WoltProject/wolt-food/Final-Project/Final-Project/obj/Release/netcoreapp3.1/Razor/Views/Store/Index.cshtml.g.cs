#pragma checksum "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c43c1dd0ecfda549c6dfd1d382109980eb86c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
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
#line 2 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c43c1dd0ecfda549c6dfd1d382109980eb86c78", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37aa9dcf256fe53d484c02dd8f802c8d1f78dbd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Store>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon-category "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-aos", new global::Microsoft.AspNetCore.Html.HtmlString("zoom-out-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon-category bg-color"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon-category"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content animate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Store\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<nav>
    <div class=""nav-list"">
        <div class=""row store-category"">
            <div class=""location col col-md-4"" data-aos=""fade-right"">
                <div class=""location-icon"">
                    <div class=""icon"">
                        <i class=""fa-solid fa-house-chimney-window""></i>
                    </div>
                    <p style=""font-size:1.5rem;"">7/24</p>

                </div>
            </div>
            <div class=""navbar-caregory-list col col-mad-8"">
                <div class=""categories"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c43c1dd0ecfda549c6dfd1d382109980eb86c787488", async() => {
                WriteLiteral(@"

                        <div class=""icon"">
                            <svg viewBox=""0 0 24 24"" class=""NavigationLinkWithLocale__icon"" fill=""currentColor""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M21.517 8.648A6.656 6.656 0 0014.87 2a1 1 0 110-2 8.658 8.658 0 018.648 8.648 1 1 0 11-2 0zM7.854 3.868c.443 0 .8.214.8.478L8.65 5.532a.25.25 0 01-.25.25H4.12a.25.25 0 01-.25-.25V4.346c0-.264.36-.478.8-.478h.346a.248.248 0 00.248-.25v-2.14a1 1 0 012 0V3.62a.25.25 0 00.25.248h.34zm.8 14.069h-4.78a.75.75 0 000 1.5h4.78a.75.75 0 000-1.5zm0-2.802a.75.75 0 00.75-.75H9.4a.75.75 0 00-.746-.75h-4.78a.75.75 0 000 1.5h4.78zm-4.78-4.302h4.78a.75.75 0 000-1.5h-4.78a.75.75 0 100 1.5zm18.42 10.678H23a1 1 0 010 2H1a1 1 0 110-2h.211a.25.25 0 00.25-.25V7.693a.98.98 0 01.979-.98h7.648a.98.98 0 01.978.98V21.26c0 .139.112.25.25.25h.912a.25.25 0 00.25-.25v-7.832c0-.263.214-.477.478-.477h2.868c.264 0 .478.214.478.477v7.832c0 .139.112.25.25.25h1.414a.249.249 0 00.248-.25v-7.832c0-.263.214-.477.478-.477h2.874c.264 0 .478.214.47");
                WriteLiteral(@"8.477v7.832c0 .139.112.25.25.25zM14.869 6.172a2.48 2.48 0 012.476 2.477 1 1 0 102 0 4.481 4.481 0 00-4.476-4.477 1 1 0 100 2z""></path></svg>
                        </div>
                        <p class=""category-name"">
                            Discovery
                        </p>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c43c1dd0ecfda549c6dfd1d382109980eb86c7810422", async() => {
                WriteLiteral(@"

                        <div class=""icon"">
                            <svg viewBox=""0 0 24 24"" class=""NavigationLinkWithLocale__icon"" fill=""currentColor""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M10 1a1 1 0 112 0v5a4.009 4.009 0 01-2.667 3.772.5.5 0 00-.333.471V23a1 1 0 11-2 0V10.243a.5.5 0 00-.333-.471A4.009 4.009 0 014 6V1a1 1 0 112 0v5c0 .522.205 1.025.571 1.398A.251.251 0 007 7.223V1a1 1 0 112 0v6.225a.251.251 0 00.429.175c.367-.374.572-.877.571-1.4V1zM20.5.75a.75.75 0 00-.75-.75C17.418 0 15.064 6.055 15 13.243v.021c.004.686.563 1.24 1.25 1.236H18a.5.5 0 01.5.5v8a1 1 0 102 0V.75z""></path></svg>
                        </div>
                        <p class=""category-name"">
                            Restaurants
                        </p>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c43c1dd0ecfda549c6dfd1d382109980eb86c7812778", async() => {
                WriteLiteral(@"

                        <div class=""icon"">
                            <svg viewBox=""0 0 24 24"" class=""NavigationLinkWithLocale__icon"" fill=""currentColor""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M23.424 6.309a1 1 0 01-.016.454l-2.052 7.526a3 3 0 01-2.894 2.211H7.708a.25.25 0 00-.245.3l.179.855a.753.753 0 00.734.595h11.377a1.25 1.25 0 010 2.5.241.241 0 00-.215.35 2 2 0 01-2.757 2.647 2 2 0 01-.818-2.635.25.25 0 00-.224-.36h-5.97a.253.253 0 00-.213.117.248.248 0 00-.011.243 2 2 0 11-3.1-.623.248.248 0 00-.013-.389 3.252 3.252 0 01-1.237-1.93L2.029 3.1a.752.752 0 00-.733-.6 1.25 1.25 0 110-2.5 3.264 3.264 0 013.177 2.58l.572 2.72a.249.249 0 00.247.2h17.153a1 1 0 01.98.809zM6.111 8h13.75a.3.3 0 01.29.373l-1.312 5.248a.5.5 0 01-.485.38H7.191a.3.3 0 01-.294-.242l-1.08-5.4A.3.3 0 016.11 8z""></path></svg>
                        </div>
                        <p class=""category-name"">
                            Stores
                        </p>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- Responsive navbar category -->\r\n        <div class=\"navbar-caregory-list-responsive \">\r\n            <div class=\"categories\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c43c1dd0ecfda549c6dfd1d382109980eb86c7815559", async() => {
                WriteLiteral(@"
                    <div class=""icon"">
                        <svg viewBox=""0 0 24 24"" class=""NavigationLinkWithLocale__icon"" fill=""currentColor""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M21.517 8.648A6.656 6.656 0 0014.87 2a1 1 0 110-2 8.658 8.658 0 018.648 8.648 1 1 0 11-2 0zM7.854 3.868c.443 0 .8.214.8.478L8.65 5.532a.25.25 0 01-.25.25H4.12a.25.25 0 01-.25-.25V4.346c0-.264.36-.478.8-.478h.346a.248.248 0 00.248-.25v-2.14a1 1 0 012 0V3.62a.25.25 0 00.25.248h.34zm.8 14.069h-4.78a.75.75 0 000 1.5h4.78a.75.75 0 000-1.5zm0-2.802a.75.75 0 00.75-.75H9.4a.75.75 0 00-.746-.75h-4.78a.75.75 0 000 1.5h4.78zm-4.78-4.302h4.78a.75.75 0 000-1.5h-4.78a.75.75 0 100 1.5zm18.42 10.678H23a1 1 0 010 2H1a1 1 0 110-2h.211a.25.25 0 00.25-.25V7.693a.98.98 0 01.979-.98h7.648a.98.98 0 01.978.98V21.26c0 .139.112.25.25.25h.912a.25.25 0 00.25-.25v-7.832c0-.263.214-.477.478-.477h2.868c.264 0 .478.214.478.477v7.832c0 .139.112.25.25.25h1.414a.249.249 0 00.248-.25v-7.832c0-.263.214-.477.478-.477h2.874c.264 0 .478.214.478.477v7.83");
                WriteLiteral(@"2c0 .139.112.25.25.25zM14.869 6.172a2.48 2.48 0 012.476 2.477 1 1 0 102 0 4.481 4.481 0 00-4.476-4.477 1 1 0 100 2z""></path></svg>
                    </div>
                    <p class=""category-name"">
                        Discovery
                    </p>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c43c1dd0ecfda549c6dfd1d382109980eb86c7818375", async() => {
                WriteLiteral(@"
                    <div class=""icon"">
                        <svg viewBox=""0 0 24 24"" class=""NavigationLinkWithLocale__icon"" fill=""currentColor""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M10 1a1 1 0 112 0v5a4.009 4.009 0 01-2.667 3.772.5.5 0 00-.333.471V23a1 1 0 11-2 0V10.243a.5.5 0 00-.333-.471A4.009 4.009 0 014 6V1a1 1 0 112 0v5c0 .522.205 1.025.571 1.398A.251.251 0 007 7.223V1a1 1 0 112 0v6.225a.251.251 0 00.429.175c.367-.374.572-.877.571-1.4V1zM20.5.75a.75.75 0 00-.75-.75C17.418 0 15.064 6.055 15 13.243v.021c.004.686.563 1.24 1.25 1.236H18a.5.5 0 01.5.5v8a1 1 0 102 0V.75z""></path></svg>
                    </div>
                    <p class=""category-name"">
                        Restaurants
                    </p>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c43c1dd0ecfda549c6dfd1d382109980eb86c7820612", async() => {
                WriteLiteral(@"
                    <div class=""icon"">
                        <svg viewBox=""0 0 24 24"" class=""NavigationLinkWithLocale__icon"" fill=""currentColor""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M23.424 6.309a1 1 0 01-.016.454l-2.052 7.526a3 3 0 01-2.894 2.211H7.708a.25.25 0 00-.245.3l.179.855a.753.753 0 00.734.595h11.377a1.25 1.25 0 010 2.5.241.241 0 00-.215.35 2 2 0 01-2.757 2.647 2 2 0 01-.818-2.635.25.25 0 00-.224-.36h-5.97a.253.253 0 00-.213.117.248.248 0 00-.011.243 2 2 0 11-3.1-.623.248.248 0 00-.013-.389 3.252 3.252 0 01-1.237-1.93L2.029 3.1a.752.752 0 00-.733-.6 1.25 1.25 0 110-2.5 3.264 3.264 0 013.177 2.58l.572 2.72a.249.249 0 00.247.2h17.153a1 1 0 01.98.809zM6.111 8h13.75a.3.3 0 01.29.373l-1.312 5.248a.5.5 0 01-.485.38H7.191a.3.3 0 01-.294-.242l-1.08-5.4A.3.3 0 016.11 8z""></path></svg>
                    </div>
                    <p class=""category-name"">
                        Stores
                    </p>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n \r\n</nav>\r\n\r\n<div class=\"login-page\">\r\n    <div id=\"id10\" class=\"modal\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c43c1dd0ecfda549c6dfd1d382109980eb86c7823191", async() => {
                WriteLiteral(@"
            <div class=""container"">
                <div class=""cancel_button""><div onclick=""document.getElementById('id10').style.display='none'"" class=""cancelbtn"">X</div></div>
                <div class=""form-check"">
                    <input id=""free-delivery"" class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 8129, "\"", 8137, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <label class=""form-check-label"" for=""flexCheckDefault"">
                        Free Dlivery
                    </label>
                </div>
                <div class=""form-check"">
                    <input id=""discount"" class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 8433, "\"", 8441, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <label class=""form-check-label"" for=""flexCheckChecked"">
                        Discount
                    </label>
                </div>

                <button id=""sort"" class=""submit_button"" type=""submit"">Apply</button>

            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<section id=""stores"" data-aos=""flip-right"">
    <div class=""sotring-title "">
        <h1 style=""margin-bottom: 3%; font-weight: bold; "">Stores</h1>
        <div class=""sort "">
            <div class=""icon"">
                <p style=""cursor: pointer;"" onclick=""document.getElementById('id10').style.display='block'"">Sorted by Recommended</p>
                <p style=""cursor: pointer;"" onclick=""document.getElementById('id10').style.display='block'"" class=""mobile"">Sort</p>
                <i style=""cursor: pointer;"" onclick=""document.getElementById('id10').style.display='block'"" class=""fa-solid fa-shuffle""></i>
            </div>
        </div>
    </div>

    <div class=""cards row"">
");
            WriteLiteral("        ");
#nullable restore
#line 170 "C:\Users\HP\Desktop\final\wolt-food\Final-Project\Final-Project\Views\Store\Index.cshtml"
   Write(await Html.PartialAsync("/Views/Shared/_Store2Partial.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        // Get the modal
        var modal3 = document.getElementById('id10');

        window.onclick = function (event) {
            if (event.target == modal3) {
                modal3.style.display = ""none"";
            }

        }
    </script>

    <script>
        var sort = document.getElementById(""sort"")
        sort.addEventListener(""click"", function (e) {
            e.preventDefault()
            var modal3 = document.getElementById('id10');
                modal3.style.display=""none""
            let Isdelivery = $(""#free-delivery"").is("":checked"") ? ""true"" : ""false"";
            let Isdicount = $(""#discount"").is("":checked"") ? ""true"" : ""false"";
            $.ajax({
                url: ""/store/Sort"",
                data: {
                    Isdelivery: Isdelivery,
                    Isdicount: Isdicount
                },
                dataType: 'json',
                type: ""post"",
                success: function (data) {
                    va");
                WriteLiteral(@"r cards = document.querySelector("".cards"")
                    cards.innerHTML = """"
                    $.map(data, function (val, i) {
                        var box = this.document.createElement(""div"")
                        box.classList.add(""box"")
                        box.classList.add(""col-md-4"")


                        box.innerHTML =
                            `              <a href=""https://localhost:44378/restaurant/details/${val.id}"" class=""card tada "">

                <div class=""img"">
                    <img style=""height:100%;"" src=""./assets/image/${val.image}"" alt=""jhk"">
                </div>
                <div class=""title-name-time"">
                    <div class=""title-name"">
                        <div class=""restoran-name"">
                            <h6>${val.name}</h6>
                        </div>
                        <div class=""title"">
                            <p>${val.name}</p>
                        </div>
                    </div>
    ");
                WriteLiteral(@"                <div class=""time"">
                        20-30<br><br>min
                    </div>
                </div>
                <div class=""card-bottom"">
                    <span class=""delivery-icon"">
                        <svg style=""color: gray;"" viewBox=""0 0 24 24""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M4.401 9.602C4.682 9.883 5.067 10.041 5.463 10.041H5.502C5.918 10.031 6.299 9.854 6.577 9.545L9.734 6.038C10.27 5.443 10.245 4.534 9.679 3.967L8.098 2.385C7.809 2.096 7.394 1.941 7 1.947C6.59 1.957 6.198 2.138 5.924 2.442L2.764 5.954C2.23 6.547 2.254 7.455 2.818 8.02L4.401 9.602ZM10.722 11.734L12.173 10.075C13.547 11.004 15.169 11.499 16.828 11.495H17.5C18.329 11.495 19 10.823 19 9.995C19 9.16599 18.329 8.495 17.5 8.495H16.828C15.416 8.49099 14.062 7.93 13.061 6.93399C12.774 6.62999 12.367 6.47 11.95 6.496C11.535 6.509 11.145 6.69499 10.871 7.007L7.371 11.007C6.827 11.632 6.891 12.58 7.516 13.123C7.565 13.166 7.617 13.206 7.671 13.243L8.335 13.685C10.123 14.89 10.994 17.063");
                WriteLiteral(@" 10.535 19.169C10.338 19.974 10.83 20.787 11.635 20.984C12.44 21.181 13.252 20.688 13.449 19.883C13.454 19.863 13.459 19.841 13.463 19.82C14.115 16.825 13.061 13.714 10.722 11.734ZM22 18.495C22 17.114 20.881 15.995 19.5 15.995C18.119 15.995 17 17.114 17 18.495C17 19.875 18.119 20.995 19.5 20.995C20.881 20.995 22 19.875 22 18.495ZM24 18.495C24 20.98 21.985 22.995 19.5 22.995C17.015 22.995 15 20.98 15 18.495C15 16.009 17.015 13.995 19.5 13.995C21.985 13.995 24 16.009 24 18.495ZM7 18.495C7 17.114 5.881 15.995 4.5 15.995C3.119 15.995 2 17.114 2 18.495C2 19.875 3.119 20.995 4.5 20.995C5.881 20.995 7 19.875 7 18.495ZM9 18.495C9 20.98 6.985 22.995 4.5 22.995C2.015 22.995 0 20.98 0 18.495C0 16.009 2.015 13.995 4.5 13.995C6.985 13.995 9 16.009 9 18.495ZM12.125 3.995C12.125 2.683 13.189 1.62 14.5 1.62C15.812 1.62 16.875 2.683 16.875 3.995C16.875 5.30599 15.812 6.37 14.5 6.37C13.189 6.37 12.125 5.30599 12.125 3.995Z""></path></svg>
                    </span>
                    <span class=""delivery-price"">AZN ${val.I");
                WriteLiteral(@"sdelivery ? ""0.00"" : ""2.00""}</span>
                    <span class=""usd-icon"">$<span class="""">$$$</span></span>
                    <span class=""icon"">
                        <svg viewBox=""0 0 24 24"" class=""VenueCardFooter__StyledRatingSmiley-sc-vwzuvz-2 eqSvGJ""><path d=""M12 0c6.6 0 12 5.4 12 12s-5.4 12-12 12S0 18.6 0 12 5.4 0 12 0zm0 2C6.5 2 2 6.5 2 12s4.5 10 10 10 10-4.5 10-10S17.5 2 12 2zm4.7 12.2c.4.3.6.8.3 1.3-1.2 1.9-2.8 3-5 3.1-2.2-.1-3.8-1-4.8-2.9-.2-.5-.2-.9.1-1.3.2-.3.6-.4 1-.3.4.1.5.4.7.7.7 1.3 1.9 1.9 3.3 1.7 1.2-.1 2-.7 2.8-1.6.1-.2.2-.4.4-.5.2-.4.7-.5 1.2-.2zM16 7c1 0 1.9.8 1.9 1.9s-.8 1.9-1.9 1.9c-1 0-1.9-.8-1.9-1.9 0-1.1.8-1.9 1.9-1.9zM8 7c1 0 1.9.8 1.9 1.9s-.8 1.8-1.9 1.8c-1.1 0-1.9-.8-1.9-1.9C6.1 7.8 7 7 8 7z"" fill-rule=""evenodd"" clip-rule=""evenodd"" fill=""currentColor""></path></svg>
                    </span>
                    <span class=""point"">
                        9.8
                    </span>
                    <span class=""delivery-time-respon"">20-30 min</span>
    ");
                WriteLiteral(@"            </div>
            </a>`

                        cards.appendChild(box)

                    })

                },
                error: function (status) {
                    console.log(status)
                }
            })

        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Store>> Html { get; private set; }
    }
}
#pragma warning restore 1591

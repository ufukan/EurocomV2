#pragma checksum "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c33ce8b63f61a98894988bbcdc2ab9c409f54c52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
using EurocomV2.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
using EurocomV2.Models.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33ce8b63f61a98894988bbcdc2ab9c409f54c52", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab1f4d1d05d5e26acf194c03e6e93b22f616065", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #9fdefa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    getInfo get = new getInfo();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c33ce8b63f61a98894988bbcdc2ab9c409f54c524230", async() => {
                WriteLiteral("\r\n    <div class=\"Head\">Welkom</div>\r\n");
#nullable restore
#line 11 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
     if (signInManager.IsSignedIn(User))
    {
        if (TempData["UserID"] != null)
        {
            char gender = get.getGenderMethod(await userManager.FindByIdAsync(TempData["UserID"].ToString()));
            string lastname = get.getLastName(await userManager.FindByIdAsync(TempData["UserID"].ToString()));

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
             if (gender == 'm')
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"Head2\">Meneer ");
#nullable restore
#line 20 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
                                     Write(lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 21 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"Head2\">Mevrouw ");
#nullable restore
#line 24 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
                                      Write(lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 25 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\Index.cshtml"
             
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"" style=""min-height: 60px""></div>
            <div class=""col-md-6 col-12"" style=""text-align: center; min-height: 150px;"">
                <a href=""Home/Status"">
                    <div type=""button"" class=""btn btn-primary button btn w-75"" style=""height: auto"">
                        Status
                        <div></div>
                        <span class=""glyphicon glyphicon-heart buttonGlyph"" aria-hidden=""true""></span>
                    </div>
                </a>
            </div>
            <div class=""col-12 col-md-6"" style=""text-align: center; min-height: 150px;"">
                <a href=""Home/Account"">
                    <div type=""button"" class=""btn btn-primary button btn w-75"" style=""height: auto"">
                        Account
                        <div></div>
                        <span class=""glyphicon glyphicon-user buttonGlyph"" aria-hidden=""true""></span>
                  ");
                WriteLiteral("  </div>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
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

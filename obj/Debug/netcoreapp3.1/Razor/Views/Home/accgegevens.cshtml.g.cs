#pragma checksum "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\accgegevens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b79131d00511e4262f44a9cc884d1b1c0809b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_accgegevens), @"mvc.1.0.razor-page", @"/Views/Home/accgegevens.cshtml")]
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
#line 1 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\_ViewImports.cshtml"
using EurocomV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b79131d00511e4262f44a9cc884d1b1c0809b3", @"/Views/Home/accgegevens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563cd55ede89a1e66ddb0358f924b2bef799b290", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_accgegevens : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\accgegevens.cshtml"
  
    // ViewData["Title"] = "Account gegevens";
    connectionstring Connectionstring = new connectionstring();
    Connectionstring.Main();
    int personOrId = 0; //uiteindelijk gwn het gewenste id - 1
    string FirstName = "voornaam: " + Connectionstring.FirstName[personOrId];
    string LastName = "achternaam: " + Connectionstring.LastName[personOrId];
    string number = "telefoonnummer: " + Connectionstring.Number[personOrId];
    string doctor = "huisarts: " + Connectionstring.Doctor[personOrId];
    string numberdoctor = "nummer huisarts: " + Connectionstring.NumberDoctor[personOrId];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 style=\"padding-top:5%\">Account gegevens</h1>\r\n\r\n        <p style=\"border:2px;border-image-width:1px; border-style:solid; border-color:#000000; padding: 1em;\">");
#nullable restore
#line 18 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                         Write(FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 18 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                           Write(LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 18 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                                            Write(number);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 18 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                                                           Write(doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 18 "C:\Users\rawmw\OneDrive\Documents\GitHub\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                                                                          Write(numberdoctor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>

    <div class=""text-center"">
        <h1 style=""padding-top:5%"">Contactpersonen</h1>

        <p style=""border:2px;border-image-width:1px; border-style:solid; border-color:#000000; padding: 1em;"">(naam persoon) (nummer)<br><br>(naam persoon) (nummer)<br><br>(naam persoon) (nummer)</p>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<accgegevensModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<accgegevensModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<accgegevensModel>)PageContext?.ViewData;
        public accgegevensModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

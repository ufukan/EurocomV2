#pragma checksum "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574a7fcc8f79582e02e96044f6d9b44c51000da3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574a7fcc8f79582e02e96044f6d9b44c51000da3", @"/Views/Home/accgegevens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aab1f4d1d05d5e26acf194c03e6e93b22f616065", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_accgegevens : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
  
    // ViewData["Title"] = "Account gegevens";
    connectionstring Connectionstring = new connectionstring();
    int UserId = 2; // this is where the UserId should be placed
    Connectionstring.Read(UserId);
    string FirstName = "voornaam: " + Connectionstring.CurrentPatient.FirstName;
    string LastName = "achternaam: " + Connectionstring.CurrentPatient.LastName;
    string number = "telefoonnummer: " + Connectionstring.CurrentPatient.Number;
    string doctor = "huisarts: ";
    string numberdoctor = "nummer huisarts: ";
    List<string> contacts2 = new List<string>();
    contacts2.Add("x");
    contacts2.Add("x");
    contacts2.Add("x");
    

    // adding all the doctors to the string
    for (int i = 0; i < Connectionstring.DoctorsPerPatient.Count; i++)
    {
        if(i == 0)
        {
            doctor += Connectionstring.DoctorsPerPatient[i].Name;
            numberdoctor += Connectionstring.DoctorsPerPatient[i].Number;
        }
        else
        {
            doctor += " || " + Connectionstring.DoctorsPerPatient[i].Name;
            numberdoctor += " || " + Connectionstring.DoctorsPerPatient[i].Number;
        }
    }
    // adding the contacts
    for (int i = 0; i < Connectionstring.Contacts.Count; i++)
    {
        contacts2[i] = Connectionstring.Contacts[i].FirstName + " " + Connectionstring.Contacts[i].LastName + " || " + Connectionstring.Contacts[i].Number;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 style=\"padding-top:5%\">Account gegevens</h1>\r\n\r\n        <p style=\"border:2px;border-image-width:1px; border-style:solid; border-color:#000000; padding: 1em;\">");
#nullable restore
#line 44 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                         Write(FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 44 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                           Write(LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 44 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                                            Write(number);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 44 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                                                           Write(doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 44 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                                                                          Write(numberdoctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div class=\"text-center\">\r\n        <h1 style=\"padding-top:5%\">Contactpersonen</h1>\r\n\r\n        <p style=\"border:2px;border-image-width:1px; border-style:solid; border-color:#000000; padding: 1em;\">");
#nullable restore
#line 50 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                         Write(contacts2[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 50 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                              Write(contacts2[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>");
#nullable restore
#line 50 "C:\Users\Ufuk\source\repos\Eurocom v2\EurocomV2\EurocomV2\Views\Home\accgegevens.cshtml"
                                                                                                                                                   Write(contacts2[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n    \r\n ");
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

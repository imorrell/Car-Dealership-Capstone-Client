#pragma checksum "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e42a8cd69d77bdc331b7e33f214db6d6732717ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_SearchCarResults), @"mvc.1.0.view", @"/Views/Car/SearchCarResults.cshtml")]
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
#line 1 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\_ViewImports.cshtml"
using CarDealershipCapstone_UsingAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\_ViewImports.cshtml"
using CarDealershipCapstone_UsingAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42a8cd69d77bdc331b7e33f214db6d6732717ff", @"/Views/Car/SearchCarResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2afa95e554d79a51a5596f7d911c93d606d62a", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_SearchCarResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cars>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
  
    ViewData["Title"] = "SearchCarByMake";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Search Car Results</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Make</th>\r\n        <th>Model</th>\r\n        <th>Year</th>\r\n        <th>Color</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
     foreach (Cars car in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n           <td>");
#nullable restore
#line 21 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
          Write(car.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 22 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
          Write(car.make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 23 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
          Write(car.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 24 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
          Write(car.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 25 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
          Write(car.color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 493, "\"", 527, 2);
            WriteAttributeValue("", 500, "../Car/UpdateCar?id=", 500, 20, true);
#nullable restore
#line 26 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
WriteAttributeValue("", 520, car.id, 520, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update Task</a></td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 568, "\"", 603, 2);
            WriteAttributeValue("", 575, "../Car/DeleteTask?id=", 575, 21, true);
#nullable restore
#line 27 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
WriteAttributeValue("", 596, car.id, 596, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Task</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Prophesy\Documents\C#2019\CarDealershipCapstone_UsingAPI\CarDealershipCapstone_UsingAPI\Views\Car\SearchCarResults.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591

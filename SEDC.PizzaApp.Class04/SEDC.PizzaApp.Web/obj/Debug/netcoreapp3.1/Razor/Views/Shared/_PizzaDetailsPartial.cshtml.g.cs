#pragma checksum "D:\Slave\SEDC\ASP.NET mvc GitHub\ASP.NET\SEDC.PizzaApp.Class04\SEDC.PizzaApp.Web\Views\Shared\_PizzaDetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b526c43960620ead54cc5adee462853c8cbc302e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PizzaDetailsPartial), @"mvc.1.0.view", @"/Views/Shared/_PizzaDetailsPartial.cshtml")]
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
#line 1 "D:\Slave\SEDC\ASP.NET mvc GitHub\ASP.NET\SEDC.PizzaApp.Class04\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Slave\SEDC\ASP.NET mvc GitHub\ASP.NET\SEDC.PizzaApp.Class04\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b526c43960620ead54cc5adee462853c8cbc302e", @"/Views/Shared/_PizzaDetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731fa6b6e3c434427b4dc202e8a894ac8774225c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PizzaDetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.PizzaApp.Web.Models.ViewModels.PizzaDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>Pizza from partial</h4>\r\n<ul>\r\n    <li>Pizza Name: <h6>");
#nullable restore
#line 5 "D:\Slave\SEDC\ASP.NET mvc GitHub\ASP.NET\SEDC.PizzaApp.Class04\SEDC.PizzaApp.Web\Views\Shared\_PizzaDetailsPartial.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></li>\r\n    <li>Pizza Size: <h6>");
#nullable restore
#line 6 "D:\Slave\SEDC\ASP.NET mvc GitHub\ASP.NET\SEDC.PizzaApp.Class04\SEDC.PizzaApp.Web\Views\Shared\_PizzaDetailsPartial.cshtml"
                   Write(Model.PizzaSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></li>\r\n    <li>Pizza Price: <h6>");
#nullable restore
#line 7 "D:\Slave\SEDC\ASP.NET mvc GitHub\ASP.NET\SEDC.PizzaApp.Class04\SEDC.PizzaApp.Web\Views\Shared\_PizzaDetailsPartial.cshtml"
                    Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></li>\r\n\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.PizzaApp.Web.Models.ViewModels.PizzaDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

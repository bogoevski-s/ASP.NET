#pragma checksum "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6e02fe0cb2962dc3d33c887f77960aa84e22bda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorPage), @"mvc.1.0.view", @"/Views/Shared/ErrorPage.cshtml")]
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
#line 1 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Web.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e02fe0cb2962dc3d33c887f77960aa84e22bda", @"/Views/Shared/ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de4b2296c389b8a24db6cba5ff963b2ab3dad17", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Something went wrong please return to home </h3>\r\n<br />\r\n\r\n<button class=\"btn btn-warning font-weight-bold col-3\"> ");
#nullable restore
#line 4 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\ErrorPage.cshtml"
                                                   Write(Html.ActionLink("Back to list", "Index", "Pizza"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>");
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

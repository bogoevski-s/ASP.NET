#pragma checksum "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27085c78ba82f44e8bab6adf85cf102000645163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial__OrderDetails), @"mvc.1.0.view", @"/Views/Shared/Partial/_OrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27085c78ba82f44e8bab6adf85cf102000645163", @"/Views/Shared/Partial/_OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de4b2296c389b8a24db6cba5ff963b2ab3dad17", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial__OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p>Id: ");
#nullable restore
#line 8 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Payment Method: ");
#nullable restore
#line 9 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                              Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Pizza name:");
#nullable restore
#line 10 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                         Write(Model.PizzaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>User name: ");
#nullable restore
#line 11 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                         Write(Model.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Price: ");
#nullable restore
#line 12 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Store: ");
#nullable restore
#line 13 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                     Write(Model.PizzaStore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                 if (Model.Delivered)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p> Your order is delivered.</p>\r\n");
#nullable restore
#line 17 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p> Your order is not delivered.</p>\r\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\ASP.NET MVC github\skwd9-net-08-aspnetmvc\G1\Class_05\SEDC.PizzaApp\SEDC.PizzaApp.Web\Views\Shared\Partial\_OrderDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
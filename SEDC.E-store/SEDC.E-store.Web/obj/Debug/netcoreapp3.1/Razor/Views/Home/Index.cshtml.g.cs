#pragma checksum "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc2676e1746e920419b59e3a1c96850267384fa0"
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
#line 1 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\_ViewImports.cshtml"
using SEDC.E_store.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\_ViewImports.cshtml"
using SEDC.E_store.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2676e1746e920419b59e3a1c96850267384fa0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3bf6825836b01ea2f342b690ebc3d2847b1e80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container justify-content-center\">\r\n    <div class=\"row justify-content-center\" style=\"margin-top:30px\">\r\n");
#nullable restore
#line 6 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml"
         foreach (ProductsViewModel product in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 text-center\" style=\"margin: 10px; margin-top: 0px; border-radius: 5px; padding:20px; border: 1px solid #a5a5a5\">\r\n                <h4>");
#nullable restore
#line 11 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h6>");
#nullable restore
#line 12 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml"
               Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h3>");
#nullable restore
#line 13 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml"
               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h3>\r\n                <button class=\"btn btn-outline-info\" style=\"margin: 5px;\">\r\n                    ");
#nullable restore
#line 15 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Details", "ProductDetails", "Product",
                    new { id = @product.Id }, new { style = "text-decoration:none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n                <button class=\"btn btn-outline-success\" style=\"margin: 5px\">\r\n                    Add to card\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 22 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row justify-content-center\">\r\n        <button class=\"btn btn-outline-success\" style=\"margin: 15px\">\r\n            ");
#nullable restore
#line 26 "D:\Slave\Visual Studio\ASP.NET MVC\SEDC.E-store\SEDC.E-store.Web\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Add new product", "AddNewProduct", "Product",
            null, new { style = "text-decoration:none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

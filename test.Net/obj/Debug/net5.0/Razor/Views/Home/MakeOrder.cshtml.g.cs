#pragma checksum "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "113e7e806900e4ca00001e2d9958e05736d4269c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MakeOrder), @"mvc.1.0.view", @"/Views/Home/MakeOrder.cshtml")]
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
#line 1 "/Users/shahadsh/Projects/test.Net/test.Net/Views/_ViewImports.cshtml"
using test.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shahadsh/Projects/test.Net/test.Net/Views/_ViewImports.cshtml"
using test.Net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113e7e806900e4ca00001e2d9958e05736d4269c", @"/Views/Home/MakeOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"004daa6dde8f7a6cf02601cd265a8ee85fd92285", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MakeOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<test.Net.Models.product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
  
    ViewData["Title"] = "order";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>Please Enter your Information.</p>\n\n<div class=\"container\">\n");
#nullable restore
#line 12 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
     using (Html.BeginForm("SaveOrder", "Home", FormMethod.Post))
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
   Write(Html.HiddenFor(x => x.productId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
   Write(Html.HiddenFor(x => x.Order.customerID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
   Write(Html.HiddenFor(x => x.Order.orderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-3\">Laptop Name</div>\n            <div class=\"col-sm-9\">");
#nullable restore
#line 23 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
                             Write(Html.DisplayFor(c => c.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n");
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-3\">price</div>\n            <div class=\"col-sm-9\">");
#nullable restore
#line 28 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
                             Write(Html.DisplayFor(c => c.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n");
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-3\">NumperOfItem</div>\n            <div class=\"col-sm-9\">");
#nullable restore
#line 33 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"
                             Write(Html.TextBoxFor(c => c.Order.NumperOfItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        </div>\n");
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-12 text-left\">\n                <input class=\"btn btn-success\" type=\"submit\" value=\"submit\" />\n            </div>\n        </div>\n");
#nullable restore
#line 43 "/Users/shahadsh/Projects/test.Net/test.Net/Views/Home/MakeOrder.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<test.Net.Models.product> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e2744b91da65e371415ff9c8c79d4a93d37f7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Dojo), @"mvc.1.0.view", @"/Views/Main/Dojo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Dojo.cshtml", typeof(AspNetCore.Views_Main_Dojo))]
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
#line 2 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\_ViewImports.cshtml"
using DojoLeague.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e2744b91da65e371415ff9c8c79d4a93d37f7e", @"/Views/Main/Dojo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65bff69e99803d65c3d0dc9371db3a2ff87c3b44", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Dojo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dojo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 370, true);
            WriteLiteral(@"<!-- Insert Model Here -->
<div class=""row justify-content-center"">
    <div class=""col-lg-10 rounded justify-content-center m-4 bg-white"">
        <div class=""row justify-content-center m-3"">
            <h3 class=""mt-1 mb-4"">Dojo Information</h3>
        </div>
        <div class=""row m-3"">
            <div class=""col-md-12 text-center"">
                <h5>");
            EndContext();
            BeginContext(384, 10, false);
#line 10 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
               Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(394, 254, true);
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        <div class=\"row m-3\">\r\n            <div class=\"col-md-3 text-left\">\r\n                <h5>Location:</h5>\r\n            </div>\r\n            <div class=\"col-md-9 justify-content-start\">\r\n                <h6>");
            EndContext();
            BeginContext(649, 14, false);
#line 18 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
               Write(Model.location);

#line default
#line hidden
            EndContext();
            BeginContext(663, 257, true);
            WriteLiteral(@"</h6>
            </div>
        </div>
        <div class=""row m-3"">
            <div class=""col-md-3 text-left"">
                <h5>Information:</h5>
            </div>
            <div class=""col-md-9 justify-content-start"">
                <h6>");
            EndContext();
            BeginContext(921, 17, false);
#line 26 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
               Write(Model.description);

#line default
#line hidden
            EndContext();
            BeginContext(938, 576, true);
            WriteLiteral(@"</h6>
            </div>
        </div>
        <div class=""row justify-content-center m-3"">
            <div class=""col-lg-6 my-2 justify-content-center"">
                <h3 class=""mt-1 mb-4"">Current Members</h3>
                <table class=""table table-striped table-hover table-sm"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Ninja</th>
                            <th scope=""col"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 40 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
                         foreach (var ninja in ViewBag.ninjaDojoList)
                        {

#line default
#line hidden
            BeginContext(1612, 72, true);
            WriteLiteral("                            <tr>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1684, "\"", 1714, 2);
            WriteAttributeValue("", 1691, "/ninjas/", 1691, 8, true);
#line 43 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
WriteAttributeValue("", 1699, ninja.ninja_id, 1699, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1715, 19, true);
            WriteLiteral(" class=\"text-dark\">");
            EndContext();
            BeginContext(1735, 10, false);
#line 43 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
                                                                                   Write(ninja.name);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 49, true);
            WriteLiteral("</a></td>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1794, "\"", 1839, 4);
            WriteAttributeValue("", 1801, "/banish/", 1801, 8, true);
#line 44 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
WriteAttributeValue("", 1809, Model.dojo_id, 1809, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1823, "/", 1823, 1, true);
#line 44 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
WriteAttributeValue("", 1824, ninja.ninja_id, 1824, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1840, 68, true);
            WriteLiteral(" class=\"text-dark\">Banish!</td>\r\n                            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
                        }

#line default
#line hidden
            BeginContext(1935, 552, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""col-lg-6 my-2 justify-content-center"">
                <h3 class=""mt-1 mb-4"">Rogue Ninjas</h3>
                <table class=""table table-striped table-hover table-sm"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Ninja</th>
                            <th scope=""col"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 60 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
                     foreach (var rougeNinja in ViewBag.rougeNinjas)
                    {

#line default
#line hidden
            BeginContext(2580, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2644, "\"", 2679, 2);
            WriteAttributeValue("", 2651, "/ninjas/", 2651, 8, true);
#line 63 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
WriteAttributeValue("", 2659, rougeNinja.ninja_id, 2659, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2680, 19, true);
            WriteLiteral(" class=\"text-dark\">");
            EndContext();
            BeginContext(2700, 15, false);
#line 63 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
                                                                                    Write(rougeNinja.name);

#line default
#line hidden
            EndContext();
            BeginContext(2715, 45, true);
            WriteLiteral("</a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2760, "\"", 2811, 4);
            WriteAttributeValue("", 2767, "/recruit/", 2767, 9, true);
#line 64 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
WriteAttributeValue("", 2776, Model.dojo_id, 2776, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2790, "/", 2790, 1, true);
#line 64 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
WriteAttributeValue("", 2791, rougeNinja.ninja_id, 2791, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2812, 65, true);
            WriteLiteral(" class=\"text-dark\">Recruit!</td>\r\n                        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoLeague\Views\Main\Dojo.cshtml"
                    }

#line default
#line hidden
            BeginContext(2900, 110, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dojo> Html { get; private set; }
    }
}
#pragma warning restore 1591

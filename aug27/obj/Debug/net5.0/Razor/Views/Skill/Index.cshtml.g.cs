#pragma checksum "D:\gislen\asp.netMvcCore\aug27\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432cdab66dc8364e23ab2015db51a1e3a01ab720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "D:\gislen\asp.netMvcCore\aug27\Views\_ViewImports.cshtml"
using aug27;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\gislen\asp.netMvcCore\aug27\Views\_ViewImports.cshtml"
using aug27.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\gislen\asp.netMvcCore\aug27\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432cdab66dc8364e23ab2015db51a1e3a01ab720", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c7767ed4e1a1fe675d443de63baed8d5735045f", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!--<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h1>Employee Skills</h1>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <a asp-controller=\"Skill\" asp-action=\"Create\" class=\"btn btn-info\">Create New Skill</a>\r\n    </div>\r\n</div>-->\r\n\r\n");
            WriteLiteral(@"
<!--<div class=""row"">
    <div class=""col-12"">
        <table class=""table table-bordered table-striped"" style=""width: 100%"">

            <thead>
                <tr>
                    <th>Skill Id</th>
                    <th>Skill Name</th>
                </tr>
            </thead>

            <tbody>-->
");
            WriteLiteral("            <!--</tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>-->");
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

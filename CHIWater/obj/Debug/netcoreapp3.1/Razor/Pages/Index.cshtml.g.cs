#pragma checksum "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e62236fa07992a1e1426a932327379df02c12552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CHIWater.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace CHIWater.Pages
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
#line 1 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\_ViewImports.cshtml"
using CHIWater;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\_ViewImports.cshtml"
using CHIWater.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
using CHIWater.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62236fa07992a1e1426a932327379df02c12552", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb11d3e4ed9dcf9de4221b724e5da841b8aba39", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
  
    var House = new House();
    House.AddTestData();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    function Speak(val) {
        alert(val);
    }
</script>

<div class=""text-left"">
    <h1 class=""display-4"">Pets In the House</h1>

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Is Palindrome?
                </th>
                <th>
                    Type
                </th>
                <th>
                    Gender
                </th>
                <th>
                    Age
                </th>
                <th>
                    Wingspan
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 43 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
             foreach (var item in House)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
                    Write(item.IsNameAPalindrome? "True" : "False");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
                    Write(item.GetType().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
                   Write(item.Wingspan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button ID=\"Speak\" type=\"button\" class=\"btndelete btn btn-xs btn-primary\"");
            BeginWriteAttribute("OnClick", " OnClick=\"", 1765, "\"", 1799, 3);
            WriteAttributeValue("", 1775, "Speak(\'", 1775, 7, true);
#nullable restore
#line 65 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
WriteAttributeValue("", 1782, item.Speak(), 1782, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1797, "\')", 1797, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span>Speak\r\n                        </button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 70 "D:\Work\C#Practice\CHIWater\CHIWater\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CHIWater.Models.House> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CHIWater.Models.House> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CHIWater.Models.House>)PageContext?.ViewData;
        public CHIWater.Models.House Model => ViewData.Model;
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "910007bd43c8ec71b61ccbf58d0e98a51c2c1b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SwimStyle_Index), @"mvc.1.0.view", @"/Views/SwimStyle/Index.cshtml")]
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
#line 1 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\_ViewImports.cshtml"
using DTO.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"910007bd43c8ec71b61ccbf58d0e98a51c2c1b6a", @"/Views/SwimStyle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7ec9e9c393cb12911cc1a8df80275cedb3374c", @"/Views/_ViewImports.cshtml")]
    public class Views_SwimStyle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DTO.Models.SwimStyleDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
  
    ViewBag.Title = "SwimStyles";
    var pagedList = (IPagedList)ViewBag.OnePageOfSwimStyles;


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<link href=\"/Content/PagedList.css\" rel=\"stylesheet\" type=\"text/css\" />\n<div id=\"modDialog\" class=\"modal fade\">\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "910007bd43c8ec71b61ccbf58d0e98a51c2c1b6a5253", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "910007bd43c8ec71b61ccbf58d0e98a51c2c1b6a6489", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<table class=\"table\">\n\n    <tr><td>Id</td><td>Style Name</td><td> Actions</td></tr>\n\n");
#nullable restore
#line 23 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
     foreach (var item in ViewBag.OnePageOfSwimStyles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 26 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
           Write(item.StyleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n            <td>\n                ");
#nullable restore
#line 30 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 31 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 32 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "swimItem" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            </td>\n        </tr>\n");
#nullable restore
#line 36 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n");
#nullable restore
#line 40 "C:\Users\irini\OneDrive\Робочий стіл\SwimmingProject\Swimming\SwimmingWebApp\Views\SwimStyle\Index.cshtml"
Write(Html.PagedListPager((IPagedList)ViewBag.OnePageOfSwimStyles, page => Url.Action("Index", new { page }), new PagedListRenderOptions
{
    LiElementClasses = new string[] { "page-item" },
    PageClasses = new string[] { "page-link" }
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(function () {
            $.ajaxSetup({ cache: false });
            $("".swimItem"").click(function (e) {

                e.preventDefault();
                $.get(this.href, function (data) {
                    $('#dialogContent').html(data);
                    $('#modDialog').modal('show');
                });
            });
        })
    </script>
");
            }
            );
            WriteLiteral("\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DTO.Models.SwimStyleDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
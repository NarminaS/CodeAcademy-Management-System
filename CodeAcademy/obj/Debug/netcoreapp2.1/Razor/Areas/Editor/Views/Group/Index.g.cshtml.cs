#pragma checksum "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Group\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6af02cd29dd987056377a3562fe034c008bd558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Editor_Views_Group_Index), @"mvc.1.0.view", @"/Areas/Editor/Views/Group/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Editor/Views/Group/Index.cshtml", typeof(AspNetCore.Areas_Editor_Views_Group_Index))]
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
#line 1 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy;

#line default
#line hidden
#line 2 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy.Models;

#line default
#line hidden
#line 3 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy.Areas.Admin.Models;

#line default
#line hidden
#line 4 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy.Components.ViewModels;

#line default
#line hidden
#line 1 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Group\Index.cshtml"
using CodeAcademy.Areas.Editor.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6af02cd29dd987056377a3562fe034c008bd558", @"/Areas/Editor/Views/Group/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac37bf94f0ab55bffa43146f51a3323212eb12dc", @"/Areas/Editor/Views/_ViewImports.cshtml")]
    public class Areas_Editor_Views_Group_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GroupViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Group\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(107, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(136, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a83ca67f924f668386312866efe4f8", async() => {
                BeginContext(142, 92, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Grop CRUUD</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(243, 660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbae874123674e0e9824d97c27e0d951", async() => {
                BeginContext(249, 32, true);
                WriteLiteral("\r\n    <h3>Group crud page</h3>\r\n");
                EndContext();
#line 16 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Group\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
                BeginContext(312, 44, true);
                WriteLiteral("        <h4 class=\"lead\">No groups...</h4>\r\n");
                EndContext();
#line 19 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Group\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(363, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(369, 129, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa2c631648b34ac690efc89cc76f8475", async() => {
                    BeginContext(409, 82, true);
                    WriteLiteral("\r\n        <input type=\"button\" class=\"btn btn-info\" value=\"Add new group\" />\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(498, 398, true);
                WriteLiteral(@"



    <style>
        .custom-modal {
            padding: 2vh;
            display: none;
            position: fixed;
            width: 20vw;
            z-index: 3;
            top: 15vh;
            left: 35vw;
            overflow: auto;
            border: 1px solid black;
            border-radius: 1vh;
            background-color: #ababab;
        }
    </style>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(903, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GroupViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

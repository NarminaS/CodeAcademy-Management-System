#pragma checksum "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99753fc3a4cac9ab3fc358ec98ce3033f9921a81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Roles/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Roles_Index))]
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
#line 1 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademy;

#line default
#line hidden
#line 2 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademy.Models;

#line default
#line hidden
#line 3 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademy.Areas.Admin.Models;

#line default
#line hidden
#line 4 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademy.Components.ViewModels;

#line default
#line hidden
#line 1 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
using CodeAcademy.Areas.Admin.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99753fc3a4cac9ab3fc358ec98ce3033f9921a81", @"/Areas/Admin/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac37bf94f0ab55bffa43146f51a3323212eb12dc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RoleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(134, 411, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27733e1981c84828b824caa62b0e4ad9", async() => {
                BeginContext(140, 398, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <title>Index</title>
");
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
            BeginContext(545, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(547, 5889, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7323615e6fa2471380588ffd95779ca3", async() => {
                BeginContext(553, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(560, 77, false);
#line 17 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
Write(await Component.InvokeAsync("UpperPanel", new { email = User.Identity.Name }));

#line default
#line hidden
                EndContext();
                BeginContext(637, 42, true);
                WriteLiteral("\r\n    <h3 class=\"h3\">Role crud page</h3>\r\n");
                EndContext();
#line 19 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
                BeginContext(710, 43, true);
                WriteLiteral("        <h4 class=\"lead\">No roles...</h4>\r\n");
                EndContext();
#line 22 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(760, 278, true);
                WriteLiteral(@"    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-5"">
                <input type=""button"" class=""btn btn-info"" value=""New Role"" id=""create"" />
                <br />
                <br />
                <ul class=""list-group"">
");
                EndContext();
#line 30 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
                     foreach (var role in Model)
                    {

#line default
#line hidden
                BeginContext(1111, 146, true);
                WriteLiteral("                        <li class=\"list-group-item list-group-item-action list-group-item-info\">\r\n                            <span class=\"lead\"> ");
                EndContext();
                BeginContext(1258, 9, false);
#line 33 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
                                           Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1267, 70, true);
                WriteLiteral(" </span>\r\n                            <span class=\"badge badge-light\">");
                EndContext();
                BeginContext(1338, 21, false);
#line 34 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
                                                       Write(role.UsersInRoleCount);

#line default
#line hidden
                EndContext();
                BeginContext(1359, 369, true);
                WriteLiteral(@"</span>
                            <input type=""button"" value=""Edit"" class=""btn btn-warning btn-sm edit"" />
                            <input type=""button"" value=""Deactivate"" class=""btn btn-danger btn-sm deactivate"" />
                            <input type=""button"" class=""btn btn-success btn-sm reactivate"" value=""Reactivate"" />
                        </li>
");
                EndContext();
#line 39 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1751, 75, true);
                WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
                EndContext();
                BeginContext(1851, 232, true);
                WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                <div id=\"new-role\" class=\"custom-modal\">\r\n                    <h5 class=\"h5 text-center\">New Role</h5>\r\n                    ");
                EndContext();
                BeginContext(2083, 561, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ede647607eb4867b5b44d1ac314871a", async() => {
                    BeginContext(2205, 432, true);
                    WriteLiteral(@"
                        <label>Name</label>
                        <input type=""text"" id=""create-role-name"" placeholder=""Role name..."" class=""form-control"" />
                        <br />
                        <input type=""button"" value=""Create Role"" id=""confirm-create"" class=""btn btn-success"" />
                        <input type=""button"" value=""Close"" id=""closeCreate"" class=""btn btn-danger"" />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
#line 52 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2644, 76, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
                BeginContext(2746, 234, true);
                WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                <div id=\"edit-role\" class=\"custom-modal\">\r\n                    <h5 class=\"h5 text-center\">Edit Role</h5>\r\n                    ");
                EndContext();
                BeginContext(2980, 553, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa138972ddd74440a46fab75e38fabab", async() => {
                    BeginContext(3100, 426, true);
                    WriteLiteral(@"
                        <label>Name</label>
                        <input type=""text"" id=""edit-role-name"" placeholder=""Role name..."" class=""form-control"" />
                        <br />
                        <input type=""button"" value=""Update Role"" id=""confirm-edit"" class=""btn btn-success"" />
                        <input type=""button"" value=""Close"" id=""closeEdit"" class=""btn btn-danger"" />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
#line 70 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3533, 76, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
                BeginContext(3651, 251, true);
                WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                <div id=\"role-deactiv-confirm\" class=\"custom-modal\">\r\n                    <h5 class=\"h5 text-center\">Deactivate Role</h5>\r\n                    ");
                EndContext();
                BeginContext(3902, 506, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32093dcb2af74feba89a7eaa2189e5f7", async() => {
                    BeginContext(4022, 379, true);
                    WriteLiteral(@"
                        <p class=""lead"">The role <span id=""role-name""></span> will be deactivated. Are you sure?</p>
                        <br />
                        <input type=""button"" value=""Yes"" id=""confirm-Deactiv"" class=""btn btn-success"" />
                        <input type=""button"" value=""No"" id=""closeDeactiv"" class=""btn btn-danger"" />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
#line 88 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy-Management-System\CodeAcademy-Management-System\CodeAcademy\Areas\Admin\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4408, 2021, true);
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <style>
        .reactivate {
            display: none;
        }

        .custom-modal {
            padding: 2vh;
            display: none;
            position: fixed;
            width: 25vw;
            z-index: 3;
            top: 15vh;
            left: 35vw;
            overflow: auto;
            border: 1px solid black;
            border-radius: 1vh;
            background-color: #ababab;
        }
    </style>

    <script>
        var roleName;

        $(""#create"").click(function () {

            $(""#new-role"").css(""display"", ""block"");
        });

        $(""#closeCreate"").click(function () {

            $(""#new-role"").css(""display"", ""none"");
        })

        $(""#confirm-create"").click(function () {
            $.ajax({
                method: ""POST"",
                url: ""/Admin/Roles/Create"",
                data: { name: $(""#create-role-name"").val() }
            })
");
                WriteLiteral(@"                .done(function () {
                    document.location.reload()
                })

        })

        $("".deactivate"").click(function (e) {
            roleName = $(e.target).parent().children()[0].innerText;
            $(""#role-deactiv-confirm"").css(""display"", ""block"");
            $(""#role-deactiv-confirm form p span"").text(roleName);
            //$(e.target).next().css(""display"", ""inline-block"");
            //$(e.target).css(""display"", ""none"");
        });

        $("".edit"").click(function (e) {
            roleName = $(e.target).parent().children()[0].innerText;
            $(""#edit-role"").css(""display"", ""block"");
            $(""#edit-role form #edit-role-name"").val(roleName);
        });

        $(""#closeEdit"").click(function () { 
            $(""#edit-role"").css(""display"",""none"")
        })

        $(""#closeDeactiv"").click(function () {
           $(""#role-deactiv-confirm"").css(""display"", ""none"");
        })
    </script>
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
            BeginContext(6436, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RoleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

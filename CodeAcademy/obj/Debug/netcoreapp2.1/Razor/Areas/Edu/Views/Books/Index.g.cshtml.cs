#pragma checksum "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Edu\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a457232a988785017b445a47e12a43f34fab7802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Edu_Views_Books_Index), @"mvc.1.0.view", @"/Areas/Edu/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Edu/Views/Books/Index.cshtml", typeof(AspNetCore.Areas_Edu_Views_Books_Index))]
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
#line 1 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Edu\Views\_ViewImports.cshtml"
using CodeAcademy;

#line default
#line hidden
#line 2 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Edu\Views\_ViewImports.cshtml"
using CodeAcademy.Models;

#line default
#line hidden
#line 3 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Edu\Views\_ViewImports.cshtml"
using CodeAcademy.Areas.Edu;

#line default
#line hidden
#line 4 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Edu\Views\_ViewImports.cshtml"
using CodeAcademy.Components.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a457232a988785017b445a47e12a43f34fab7802", @"/Areas/Edu/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86eb191833f631ea79e1b5ab488968c6c7fa5ec", @"/Areas/Edu/Views/_ViewImports.cshtml")]
    public class Areas_Edu_Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Edu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchBookByName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBooksByFaculty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBooksByLanguage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bookform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Edu\Views\Books\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b71673310a62412d9c433423d84b3f39", async() => {
                BeginContext(64, 397, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>List</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
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
            BeginContext(468, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(470, 12407, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d88d4889f4d40cfbb29148553b4d5e7", async() => {
                BeginContext(476, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(483, 77, false);
#line 16 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Edu\Views\Books\Index.cshtml"
Write(await Component.InvokeAsync("UpperPanel", new { email = User.Identity.Name }));

#line default
#line hidden
                EndContext();
                BeginContext(560, 583, true);
                WriteLiteral(@"

    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <input type=""button"" class=""btn btn-info"" id=""open-create-book"" value=""New Book"" />
                <input type=""button"" id=""show-all"" class=""btn btn-warning"" value=""All Books"" />
            </div>
        </div>
    </div>
    <br />

    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-8"">
                <ul class=""list-group"" id=""books""></ul>
            </div>
            <div class=""col-sm-4"">
                ");
                EndContext();
                BeginContext(1143, 415, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bb710eb5e54e158b00dca93df0e582", async() => {
                    BeginContext(1244, 307, true);
                    WriteLiteral(@"
                    <label>Book search</label>
                    <input class=""form-control"" name=""name"" type=""text"" placeholder=""Enter book name..."" aria-label=""Search"">
                    <br />
                    <input type=""submit"" class=""btn btn-info"" value=""Search book"" />
                ");
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1558, 44, true);
                WriteLiteral("\r\n                <br />\r\n\r\n                ");
                EndContext();
                BeginContext(1602, 255, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c2e9cac1de04042a0c3eee03bbac752", async() => {
                    BeginContext(1691, 159, true);
                    WriteLiteral("\r\n                    <label>Faculty</label>\r\n                    <select name=\"facultyid\" id=\"faculty-search\" class=\"form-control\"></select>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
                BeginContext(1857, 44, true);
                WriteLiteral("\r\n                <br />\r\n\r\n                ");
                EndContext();
                BeginContext(1901, 259, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed6078e82c984978a760fbb92655cc47", async() => {
                    BeginContext(1991, 162, true);
                    WriteLiteral("\r\n                    <label>Language</label>\r\n                    <select name=\"languageid\" id=\"language-search\" class=\"form-control\"></select>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
                BeginContext(2160, 54, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
                EndContext();
                BeginContext(2239, 232, true);
                WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div id=\"new-book\" class=\"custom-modal\">\r\n                    <h5 class=\"h5 text-center\">New Book</h5>\r\n                    ");
                EndContext();
                BeginContext(2471, 1759, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f852dc4c928548339c7606b015cb706e", async() => {
                    BeginContext(2609, 1614, true);
                    WriteLiteral(@"
                        <label>Faculty</label>
                        <select name=""facultyid"" id=""faculty"" class=""form-control""></select>
                        <label>Author</label>
                        <input type=""text"" class=""form-control"" id=""author"" required name=""author"" value="""" />
                        <label>Name</label>
                        <input type=""text"" class=""form-control"" id=""name"" required name=""name"" value="""" />
                        <label>Description</label>
                        <input type=""text"" class=""form-control"" id=""description"" required name=""description"" value="""" />
                        <label>Language</label>
                        <select name=""languageid"" id=""language"" class=""form-control""></select>
                        <label>Page count</label>
                        <input type=""number"" class=""form-control"" required id=""pagecount"" name=""pagecount"" value="""" />
                        <input type=""file"" name=""book"" id=""book"" required acce");
                    WriteLiteral(@"pt=""application/pdf"" class=""btn file btn-info"" value=""Upload Book"" />
                        <input type=""file"" name=""cover"" id=""cover"" required accept=""image/*"" class=""btn file btn-info"" value=""Upload Book"" />
                        <br />
                        <input type=""text"" readonly name=""tags"" class=""form-control"" id=""book-tags""/>
                        <input type=""submit"" value=""Create Book"" id=""submit-create"" class=""btn btn-success"" />
                        <input type=""button"" value=""Close"" id=""close-create-book"" class=""btn btn-danger"" />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4230, 8640, true);
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>


    <style>
        .book{
            display:inline-block;
            height:15vh;
        }
        .book a *{
            display:inline;
        }
        .custom-modal {
            padding: 2vh;
            display: none;
            position: fixed;
            width: 25vw;
            z-index: 3;
            top: 5vh;
            left: 35vw;
            overflow: auto;
            border: 1px solid black;
            border-radius: 1vh;
            background-color: #ababab;
        }
        .cover{
            height:100%;
        }
    </style>

    <script>
        var facTags = [];
        var bookTags = [];
        $(""#open-create-book"").click(function () {
            $(""#new-book"").css(""display"", ""block"");
            $.ajax({
                method: ""POST"",
                url: ""/Edu/Books/GetTagsByFacultyId/id"",
                data: {
                    id: $(""#faculty"").val()");
                WriteLiteral(@"
                }
            })
                .done(function (obj) {
                    for (var i = 0; i < obj.length; i++) {
                        facTags.push(obj[i].name.toLowerCase())
                    }
                })
                .fail(function (msg) {
                    console.log(msg)
                })
        });

        $(""#close-create-book"").click(function () {
            $(""#new-book"").css(""display"", ""none"");
        });


        $.ajax({
            method: ""GET"",
            url: ""/Edu/Books/GetFaculties"",
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    var fac = document.createElement(""option"");
                    fac.value = data[i].id;
                    fac.innerText = data[i].name
                    document.getElementById(""faculty"").appendChild(fac);
                    var facs = document.createElement(""option"");
                    facs.value = data[i].id;
          ");
                WriteLiteral(@"          facs.innerText = data[i].name
                    document.getElementById(""faculty-search"").appendChild(facs);
                }
            },
        });

        $.ajax({
            method: ""GET"",
            url: ""/Edu/Books/GetLanguages"",
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    var lan = document.createElement(""option"");
                    lan.value = data[i].id;
                    lan.innerText = data[i].name
                    document.getElementById(""language"").appendChild(lan);
                    var lans = document.createElement(""option"");
                    lans.value = data[i].id;
                    lans.innerText = data[i].name
                    document.getElementById(""language-search"").appendChild(lans);
                }
            },
        });

        var files = [];
        var fileReader = new FileReader()
        $('input[type=file]').on('change', function (e) {
     ");
                WriteLiteral(@"       files.push(e.target.files[0]);
        });

        $(""#faculty"").change(function (e) {
            facTags = [];
            bookTags = [];
            $.ajax({
                method: ""POST"",
                url: ""/Edu/Books/GetTagsByFacultyId/id"",
                data: {
                    id: $(e.target).val()
                }
            })
                .done(function (obj) {
                    for (var i = 0; i < obj.length; i++) {
                        facTags.push(obj[i].name.toLowerCase())
                    }
                })
                .fail(function (msg) {
                    console.log(msg)
                })
        });

        $(""#description"").keyup(function (e) {
            var text = $(e.target).val()
            var textArr = text.split("" "")
            for (var i = 0; i < textArr.length; i++) {
                if (facTags.indexOf(textArr[i].toLowerCase()) != -1 && bookTags.indexOf(textArr[i].toLowerCase()) < 0) {
                    bo");
                WriteLiteral(@"okTags.push(textArr[i].toLowerCase())
                }
            }
        });

        $(""#description"").blur(function () {
            var taglist = """";
            $(""#book-tags"").val("""");
            for (var i = 0; i < bookTags.length; i++) {
                var tag = bookTags[i] + "" , "";
                taglist += tag;
            }
            document.getElementById(""book-tags"").value = taglist.substring(0, taglist.length - 2);
        });

        $.ajax({
            method: ""GET"",
            url: ""/Edu/Books/GetAllBooks"",
            success: function (data) {
                for (var i in data) {
                }
                FillBooksOnPage(data)
            }
        });

        $(""#show-all"").click(function () {
            document.getElementById(""books"").innerHTML = """";
            $.ajax({
                method: ""GET"",
                url: ""/Edu/Books/GetAllBooks"",
                success: function (data) {
                    FillBooksOnPage(data)
 ");
                WriteLiteral(@"               }
            });
        });

        function FillBooksOnPage(data) {
            var books = document.getElementById(""books"");

            for (var i = 0; i < data.length; i++) {

                var book = document.createElement(""li"");
                book.classList.add(""list-group-item"", ""book"");

                var hiddenId = document.createElement(""input"");
                hiddenId.setAttribute(""type"", ""hidden"");
                hiddenId.value = data[i].id;

                var likeBtn = document.createElement(""input"");
                likeBtn.type = ""button"";
                likeBtn.classList.add(""btn"", ""btn-success"", ""like"");
                likeBtn.value = ""Like"" + "" "" + data[i].likeCount
                likeBtn.addEventListener(""click"", function (e) {
                    var bookId = $(e.target).next().val();
                    $.ajax({
                        method: ""POST"",
                        url: ""/Edu/Home/LikePost/postId"",
                       ");
                WriteLiteral(@" data: {
                            postId: bookId
                        }
                    })
                        .done(function (obj) {
                            console.log(obj)
                            var text = ""Like "" + obj;
                            $(e.target).val(text)
                        })
                        .fail(function (msg) {
                            console.log(msg)
                        })
                });

                var link = document.createElement(""a"");
                link.target = ""_blank"";
                link.href = data[i].filePath;

                book.appendChild(link);
                book.appendChild(likeBtn);
                book.appendChild(hiddenId);

                var cover = document.createElement(""img"");
                cover.classList.add(""img"", ""img-responsive"", ""cover"")
                cover.src = data[i].imagePath;
                link.appendChild(cover);
               
                var text = do");
                WriteLiteral(@"cument.createElement(""p"");
                text.classList.add(""lead"");
                text.innerText = data[i].name + "" - "" + data[i].author;
                link.appendChild(text);

                books.appendChild(book);
            }
        }

        $(""#faculty-search"").change(function (e) {
            var facId = $(e.target).val();
            $.ajax({
                method: ""POST"",
                url: ""/Edu/Books/GetBooksByFaculty/facultyId"",
                data: {
                    facultyId: facId
                }
            })
                .done(function (obj) {
                    document.getElementById(""books"").innerHTML = """";
                    FillBooksOnPage(obj)
                })
                .fail(function (msg) {
                    console.log(msg)
                })
        })

        $(""#language-search"").change(function (e) {
            var lanId = $(e.target).val()
            $.ajax({
                method: ""POST"",
                u");
                WriteLiteral(@"rl: ""/Edu/Books/GetBooksByLanguage/languageId"",
                data: {
                    languageId: lanId
                }
            })
                .done(function (obj) {
                    document.getElementById(""books"").innerHTML = """";
                    FillBooksOnPage(obj)
                })
                .fail(function (msg) {
                    console.log(msg)
                })
        });

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
            BeginContext(12877, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

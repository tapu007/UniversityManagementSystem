#pragma checksum "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47009facab7ad5c4d6c952c5ebf73a506a51336e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Search), @"mvc.1.0.view", @"/Views/Course/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Search.cshtml", typeof(AspNetCore.Views_Course_Search))]
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
#line 1 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\_ViewImports.cshtml"
using UniversityApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47009facab7ad5c4d6c952c5ebf73a506a51336e", @"/Views/Course/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad95a638237f3f256aa08dc63160873bdeb208b", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<University.Models.EntityModels.Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
  
    ViewData["Title"] = "Search";
    
    

#line default
#line hidden
            BeginContext(115, 30, true);
            WriteLiteral("\r\n<h1>Search</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(145, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47009facab7ad5c4d6c952c5ebf73a506a51336e4936", async() => {
                BeginContext(168, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(182, 128, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered\">\r\n    <thead class=\"bg-secondary\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(311, 46, false);
#line 18 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseCode));

#line default
#line hidden
            EndContext();
            BeginContext(357, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(413, 46, false);
#line 21 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(459, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(515, 42, false);
#line 24 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
            EndContext();
            BeginContext(557, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(613, 48, false);
#line 27 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
            EndContext();
            BeginContext(661, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(717, 46, false);
#line 30 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.SemesterId));

#line default
#line hidden
            EndContext();
            BeginContext(763, 92, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(887, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(936, 15, false);
#line 39 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(item.CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(951, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1007, 15, false);
#line 42 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(item.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1078, 11, false);
#line 45 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(item.Credit);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1145, 30, false);
#line 48 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(item.Department.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1231, 26, false);
#line 51 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
           Write(item.Semester.SemesterName);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 56, true);
            WriteLiteral("\r\n            </td>\r\n            <td >\r\n                ");
            EndContext();
            BeginContext(1313, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47009facab7ad5c4d6c952c5ebf73a506a51336e11404", async() => {
                BeginContext(1364, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
                                       WriteLiteral(item.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1392, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47009facab7ad5c4d6c952c5ebf73a506a51336e13803", async() => {
                BeginContext(1446, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
                                          WriteLiteral(item.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1457, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1477, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47009facab7ad5c4d6c952c5ebf73a506a51336e16208", async() => {
                BeginContext(1530, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
                                         WriteLiteral(item.CourseId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1540, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Course\Search.cshtml"
}

#line default
#line hidden
            BeginContext(1579, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<University.Models.EntityModels.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591

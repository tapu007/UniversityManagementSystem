#pragma checksum "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8d97148669a21a696d8daaf252b3bdbffb0cb94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DepartmentWiseCourse), @"mvc.1.0.view", @"/Views/Shared/_DepartmentWiseCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DepartmentWiseCourse.cshtml", typeof(AspNetCore.Views_Shared__DepartmentWiseCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d97148669a21a696d8daaf252b3bdbffb0cb94", @"/Views/Shared/_DepartmentWiseCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad95a638237f3f256aa08dc63160873bdeb208b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DepartmentWiseCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<University.Models.EntityModels.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 157, true);
            WriteLiteral("\r\n<table class=\"table table-bordered table-active\">\r\n    <thead class=\"bg-secondary\">\r\n        <tr class=\"label-primary\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(217, 46, false);
#line 7 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseCode));

#line default
#line hidden
            EndContext();
            BeginContext(263, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(319, 46, false);
#line 10 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(365, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(421, 42, false);
#line 13 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
            EndContext();
            BeginContext(463, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(519, 61, false);
#line 16 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.Department.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(580, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(636, 57, false);
#line 19 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
           Write(Html.DisplayNameFor(model => model.Semester.SemesterName));

#line default
#line hidden
            EndContext();
            BeginContext(693, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(828, 75, true);
            WriteLiteral("            <tr class=\"active\">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(904, 15, false);
#line 29 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.CourseCode);

#line default
#line hidden
            EndContext();
            BeginContext(919, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(987, 15, false);
#line 32 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1070, 11, false);
#line 35 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.Credit);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1149, 30, false);
#line 38 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.Department.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1247, 26, false);
#line 41 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
               Write(item.Semester.SemesterName);

#line default
#line hidden
            EndContext();
            BeginContext(1273, 61, true);
            WriteLiteral("\r\n                </td>\r\n               \r\n            </tr>\r\n");
            EndContext();
#line 45 "C:\Users\User\Desktop\Asp.Net Core Project\University-Management-System\UniversityApp\UniversityApp\Views\Shared\_DepartmentWiseCourse.cshtml"
        }

#line default
#line hidden
            BeginContext(1345, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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

#pragma checksum "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b022c133e9f6b546262d443c6efbcc5a6899364"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
using Microsoft.Extensions.WebEncoders.Testing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b022c133e9f6b546262d443c6efbcc5a6899364", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Course List</h3>

<table align=""center"" class=""table"" style=""width: 70%; padding: 5px; text-align: center;"">
    <caption style=""caption-side: top; text-align: center; font-size: 1.8em; color: black;"">Required Course</caption>
    <thead>
        <tr>
            <th>Course Id</th>
            <th>Course Name</th>
            <th>Credit</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
      
        var requiredCourses = Model.Where(o => o.Type == "Required");
        foreach (Course course in requiredCourses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
               Write(Html.DisplayFor(modelCourses => course.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
               Write(Html.DisplayFor(modelCourses => course.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
               Write(Html.DisplayFor(modelCourses => course.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<table align=""center"" class=""table"" style=""width: 70%; padding: 5px; text-align: center;"">
    <caption style=""caption-side: top; text-align: center; font-size: 1.8em; color: black;"">Elective Course</caption>
    <thead>
        <tr>
            <th>Course Id</th>
            <th>Course Name</th>
            <th>Credit</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 43 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
      
        var electiveCourses = Model.Where(o => o.Type == "Elective");
        foreach (Course course in electiveCourses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
               Write(Html.DisplayFor(modelCourses => course.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
               Write(Html.DisplayFor(modelCourses => course.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
               Write(Html.DisplayFor(modelCourses => course.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\Course\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<style>\r\n    th, td {\r\n        border-bottom: 1px solid #AAAAAA;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591

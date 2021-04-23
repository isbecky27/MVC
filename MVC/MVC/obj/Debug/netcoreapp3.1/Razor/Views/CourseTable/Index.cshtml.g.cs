#pragma checksum "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ac586716a25dc6fb282647216023b4d6c19aaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseTable_Index), @"mvc.1.0.view", @"/Views/CourseTable/Index.cshtml")]
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
#line 1 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
using Microsoft.Extensions.WebEncoders.Testing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ac586716a25dc6fb282647216023b4d6c19aaa", @"/Views/CourseTable/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseTable_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CurrentCourse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
  
    ViewData["Title"] = "Index";
    List<Course> Courses = ViewBag.Courses;
    List<int> MyCourseNo = ViewBag.MyCourseNo;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Course Table</h3>

<div>
    <table class=""table"" style=""width: 100%; padding: 5px; text-align: center;"">
        <caption style=""caption-side: top; text-align: center; font-size: 1.8em; color: black;"">Current Courses</caption>
        <thead>
        <tr>
            <th>Course No.</th>
            <th>Course Id</th>
            <th>Course Name</th>
            <th>Type</th>
            <th>Teacher</th>
            <th>Course Time</th>
            <th>Credit</th>
            <th>Size Limits</th>
            <th>Registered Numbers</th>
            <th>Action</th>
        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
          
            foreach (CurrentCourse currentCourse in Model)
            {
                var course = Courses.Where(O => O.Id == currentCourse.Id).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => currentCourse.CourseNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => currentCourse.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => course.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => course.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => currentCourse.Teacher));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => currentCourse.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => course.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => currentCourse.SizeLimits));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.DisplayFor(modelCourses => currentCourse.RegisteredNumbers));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 44 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                         if (currentCourse.RegisteredNumbers < currentCourse.SizeLimits && !MyCourseNo.Contains(currentCourse.Id))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 46 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                           Write(Html.ActionLink("Add", "AddCourse", routeValues: new { courseNo = currentCourse.CourseNo }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 47 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 50 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                           Write(Html.ActionLink("Add", "AddCourse", routeValues: new { courseNo = currentCourse.CourseNo }, new { @class = "btn btn-success disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n<style>\r\n    th, td {\r\n        border-bottom: 1px solid #AAAAAA;\r\n    }\r\n</style>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\"button\").click(function () {\r\n            var courseName = $(this).val();\r\n            alert(\"add \" + courseName + \" into Class Schedule\");\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CurrentCourse>> Html { get; private set; }
    }
}
#pragma warning restore 1591

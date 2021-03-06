#pragma checksum "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "906ef5adf06c75a073fc8b7d8ba78f3a0dfd332c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906ef5adf06c75a073fc8b7d8ba78f3a0dfd332c", @"/Views/CourseTable/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseTable_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CurrentCourse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
  
    ViewData["Title"] = "Index";
    List<Course> courses = ViewBag.Courses;
    List<CurrentCourse> myCourses = ViewBag.MyCourses;
    var myCourseNo = myCourses.Select(o => o.CourseNo);
    var myCourseId = myCourses.Select(o => o.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Course Timetable</h3>
<p class=""text-info"">* The Course with same Course Id can only be selected once.</p>
<div>
    <table class=""table"" style=""width: 100%; padding: 5px; text-align: center;"">
        <caption style=""caption-side: top; text-align: center; font-size: 1.8em; color: black;"">Current Course</caption>
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
#line 32 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
          
            foreach (CurrentCourse currentCourse in Model)
            {
                var course = courses.Where(O => O.Id == currentCourse.Id).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => currentCourse.CourseNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => currentCourse.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => course.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => course.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => currentCourse.Teacher));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => currentCourse.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => course.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => currentCourse.SizeLimits));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                   Write(Html.DisplayFor(modelCourses => currentCourse.RegisteredNumbers));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                     if (myCourseNo.Contains(currentCourse.CourseNo))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 48 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.ActionLink("Added", "AddCourse", routeValues: new { courseNo = currentCourse.CourseNo }, new { @class = "btn btn-secondary disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                    }
                    else if (currentCourse.RegisteredNumbers < currentCourse.SizeLimits && !myCourseId.Contains(currentCourse.Id))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 52 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.ActionLink("Add", "AddCourse", routeValues: new { courseNo = currentCourse.CourseNo }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 56 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                       Write(Html.ActionLink("Add", "AddCourse", routeValues: new { courseNo = currentCourse.CourseNo }, new { @class = "btn btn-success disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\becky.tseng25\Desktop\MVC\MVC\MVC\Views\CourseTable\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<style>\r\n    th, td {\r\n        border-bottom: 1px solid #AAAAAA;\r\n    }\r\n</style>");
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

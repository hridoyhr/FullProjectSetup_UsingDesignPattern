#pragma checksum "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\Attendance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b38865dcd00dcacf4e01e1872f8a6cd321a24c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Attendance_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Attendance/Index.cshtml")]
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
#line 1 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\_ViewImports.cshtml"
using AttendanceSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\_ViewImports.cshtml"
using AttendanceSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\_ViewImports.cshtml"
using AttendanceSystem.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9b38865dcd00dcacf4e01e1872f8a6cd321a24c", @"/Areas/Admin/Views/Attendance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab9e60418eea8fe8103343d0e42545189f1dd8cc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Attendance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\Attendance\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 8 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\Attendance\Index.cshtml"
   
    foreach(var student in Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 11 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\Attendance\Index.cshtml"
       Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><h2>");
#nullable restore
#line 11 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\Attendance\Index.cshtml"
                             Write(student.StudentRollNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2><br/>\r\n");
#nullable restore
#line 12 "G:\All C# File\Dev Skill All Course\Asp.NetCoreMvc-AllFile-B5\SourceCode\DevSkill_Project\FullProjectSetup_UsingDesignPattern\AttendanceSystem\AttendanceSystem\Areas\Admin\Views\Attendance\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

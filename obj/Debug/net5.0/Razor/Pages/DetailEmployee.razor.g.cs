#pragma checksum "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e023c777f4fb162e452e96b3f3020257a4c8123"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor72190280.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Blazor72190280;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\_Imports.razor"
using Blazor72190280.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{id}")]
    public partial class DetailEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
 if(Employee == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 5 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-8");
            __builder.OpenElement(5, "h1");
            __builder.AddContent(6, 
#nullable restore
#line 9 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
                 Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
                                     Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body text-center");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "card-img-top");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 12 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
                                            Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "h4");
            __builder.AddContent(17, "Employee ID: ");
            __builder.AddContent(18, 
#nullable restore
#line 13 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
                              Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "h4");
            __builder.AddContent(21, "Email: ");
            __builder.AddContent(22, 
#nullable restore
#line 14 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
                        Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<div class=\"card-footer text-center\"><a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n            <a href=\"/\" class=\"btn btn-primary\">Edit</a>\r\n            <a href=\"/\" class=\"btn btn-danger\">Delete</a></div>");
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Pemrograman Front-End (Semester 5)\Blazor72190280\Pages\DetailEmployee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
#pragma checksum "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f981e37687d4f4b2cdd7f496d309e472c845d0"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>\r\n");
#nullable restore
#line 5 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 8 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 13 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
     foreach (var employee in Employees)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "     ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card m-3");
            __builder.AddAttribute(8, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.AddMarkupContent(9, "\r\n         ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-header");
            __builder.AddMarkupContent(12, "\r\n             ");
            __builder.OpenElement(13, "h3");
            __builder.AddContent(14, 
#nullable restore
#line 17 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                  employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                      employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n         ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 19 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                        employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n         ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-footer text-center");
            __builder.AddMarkupContent(25, "\r\n             ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", 
#nullable restore
#line 21 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                        $"employeedetails/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "btn btn-primary m-1");
            __builder.AddContent(29, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n             ");
            __builder.AddMarkupContent(31, "<a href=\"#\" class=\"btn btn-primary m-1\">Edit</a>\r\n             \r\n             ");
            __builder.AddMarkupContent(32, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 28 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 30 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

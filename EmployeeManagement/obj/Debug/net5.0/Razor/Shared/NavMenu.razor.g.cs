#pragma checksum "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3c13a407fc4f025f8268b78ce42b018e128e91"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\_Imports.razor"
using EmployeeManagement.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "top-row pl-4 navbar navbar-dark");
                __builder2.AddAttribute(4, "b-gu6h5vnoip");
                __builder2.AddMarkupContent(5, "<a class=\"navbar-brand\" href b-gu6h5vnoip>EmployeeManagement</a>\r\n            ");
                __builder2.OpenElement(6, "button");
                __builder2.AddAttribute(7, "class", "navbar-toggler");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor"
                                                     ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "b-gu6h5vnoip");
                __builder2.AddMarkupContent(10, "<span class=\"navbar-toggler-icon\" b-gu6h5vnoip></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenElement(12, "li");
                __builder2.AddAttribute(13, "class", "nav-item px-3");
                __builder2.AddAttribute(14, "b-gu6h5vnoip");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
                __builder2.AddAttribute(16, "class", "nav-link");
                __builder2.AddAttribute(17, "href", "/CreateEmployee");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-gu6h5vnoip></span> Create\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "class", "nav-item px-3");
                __builder2.AddAttribute(23, "b-gu6h5vnoip");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
                __builder2.AddAttribute(25, "class", "nav-link");
                __builder2.AddAttribute(26, "href", "/identity/account/login");
                __builder2.AddAttribute(27, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 18 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor"
                                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "<span class=\"oi oi-lock-locked\" aria-hidden=\"true\" b-gu6h5vnoip></span> Login\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(30, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddAttribute(33, "b-gu6h5vnoip");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "/identity/account/logout");
                __builder2.AddAttribute(37, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 25 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor"
                                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "<span class=\"oi oi-power-standby\" aria-hidden=\"true\" b-gu6h5vnoip></span> Logout\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", 
#nullable restore
#line 30 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "b-gu6h5vnoip");
                __builder2.OpenElement(45, "ul");
                __builder2.AddAttribute(46, "class", "nav flex-column");
                __builder2.AddAttribute(47, "b-gu6h5vnoip");
                __builder2.OpenElement(48, "li");
                __builder2.AddAttribute(49, "class", "nav-item px-3");
                __builder2.AddAttribute(50, "b-gu6h5vnoip");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "class", "nav-link");
                __builder2.AddAttribute(53, "href", "");
                __builder2.AddAttribute(54, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 33 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(56, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-gu6h5vnoip></span> Home\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.OpenElement(58, "li");
                __builder2.AddAttribute(59, "class", "nav-item px-3");
                __builder2.AddAttribute(60, "b-gu6h5vnoip");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
                __builder2.AddAttribute(62, "class", "nav-link");
                __builder2.AddAttribute(63, "href", "/Employeelist");
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(65, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-gu6h5vnoip></span> list\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.OpenElement(67, "li");
                __builder2.AddAttribute(68, "class", "nav-item px-3");
                __builder2.AddAttribute(69, "b-gu6h5vnoip");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(70);
                __builder2.AddAttribute(71, "class", "nav-link");
                __builder2.AddAttribute(72, "href", "/CreateEmployee");
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(74, "<span class=\"oi oi-file\" aria-hidden=\"true\" b-gu6h5vnoip></span> Create\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\anaas\source\repos\EmployeeManagement\EmployeeManagement\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
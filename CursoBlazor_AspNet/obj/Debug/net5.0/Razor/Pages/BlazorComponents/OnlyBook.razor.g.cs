#pragma checksum "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fbce136aa89ec9048502ebf8abeae1dc95b90a3"
// <auto-generated/>
#pragma warning disable 1591
namespace CursoBlazor_AspNet.Pages.BlazorComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using CursoBlazor_AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using CursoBlazor_AspNet.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using CursoBlazor_AspNet.Pages.BlazorComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\_Imports.razor"
using CursoBlazor_AspNet.Models;

#line default
#line hidden
#nullable disable
    public partial class OnlyBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light border p-2 col-5");
            __builder.OpenElement(2, "h4");
            __builder.AddAttribute(3, "class", "text-secondary");
            __builder.AddContent(4, "Libro: ");
            __builder.AddContent(5, 
#nullable restore
#line 4 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
                                       book.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
     book.bookName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, " <br>\r\n    ");
            __builder.AddContent(9, 
#nullable restore
#line 6 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
     book.price.ToString("")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, " <br>\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "checked", 
#nullable restore
#line 7 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
                                                               book.stock?"Checked":null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
                                        book.stock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.stock = __value, book.stock));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, " Esta Agotado\r\n    <br>\r\n    ");
            __builder.OpenElement(17, "span");
            __builder.AddContent(18, "Este Libro esta : ");
            __builder.AddContent(19, 
#nullable restore
#line 9 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
                              book.stock ?"Agotado":"Disponible"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
     if (!book.stock)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
         foreach (var booktype in book.bookType)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "p");
            __builder.AddContent(21, 
#nullable restore
#line 15 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
                booktype.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " - ");
            __builder.AddContent(23, 
#nullable restore
#line 15 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
                                 booktype.value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
         
    }

    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<CursoBlazor_AspNet.Pages.BlazorComponents.ButtonsComponents>(24);
            __builder.AddAttribute(25, "EsAdmin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\CURSOS\UDEMY\Master Blazor y ASP.NET Core 5\CursoBlazor_AspNet\Pages\BlazorComponents\OnlyBook.razor"
       

    [Parameter]

    public BookBlazor book { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

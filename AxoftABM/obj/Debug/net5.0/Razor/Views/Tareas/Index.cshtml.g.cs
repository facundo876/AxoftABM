#pragma checksum "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a1c2d633c751eaff9a8504c5c66d838674b5c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tareas_Index), @"mvc.1.0.view", @"/Views/Tareas/Index.cshtml")]
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
#line 1 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\_ViewImports.cshtml"
using AxoftABM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\_ViewImports.cshtml"
using AxoftABM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a1c2d633c751eaff9a8504c5c66d838674b5c3", @"/Views/Tareas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b957288a1474fd8a2557cd92c9e4505c2fbdc580", @"/Views/_ViewImports.cshtml")]
    public class Views_Tareas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tarea>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
 if (TempData["Mensaje"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 5 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
                                Write(TempData["Mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 6 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tareas</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
Write(Html.ActionLink("Crear nueva tarea", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
 using (Html.BeginForm("FilterByEstado", "Tareas", FormMethod.Get))
{
    if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"estado\">Filtrar por estado:</label>\r\n            <select name=\"estado\" id=\"estado\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a1c2d633c751eaff9a8504c5c66d838674b5c34929", async() => {
                WriteLiteral("Todos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a1c2d633c751eaff9a8504c5c66d838674b5c36103", async() => {
                WriteLiteral("Activa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
                   WriteLiteral(EstadoTarea.Activa);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a1c2d633c751eaff9a8504c5c66d838674b5c37739", async() => {
                WriteLiteral("Completada");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
                   WriteLiteral(EstadoTarea.Completada);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a1c2d633c751eaff9a8504c5c66d838674b5c39383", async() => {
                WriteLiteral("Diferida");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
                   WriteLiteral(EstadoTarea.Diferida);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n");
#nullable restore
#line 28 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\" style=\"margin-top : 10px;\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 38 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 41 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaVencimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 44 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaVencimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 65 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
                 if (item.Estado != EstadoTarea.Completada)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
               Write(Html.ActionLink("Completada", "MarcarCompletada", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
                                                                                                                                
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
           Write(Html.ActionLink("Detalles", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 72 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 73 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 76 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tarea>> Html { get; private set; }
    }
}
#pragma warning restore 1591

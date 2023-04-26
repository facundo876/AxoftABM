#pragma checksum "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20d2deea76f649374235dafdcdb24bca675ef6ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tareas_Create), @"mvc.1.0.view", @"/Views/Tareas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20d2deea76f649374235dafdcdb24bca675ef6ef", @"/Views/Tareas/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b957288a1474fd8a2557cd92c9e4505c2fbdc580", @"/Views/_ViewImports.cshtml")]
    public class Views_Tareas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AxoftABM.Models.Tarea>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Crear Tarea</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
 using (Html.BeginForm("Create", "Tareas", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 10 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
   Write(Html.LabelFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Descripcion, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Descripcion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label class=\"control-label\">Fecha Vencimiento</label>\r\n        ");
#nullable restore
#line 29 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
   Write(Html.TextBoxFor(model => model.FechaVencimiento, "{0:dd/MM/yyyy}", new { @class = "form-control datepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 30 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.FechaVencimiento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Crear\" class=\"btn btn-primary\" />\r\n        ");
#nullable restore
#line 35 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
   Write(Html.ActionLink("Cancelar", "Index", null, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\farce\Desktop\Nueva carpeta (4)\AxoftABM\AxoftABM\Views\Tareas\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.29.1/moment.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.29.1/locale/es.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/datetimepicker@2.5.20/dist/jquery.datetimepicker.full.min.js""></script>

    <script>
        // Configurar el selector de fecha y hora
        $("".datetimepicker"").datetimepicker({
            format: ""YYYY-MM-DD HH:mm"",
            locale: ""es""
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AxoftABM.Models.Tarea> Html { get; private set; }
    }
}
#pragma warning restore 1591
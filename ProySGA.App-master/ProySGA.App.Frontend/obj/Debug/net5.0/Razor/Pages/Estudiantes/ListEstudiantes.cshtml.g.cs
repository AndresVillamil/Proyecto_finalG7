#pragma checksum "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e04070e274a2b79cb49cfdd97417b83bdd45c55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProySGA.App.Frontend.Pages.Estudiantes.Pages_Estudiantes_ListEstudiantes), @"mvc.1.0.razor-page", @"/Pages/Estudiantes/ListEstudiantes.cshtml")]
namespace ProySGA.App.Frontend.Pages.Estudiantes
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
#line 1 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\_ViewImports.cshtml"
using ProySGA.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e04070e274a2b79cb49cfdd97417b83bdd45c55", @"/Pages/Estudiantes/ListEstudiantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53508a17fa09b09a7ab9d1dcadd1863e151bd024", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estudiantes_ListEstudiantes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetailsEstudiantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditEstudiantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteEstudiantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
  
    var searchString =Model.searchString;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de Estudiantes</h1>\r\n<p>\r\n    ");
#nullable restore
#line 9 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
Write(Html.ActionLink("Limpiar", "./ListEstudiantes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 12 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
 using(Html.BeginForm()) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Buscar por Nombres: ");
#nullable restore
#line 15 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
                       Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Buscar\"/>\r\n    </p>    \r\n");
#nullable restore
#line 18 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n          <th>Id</th> \r\n          <th>Nombres</th> \r\n          <th>Apellidos</th> \r\n          <th>Dirección</th> \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
         foreach (var estudiante in Model.estudiantes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n               <td>");
#nullable restore
#line 33 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
              Write(estudiante.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n               <td>");
#nullable restore
#line 34 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
              Write(estudiante.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n               <td>");
#nullable restore
#line 35 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
              Write(estudiante.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n               <td>");
#nullable restore
#line 36 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
              Write(estudiante.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n               <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e04070e274a2b79cb49cfdd97417b83bdd45c558038", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-info-circle fa-sm\"></i>Detalles\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-estudianteId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
                                                                                                     WriteLiteral(estudiante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-estudianteId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e04070e274a2b79cb49cfdd97417b83bdd45c5510500", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-address-book fa-sm\" aria-hidden=\"true\"></i>Editar\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-estudianteId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
                                                                                                  WriteLiteral(estudiante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-estudianteId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e04070e274a2b79cb49cfdd97417b83bdd45c5512980", async() => {
                WriteLiteral("\r\n                        Eliminar\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-estudianteId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
                                                                                                   WriteLiteral(estudiante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-estudianteId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n               </td>\r\n           </tr> \r\n");
#nullable restore
#line 49 "C:\Compartido\ProySGA.App\ProySGA.App.Frontend\Pages\Estudiantes\ListEstudiantes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e04070e274a2b79cb49cfdd97417b83bdd45c5515663", async() => {
                WriteLiteral("Nuevo Estudiante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProySGA.App.Frontend.ListEstudiantesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProySGA.App.Frontend.ListEstudiantesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProySGA.App.Frontend.ListEstudiantesModel>)PageContext?.ViewData;
        public ProySGA.App.Frontend.ListEstudiantesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

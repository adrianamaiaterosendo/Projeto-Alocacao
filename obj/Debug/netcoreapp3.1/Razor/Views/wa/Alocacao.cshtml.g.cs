#pragma checksum "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab86b1b030ca2fb8853c6c67fb34e6e2fb4ff773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_wa_Alocacao), @"mvc.1.0.view", @"/Views/wa/Alocacao.cshtml")]
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
#line 1 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\_ViewImports.cshtml"
using Desafio_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\_ViewImports.cshtml"
using Desafio_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab86b1b030ca2fb8853c6c67fb34e6e2fb4ff773", @"/Views/wa/Alocacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccba478bb7f14cac52112a4a4373e872b241e336", @"/Views/_ViewImports.cshtml")]
    public class Views_wa_Alocacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Desafio_MVC.Models.Alocacao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alocar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Wa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab86b1b030ca2fb8853c6c67fb34e6e2fb4ff7734260", async() => {
                WriteLiteral("Alocar Funcionário");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr>\r\n\r\n    <h2>Alocar Funcionários</h2>\r\n    <hr>\r\n");
            WriteLiteral(@"

<script>   $(document).ready( function () {
    $('#Alocacao').DataTable({
        ""language"": {
            ""lengthMenu"" : ""Mostrando _MENU_ registros por página"",
            ""zeroRecords"": ""Nenhuma Alocação Cadastrada"",
            ""info"": ""Mostrando página _PAGE_ de _PAGE_"",
            ""infoEmpty"": ""Nenhum registro disponível"",
            ""search"": ""Pesquisar:"",
            ""paginate"": {
                ""first"" : ""Primeiro"",
                ""last"": ""Último"",
                ""next"": ""Próximo"",
                ""previous"": ""Anterior""
                
            }

        }
    
    });
});
</script>

<table id=""Alocacao"" class= ""table table-striped table-bordered"">
    <h4>Lista de Alocações</h4>
  <thead>
    <tr>
        <th>Data Início Alocação</th>
        <th>Nome Projeto</th>
        <th>Cliente</th>
        <th>Código Vaga</th>
        <th>Nome Funcionário</th>
        <th>Ações</th>
    </tr>
</thead>
<tbody>
    
");
#nullable restore
#line 162 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
      foreach (var alocacao in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 165 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
       Write(alocacao.InicioAlocacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n        <td>");
#nullable restore
#line 166 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
       Write(alocacao.Vaga.Projeto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 167 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
       Write(alocacao.Vaga.Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 168 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
       Write(alocacao.Vaga.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td>");
#nullable restore
#line 169 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
       Write(alocacao.Funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n       \r\n        <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 4311, "\"", 4349, 2);
            WriteAttributeValue("", 4318, "/wa/EditarAlocacao/", 4318, 19, true);
#nullable restore
#line 171 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
WriteAttributeValue("", 4337, alocacao.Id, 4337, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", "href=\"", 4387, "\"", 4423, 2);
            WriteAttributeValue("", 4393, "/Alocacao/Deletar/", 4393, 18, true);
#nullable restore
#line 171 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
WriteAttributeValue("", 4411, alocacao.Id, 4411, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Deletar</a></td>    \r\n    \r\n    </tr>\r\n");
#nullable restore
#line 174 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Alocacao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table><br>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Desafio_MVC.Models.Alocacao>> Html { get; private set; }
    }
}
#pragma warning restore 1591

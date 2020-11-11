#pragma checksum "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ebf7c398a07774429fb2a46b39607d7b70fa4c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_wa_Historico), @"mvc.1.0.view", @"/Views/wa/Historico.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ebf7c398a07774429fb2a46b39607d7b70fa4c4", @"/Views/wa/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccba478bb7f14cac52112a4a4373e872b241e336", @"/Views/_ViewImports.cshtml")]
    public class Views_wa_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Desafio_MVC.Models.Alocacao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<hr>
    <h2>Histórico de Alocações - WA</h2>
    <hr>

<script>   $(document).ready( function () {
    $('#Alocacao').DataTable({
        ""language"": {
            ""lengthMenu"" :""Mostrando _MENU_ registros por página"",
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
  <thead>
    <tr>
        <th>Nome Funcionário</th>
        <th>Cliente</th>
        <th>Nome Projeto</th>
        <th>Cód Vaga</th>
        <th>Início WA</th>
        <th>Data Início Alocação</th>        
        
    </tr>
</thead>
<tbody>
  ");
            WriteLiteral("  \r\n");
#nullable restore
#line 48 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
      foreach (var alocacao in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n\r\n          <td>");
#nullable restore
#line 52 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
         Write(alocacao.Funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td>");
#nullable restore
#line 53 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
         Write(alocacao.Vaga.Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td>");
#nullable restore
#line 54 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
         Write(alocacao.Vaga.Projeto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 55 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
         Write(alocacao.Vaga.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 56 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
         Write(alocacao.Funcionario.InicioWa.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 57 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
         Write(alocacao.InicioAlocacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n               \r\n        \r\n    \r\n    </tr>\r\n");
#nullable restore
#line 62 "C:\Users\AAIO\My Private Documents\Curso-MVC\Desafio-MVC\Views\wa\Historico.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table><br>\r\n\r\n<a href=\"javascript:history.back();\">Voltar</a>");
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

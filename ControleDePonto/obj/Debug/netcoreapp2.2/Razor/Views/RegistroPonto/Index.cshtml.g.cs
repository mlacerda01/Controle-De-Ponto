#pragma checksum "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5858914dd41effcfb993a19d0a4e3bc6d0bf7d95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroPonto_Index), @"mvc.1.0.view", @"/Views/RegistroPonto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroPonto/Index.cshtml", typeof(AspNetCore.Views_RegistroPonto_Index))]
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
#line 1 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\_ViewImports.cshtml"
using ControleDePonto;

#line default
#line hidden
#line 2 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\_ViewImports.cshtml"
using ControleDePonto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5858914dd41effcfb993a19d0a4e3bc6d0bf7d95", @"/Views/RegistroPonto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec80519adf7670f0a7a75314b6e5fa3b5c667b2", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroPonto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleDePonto.Models.RegistroPonto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 915, true);
            WriteLiteral(@"
<style>

    table tr td {
        text-align: center;
    }

    table th {
        text-align: center;
    }
</style>

<div class=""panel panel-primary"" style=""border-color:black;"">
    <div class=""panel-heading"" style=""background-color:black;"">
        <strong>Listagem de Ponto</strong>
    </div>
    <div class=""panel-body"">
        <div class=""form-group col-lg-12"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Data</th>
                        <th>Entrada</th>
                        <th>Saida Almoço</th>
                        <th>Retorno Almoço</th>
                        <th>Saida</th>
                        <th>Total Horas</th>
                        <th>Descrição</th>
                        <th>Ações</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 34 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1046, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1109, 32, false);
#line 37 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                           Write(item.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1181, 16, false);
#line 38 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                           Write(item.HoraEntrada);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1237, 20, false);
#line 39 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                           Write(item.HoraSaidaAlmoco);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1297, 22, false);
#line 40 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                           Write(item.HoraRetornoAlmoco);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1359, 14, false);
#line 41 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                           Write(item.HoraSaida);

#line default
#line hidden
            EndContext();
            BeginContext(1373, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1413, 15, false);
#line 42 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                           Write(item.TotalHoras);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1505, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1538, 24, false);
#line 44 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                           Write(item.DescricaoAtividades);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 119, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <button class=\"btn btn-default edit\" data-id=\"");
            EndContext();
            BeginContext(1682, 16, false);
#line 46 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                                                                         Write(item.CodRegistro);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 149, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-edit\" title=\"Editar\"></i></button>\r\n                                <button class=\"btn btn-default details\" data-id=\"");
            EndContext();
            BeginContext(1848, 16, false);
#line 47 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                                                                            Write(item.CodRegistro);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 151, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-file\" title=\"Detalhes\"></i></button> \r\n                                <button class=\"btn btn-default delete\" data-id=\"");
            EndContext();
            BeginContext(2016, 16, false);
#line 48 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                                                                           Write(item.CodRegistro);

#line default
#line hidden
            EndContext();
            BeginContext(2032, 170, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-remove\" title=\"Excluir\" ></i></button>                                \r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2225, 431, true);
            WriteLiteral(@"
                </tbody>
            </table>
        </div>

        <!--As telas seram carregadas dentro desse modal-->
        <div class=""modal"" id=""modal"">

        </div>
    </div>
    <div class=""panel-footer"" style=""padding-bottom:25px;"">
        <div class=""form-group"">
            <div class=""form-group col-lg-9"">
                <p>
                    <b>
                        Total de registros: ");
            EndContext();
            BeginContext(2657, 13, false);
#line 67 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
                                       Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2670, 257, true);
            WriteLiteral(@"
                    </b>
                </p>
            </div>
            <div class=""form-group col-lg-3"" style=""text-align:right;"">
                <button class=""btn btn-default novo"" style=""background:black; color:#ffffff;"">Cadastrar</button>
");
            EndContext();
            BeginContext(3039, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3057, "\"", 3106, 1);
#line 74 "C:\Users\Sysdba\source\repos\Controle-De-Ponto\ControleDePonto\Views\RegistroPonto\Index.cshtml"
WriteAttributeValue("", 3064, Url.Action("GerarExcel", "RegistroPonto"), 3064, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3107, 984, true);
            WriteLiteral(@" class=""btn btn-primary"" style=""background:black; color:#ffffff;"">Exportar</a>
            </div>
        </div>
    </div>    
</div>


<script>

    $("".edit"").click(function () {
        var id = $(this).attr(""data-id"");        
        $(""#modal"").load(""RegistroPonto/Atualizar?id="" + id, function () {
            $(""#modal"").show();
        })
    });


    $("".details"").click(function () {
        var id = $(this).attr(""data-id"");
        $(""#modal"").load(""RegistroPonto/Detalhes?id="" + id, function () {
            $(""#modal"").show();
        })
    });

     $("".delete"").click(function () {
        var id = $(this).attr(""data-id"");
        $(""#modal"").load(""RegistroPonto/Deletar?id="" + id, function () {
            $(""#modal"").show();
        })
    });

    $("".novo"").click(function(){
        $(""#modal"").load(""RegistroPonto/Adicionar"", function () {
            $(""#modal"").show();
        })
            
    });

</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleDePonto.Models.RegistroPonto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

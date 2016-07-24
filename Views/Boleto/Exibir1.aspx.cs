using Impactro.Cobranca;
using System;

namespace BoletoMVC.Views.Boleto
{
    public partial class Exibir1 : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Definição dos dados do cedente
            CedenteInfo Cedente = new CedenteInfo();
            Cedente.Cedente = "Teste de Cedente";
            Cedente.Banco = "341";
            Cedente.Agencia = "0646";
            Cedente.Conta = "9105-8";
            Cedente.Carteira = "167";
            Cedente.Endereco = "endereço do recebedor";
            Cedente.CNPJ = "12.345.678/0000-12";

            // Definição dos dados do sacado
            SacadoInfo Sacado = new SacadoInfo();
            Sacado.Sacado = "Fabio Ferreira (Teste)";
            Sacado.Documento = "123.456.789-99";
            Sacado.Endereco = "Av. Paulista, 1234";
            Sacado.Cidade = "São Paulo";
            Sacado.Bairro = "Centro";
            Sacado.Cep = "12345-123";
            Sacado.UF = "SP";

            // Definição das Variáveis do boleto
            BoletoInfo Boleto = new BoletoInfo();
            Boleto.NossoNumero = Boleto.NumeroDocumento = "00046356";
            Boleto.ValorDocumento = 3070.14;
            Boleto.DataDocumento = DateTime.Now;
            Boleto.DataVencimento = DateTime.Parse("10/07/2008");
            Boleto.Instrucoes = "Todas as informações deste bloqueto são de exclusiva responsabilidade do cedente";

            // monta o boleto com os dados específicos nas classes
            bltPag.MakeBoleto(Cedente, Sacado, Boleto);

        }
    }
}
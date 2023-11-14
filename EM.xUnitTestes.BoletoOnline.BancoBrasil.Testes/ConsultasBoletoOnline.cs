using BoletoOnlineAPI.BoletoOnline.BancoBrasil;
using static BoletoOnlineAPI.BoletoOnline.BancoBrasil.Cobranca.ConsulteBoletoResponse.ConsulteBoletoResponse;

namespace EM.xUnitTestes.BoletoOnline.BancoBrasil.Testes
{
    public class ConsultasBoletoOnline
    {
        [Fact]
        public async Task Deve_Consultar_Boletos_Com_Sucesso()
        {
            await new ProcessoBoletoOnline().ConsulteBoletos();
        }

        [Fact]
        public async Task Deve_Consultar_Boleto_ID_Com_Sucesso()
        {
            string idNumeroTituloCliente = "00031285579900000021";
            string numeroConvenio = "3128557";

            await new ProcessoBoletoOnline().ConsulteBoletos(idNumeroTituloCliente, numeroConvenio);
        }

        [Fact]
        public async Task Deve_Baixar_Boleto_Com_Sucesso()
        {
            string idNumeroTituloCliente = "00031285576342298852";
            string numeroConvenio = "3128557";

            await new ProcessoBoletoOnline().BaixeBoleto(idNumeroTituloCliente, numeroConvenio);
        }
        
        [Fact]
        public async Task Consulte_Pix_Auth_Com_Sucesso()
        {
            string txId = "testqrcode01@bb.com.br";

            await new ProcessoBoletoOnline().ConsultePixAuthBoleto(txId);
        }

        [Fact]
        public async Task Deve_Gerar_Pix_Boleto_Com_Sucesso()
        {
            string idNumeroTituloCliente = "00031285579900000011";
            string numeroConvenio = "3128557";

            await new ProcessoBoletoOnline().GerePixBoleto(idNumeroTituloCliente, numeroConvenio);
        }

        [Fact]
        public async Task Deve_Cancelar_Pix_Boleto_Com_Sucesso()
        {
            string idNumeroTituloCliente = "00031285579900000011";
            string numeroConvenio = "3128557";

            await new ProcessoBoletoOnline().CancelePix(idNumeroTituloCliente, numeroConvenio);
        }

        [Fact]
        public async Task Deve_Consultar_Boleto_Pix_Com_Sucesso()
        {
            string idNumeroTituloCliente = "00031285579900000011";
            string numeroConvenio = "3128557";

            await new ProcessoBoletoOnline().ConsultePixBoleto(idNumeroTituloCliente, numeroConvenio);
        }

        [Fact]
        public async Task Deve_Registrar_Boleto_Com_Sucesso()
        {
            RequisicaoRegistroBoletos boleto = new()
            {
                numeroConvenio = 3128557,
                numeroCarteira = 17,
                numeroVariacaoCarteira = 35,
                codigoModalidade = 1, //1-Domínio, 2-Vinculada.
                dataEmissao = "30.01.2023",
                dataVencimento = "28.08.2023",
                valorOriginal = (float)328.12,
                codigoAceite = "A", //A-Aceito, N-Não aceito.
                codigoTipoTitulo = 02,
                indicadorPermissaoRecebimentoParcial = "S",
                numeroTituloCliente = "00031285579900000011",
                pagador = new Pagador
                {
                    nome = "PADARIA MAGALHAES PEREIRA",
                    endereco = "Avenida Dias Gomes 1970",
                    tipoInscricao = 2,
                    cep = 77458000,
                    cidade = "Sucupira",
                    bairro = "Centro",
                    uf = "TO",
                    numeroInscricao = 96795333000123
                }
            };

            await new ProcessoBoletoOnline().RegistreBoleto(boleto);
        }

        [Fact]
        public async Task Deve_Alterar_Boleto_Com_Sucesso()
        {
            AlteracaoBoleto boleto = new()
            {
                numeroConvenio = 3128557,
                indicadorAlterarDataDesconto =       "N",
                indicadorAlterarDesconto=            "N",
                indicadorAlterarPrazoBoletoVencido = "N",
                indicadorAlterarSeuNumero =          "N",
                indicadorAtribuirDesconto =          "N",
                indicadorCancelarProtesto =          "N",
                indicadorCobrarJuros =               "N",
                indicadorCobrarMulta =               "N",
                indicadorDispensarMulta=             "N",
                indicadorIncluirAbatimento=          "N",
                indicadorNegativar =                 "N",
                indicadorNovaDataVencimento=         "N",
                indicadorProtestar =                 "N",
                indicadorSustacaoProtesto=           "N"
            };

            string idTituloCliente = "00031285579900000021";

            await new ProcessoBoletoOnline().AltereBoleto(boleto, idTituloCliente);
        }
    }
}

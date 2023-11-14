namespace BoletoOnlineAPI.BoletoOnline.BancoBrasil.Cobranca.ConsulteBoletoResponse
{
    public class ConsulteBoletoResponse
    {
        public class BeneficiarioFinal
        {
            public int tipoInscricao { get; set; }
            public int numeroInscricao { get; set; }
            public string nome { get; set; }
        }

        public class Desconto
        {
            public int tipo { get; set; }
            public string dataExpiracao { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class JurosMora
        {
            public int tipo { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class Multa
        {
            public int tipo { get; set; }
            public string data { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class Pagador
        {
            public int tipoInscricao { get; set; }
            public long numeroInscricao { get; set; }
            public string nome { get; set; }
            public string endereco { get; set; }
            public int cep { get; set; }
            public string cidade { get; set; }
            public string bairro { get; set; }
            public string uf { get; set; }
            public string telefone { get; set; }
        }
        
        public class SegundoDesconto
        {
            public string dataExpiracao { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class TerceiroDesconto
        {
            public string dataExpiracao { get; set; }
            public int porcentagem { get; set; }
            public int valor { get; set; }
        }

        public class DetalhaBoletoBancarioResponse
        {
            public string codigoLinhaDigitavel { get; set; }
            public string textoEmailPagador { get; set; }
            public string textoMensagemBloquetoTitulo { get; set; }
            public int codigoTipoMulta { get; set; }
            public int codigoCanalPagamento { get; set; }
            public int numeroContratoCobranca { get; set; }
            public int codigoTipoInscricaoSacado { get; set; }
            public long numeroInscricaoSacadoCobranca { get; set; }
            public int codigoEstadoTituloCobranca { get; set; }
            public int codigoTipoTituloCobranca { get; set; }
            public int codigoModalidadeTitulo { get; set; }
            public string codigoAceiteTituloCobranca { get; set; }
            public int codigoPrefixoDependenciaCobrador { get; set; }
            public int codigoIndicadorEconomico { get; set; }
            public string numeroTituloCedenteCobranca { get; set; }
            public int codigoTipoJuroMora { get; set; }
            public string dataEmissaoTituloCobranca { get; set; }
            public string dataRegistroTituloCobranca { get; set; }
            public string dataVencimentoTituloCobranca { get; set; }
            public double valorOriginalTituloCobranca { get; set; }
            public double valorAtualTituloCobranca { get; set; }
            public double valorPagamentoParcialTitulo { get; set; }
            public double valorAbatimentoTituloCobranca { get; set; }
            public double percentualImpostoSobreOprFinanceirasTituloCobranca { get; set; }
            public double valorImpostoSobreOprFinanceirasTituloCobranca { get; set; }
            public double valorMoedaTituloCobranca { get; set; }
            public double percentualJuroMoraTitulo { get; set; }
            public double valorJuroMoraTitulo { get; set; }
            public double percentualMultaTitulo { get; set; }
            public double valorMultaTituloCobranca { get; set; }
            public int quantidadeParcelaTituloCobranca { get; set; }
            public string dataBaixaAutomaticoTitulo { get; set; }
            public string textoCampoUtilizacaoCedente { get; set; }
            public string indicadorCobrancaPartilhadoTitulo { get; set; }
            public string nomeSacadoCobranca { get; set; }
            public string textoEnderecoSacadoCobranca { get; set; }
            public string nomeBairroSacadoCobranca { get; set; }
            public string nomeMunicipioSacadoCobranca { get; set; }
            public string siglaUnidadeFederacaoSacadoCobranca { get; set; }
            public int numeroCepSacadoCobranca { get; set; }
            public double valorMoedaAbatimentoTitulo { get; set; }
            public string dataProtestoTituloCobranca { get; set; }
            public int codigoTipoInscricaoSacador { get; set; }
            public int numeroInscricaoSacadorAvalista { get; set; }
            public string nomeSacadorAvalistaTitulo { get; set; }
            public double percentualDescontoTitulo { get; set; }
            public string dataDescontoTitulo { get; set; }
            public double valorDescontoTitulo { get; set; }
            public int codigoDescontoTitulo { get; set; }
            public double percentualSegundoDescontoTitulo { get; set; }
            public string dataSegundoDescontoTitulo { get; set; }
            public double valorSegundoDescontoTitulo { get; set; }
            public int codigoSegundoDescontoTitulo { get; set; }
            public double percentualTerceiroDescontoTitulo { get; set; }
            public string dataTerceiroDescontoTitulo { get; set; }
            public double valorTerceiroDescontoTitulo { get; set; }
            public int codigoTerceiroDescontoTitulo { get; set; }
            public string dataMultaTitulo { get; set; }
            public int numeroCarteiraCobranca { get; set; }
            public int numeroVariacaoCarteiraCobranca { get; set; }
            public int quantidadeDiaProtesto { get; set; }
            public int quantidadeDiaPrazoLimiteRecebimento { get; set; }
            public string dataLimiteRecebimentoTitulo { get; set; }
            public string indicadorPermissaoRecebimentoParcial { get; set; }
            public string textoCodigoBarrasTituloCobranca { get; set; }
            public int codigoOcorrenciaCartorio { get; set; }
            public double valorImpostoSobreOprFinanceirasRecebidoTitulo { get; set; }
            public double valorAbatimentoTotal { get; set; }
            public double valorJuroMoraRecebido { get; set; }
            public double valorDescontoUtilizado { get; set; }
            public double valorPagoSacado { get; set; }
            public double valorCreditoCedente { get; set; }
            public int codigoTipoLiquidacao { get; set; }
            public string dataCreditoLiquidacao { get; set; }
            public string dataRecebimentoTitulo { get; set; }
            public int codigoPrefixoDependenciaRecebedor { get; set; }
            public int codigoNaturezaRecebimento { get; set; }
            public string numeroIdentidadeSacadoTituloCobranca { get; set; }
            public string codigoResponsavelAtualizacao { get; set; }
            public int codigoTipoBaixaTitulo { get; set; }
            public double valorMultaRecebido { get; set; }
            public double valorReajuste { get; set; }
            public double valorOutroRecebido { get; set; }
            public int codigoIndicadorEconomicoUtilizadoInadimplencia { get; set; }
        }

        public class BoletosLista
        {
            public string numeroBoletoBB { get; set; }
            public string dataRegistro { get; set; }
            public string dataVencimento { get; set; }
            public double valorOriginal { get; set; }
            public int carteiraConvenio { get; set; }
            public int variacaoCarteiraConvenio { get; set; }
            public int codigoEstadoTituloCobranca { get; set; }
            public string estadoTituloCobranca { get; set; }
            public int contrato { get; set; }
            public string dataMovimento { get; set; }
            public string dataCredito { get; set; }
            public double valorAtual { get; set; }
            public double valorPago { get; set; }
        }

        public class ListaBoletosResponse
        {
            public string indicadorContinuidade { get; set; }
            public int quantidadeRegistros { get; set; }
            public int proximoIndice { get; set; }
            public List<BoletosLista> boletos { get; set; }
        }

        public class TokenDeAcesso
        {
            public TokenDeAcesso() { }

            public TokenDeAcesso(string token)
            {
                access_token = token;
            }

            public string? access_token { get; set; }
            public string? token_type { get; set; }
            public int? expires_in { get; set; }
            public string? scope { get; set; }
        }


        public class RequisicaoRegistroBoletos
        {
            public int numeroConvenio { get; set; }
            public int numeroCarteira { get; set; }
            public int numeroVariacaoCarteira { get; set; }
            public int codigoModalidade { get; set; }
            public string dataEmissao { get; set; }
            public string dataVencimento { get; set; }
            public float valorOriginal { get; set; }
            public int valorAbatimento { get; set; }
            public int quantidadeDiasProtesto { get; set; }
            public int quantidadeDiasNegativacao { get; set; }
            public int orgaoNegativador { get; set; }
            public string indicadorAceiteTituloVencido { get; set; }
            public int numeroDiasLimiteRecebimento { get; set; }
            public string codigoAceite { get; set; }
            public int codigoTipoTitulo { get; set; }
            public string descricaoTipoTitulo { get; set; }
            public string indicadorPermissaoRecebimentoParcial { get; set; }
            public string numeroTituloBeneficiario { get; set; }
            public string campoUtilizacaoBeneficiario { get; set; }
            public string numeroTituloCliente { get; set; }
            public string mensagemBloquetoOcorrencia { get; set; }
            public Desconto desconto { get; set; }
            public SegundoDesconto segundoDesconto { get; set; }
            public TerceiroDesconto terceiroDesconto { get; set; }
            public JurosMora jurosMora { get; set; }
            public Multa multa { get; set; }
            public Pagador pagador { get; set; }
            public BeneficiarioFinal beneficiarioFinal { get; set; }
            public string indicadorPix { get; set; }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Beneficiario
        {
            public int agencia { get; set; }
            public int contaCorrente { get; set; }
            public int tipoEndereco { get; set; }
            public string logradouro { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public int codigoCidade { get; set; }
            public string uf { get; set; }
            public int cep { get; set; }
            public string indicadorComprovacao { get; set; }
        }

        public class GerarPixBoletoResponse
        {
            public Pix pix { get; set; }
            public QrCode qrCode { get; set; }
        }

        public class Pix
        {
            public int valorRecebido { get; set; }
            public string timestamp { get; set; }
            public string chave { get; set; }
            public string textoRetorno { get; set; }
            public int idInstituicaoPagador { get; set; }
            public int agenciaPagador { get; set; }
            public int contaPagador { get; set; }
            public int tipoPessoaPagador { get; set; }
            public int idPagador { get; set; }
        }

        public class QrCode
        {
            public string url { get; set; }
            public string txId { get; set; }
            public string emv { get; set; }
            public int tipo { get; set; }
        }

        public class ConsultaPixResponse
        {
            public string? id { get; set; }
            public string? dataRegistroTituloCobranca { get; set; }
            public string? agenciaBeneficiario { get; set; }
            public string? contaBeneficiario { get; set; }
            public string? valorOriginalTituloCobranca { get; set; }
            public string? validadeTituloCobranca { get; set; }
            public Pix pix { get; set; }
            public QrCode qrCode { get; set; }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Calendario
        {
            public DateTime criacao { get; set; }
            public int expiracao { get; set; }
        }

        public class Devedor
        {
            public string cnpj { get; set; }
            public string nome { get; set; }
        }

        public class DTOREsponsePixAuth
        {
            public string status { get; set; }
            public Calendario calendario { get; set; }
            public string location { get; set; }
            public string txid { get; set; }
            public int revisao { get; set; }
            public Devedor devedor { get; set; }
            public Valor valor { get; set; }
            public string chave { get; set; }
            public string solicitacaoPagador { get; set; }
        }

        public class Valor
        {
            public string original { get; set; }
        }



        public class RegistraBoletoCobrancaReponse
        {
            public string numero { get; set; }
            public int numeroCarteira { get; set; }
            public int numeroVariacaoCarteira { get; set; }
            public int codigoCliente { get; set; }
            public string linhaDigitavel { get; set; }
            public string codigoBarraNumerico { get; set; }
            public int numeroContratoCobranca { get; set; }
            public Beneficiario beneficiario { get; set; }
            public QrCode qrCode { get; set; }
        }

        public class BaixaBoletoResponse
        {
            public string numeroContratoCobranca { get; set; }
            public string dataBaixa { get; set; }
            public string horarioBaixa { get; set; }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class RequisicaoBaixaBoleto
        {
            public int numeroConvenio { get; set; }
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Abatimento
        {
            public int valorAbatimento { get; set; }
        }

        public class AlteracaoAbatimento
        {
            public int novoValorAbatimento { get; set; }
        }

        public class AlteracaoData
        {
            public string novaDataVencimento { get; set; }
        }

        public class AlteracaoDataDesconto
        {
            public string novaDataLimitePrimeiroDesconto { get; set; }
            public string novaDataLimiteSegundoDesconto { get; set; }
            public string novaDataLimiteTerceiroDesconto { get; set; }
        }

        public class AlteracaoDesconto
        {
            public int tipoPrimeiroDesconto { get; set; }
            public int novoValorPrimeiroDesconto { get; set; }
            public int novoPercentualPrimeiroDesconto { get; set; }
            public string novaDataLimitePrimeiroDesconto { get; set; }
            public int tipoSegundoDesconto { get; set; }
            public int novoValorSegundoDesconto { get; set; }
            public int novoPercentualSegundoDesconto { get; set; }
            public string novaDataLimiteSegundoDesconto { get; set; }
            public int tipoTerceiroDesconto { get; set; }
            public int novoValorTerceiroDesconto { get; set; }
            public int novoPercentualTerceiroDesconto { get; set; }
            public string novaDataLimiteTerceiroDesconto { get; set; }
        }

        public class AlteracaoEndereco
        {
            public string enderecoPagador { get; set; }
            public string bairroPagador { get; set; }
            public string cidadePagador { get; set; }
            public string UFPagador { get; set; }
            public int CEPPagador { get; set; }
        }

        public class AlteracaoPrazo
        {
            public int quantidadeDiasAceite { get; set; }
        }

        public class AlteracaoSeuNumero
        {
            public string codigoSeuNumero { get; set; }
        }

        public class DescontoAlteracao
        {
            public int tipoPrimeiroDesconto { get; set; }
            public int valorPrimeiroDesconto { get; set; }
            public int percentualPrimeiroDesconto { get; set; }
            public string dataPrimeiroDesconto { get; set; }
            public int tipoSegundoDesconto { get; set; }
            public int valorSegundoDesconto { get; set; }
            public int percentualSegundoDesconto { get; set; }
            public string dataSegundoDesconto { get; set; }
            public int tipoTerceiroDesconto { get; set; }
            public int valorTerceiroDesconto { get; set; }
            public int percentualTerceiroDesconto { get; set; }
            public string dataTerceiroDesconto { get; set; }
        }

        public class Juros
        {
            public int tipoJuros { get; set; }
            public int valorJuros { get; set; }
            public int taxaJuros { get; set; }
        }

        public class MultaAlteracao
        {
            public int tipoMulta { get; set; }
            public int valorMulta { get; set; }
            public string dataInicioMulta { get; set; }
            public int taxaMulta { get; set; }
        }

        public class Negativacao
        {
            public int quantidadeDiasNegativacao { get; set; }
            public int tipoNegativacao { get; set; }
        }

        public class Protesto
        {
            public int quantidadeDiasProtesto { get; set; }
        }

        public class AlteracaoBoleto
        {
            public int numeroConvenio { get; set; }
            public string indicadorNovaDataVencimento { get; set; }
            public AlteracaoData alteracaoData { get; set; }
            public string indicadorAtribuirDesconto { get; set; }
            public DescontoAlteracao desconto { get; set; }
            public string indicadorAlterarDesconto { get; set; }
            public AlteracaoDesconto alteracaoDesconto { get; set; }
            public string indicadorAlterarDataDesconto { get; set; }
            public AlteracaoDataDesconto alteracaoDataDesconto { get; set; }
            public string indicadorProtestar { get; set; }
            public Protesto protesto { get; set; }
            public string indicadorSustacaoProtesto { get; set; }
            public string indicadorCancelarProtesto { get; set; }
            public string indicadorIncluirAbatimento { get; set; }
            public Abatimento abatimento { get; set; }
            public string indicadorAlterarAbatimento { get; set; }
            public AlteracaoAbatimento alteracaoAbatimento { get; set; }
            public string indicadorCobrarJuros { get; set; }
            public Juros juros { get; set; }
            public string indicadorDispensarJuros { get; set; }
            public string indicadorCobrarMulta { get; set; }
            public MultaAlteracao multa { get; set; }
            public string indicadorDispensarMulta { get; set; }
            public string indicadorNegativar { get; set; }
            public Negativacao negativacao { get; set; }
            public string indicadorAlterarSeuNumero { get; set; }
            public AlteracaoSeuNumero alteracaoSeuNumero { get; set; }
            public string indicadorAlterarEnderecoPagador { get; set; }
            public AlteracaoEndereco alteracaoEndereco { get; set; }
            public string indicadorAlterarPrazoBoletoVencido { get; set; }
            public AlteracaoPrazo alteracaoPrazo { get; set; }
        }


    }
}

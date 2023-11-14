namespace BoletoOnlineAPI.BoletoOnline.BancoBrasil.Exception
{
    public class ErrorResponse
    {
        public class Attributes
        {
            public string error { get; set; }
        }

        public class ErroInterno
        {
            public int statusCode { get; set; }
            public string error { get; set; }
            public string message { get; set; }
            public Attributes attributes { get; set; }
        }

        public class Erro
        {
            public string codigo { get; set; }
            public string versao { get; set; }
            public string mensagem { get; set; }
            public string ocorrencia { get; set; }
        }

        public class ErroIndisponivel
        {
            public List<Erro> erros { get; set; }
        }
    }
}

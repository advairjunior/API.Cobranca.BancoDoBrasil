namespace BoletoOnlineAPI.BoletoOnline.BancoBrasil
{
    public class ErrorResponse
    {
        public class ErroRequisicaoInvalida
        {
            public string codigo { get; set; }
            public string versao { get; set; }
            public string mensagem { get; set; }
            public string ocorrencia { get; set; }
        }

        public class ListaErroRequisicaoInvalida
        {
            public List<ErroRequisicaoInvalida> erros { get; set; }
        }

        public class ErrosNaoAutorizados
        {
            public string error { get; set; }
        }

        public class ErrorNaoAutorizado
        {
            public int statusCode { get; set; }
            public string error { get; set; }
            public string message { get; set; }
            public ErrosNaoAutorizados attributes { get; set; }
        }

        public class ErrorInconsistencia
        {
            public string code { get; set; }
            public string message { get; set; }
        }

        public class ErrosInconsistencia
        {
            public List<ErrorInconsistencia> errors { get; set; }
        }

    }
}
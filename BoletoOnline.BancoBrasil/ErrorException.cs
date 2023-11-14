using static BoletoOnlineAPI.BoletoOnline.BancoBrasil.ErrorResponse;

namespace BoletoOnlineAPI.BoletoOnline.BancoBrasil
{
    [Serializable]

    public class ErrorExceptionRequisicaoInvalida : System.Exception
    {
        public ErrorExceptionRequisicaoInvalida(List<ErroRequisicaoInvalida> response) =>
            throw new ApplicationException(response.FirstOrDefault()?.mensagem);
    }
    
    public class ErrorExceptionNaoAutorizado : System.Exception
    {
        public ErrorExceptionNaoAutorizado(ErrorNaoAutorizado response) =>
            throw new ApplicationException(response.message);
    }
}
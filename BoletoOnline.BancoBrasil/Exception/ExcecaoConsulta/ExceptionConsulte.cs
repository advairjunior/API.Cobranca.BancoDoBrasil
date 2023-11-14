namespace BoletoOnlineAPI.BoletoOnline.BancoBrasil.Exception.ExcecaoConsulta;

[Serializable]
public class ErrorRequisicaoInvalidaException : System.Exception
{
    public ErroRequisicaoInvalida? Response { get; }

    public ErrorRequisicaoInvalidaException(ErroRequisicaoInvalida response) =>
        Response = response;
}

[Serializable]
public class ErrorNaoAutorizadoException : System.Exception
{
    public ErroNaoAutorizado? Response { get; }

    public ErrorNaoAutorizadoException(ErroNaoAutorizado response) =>
        Response = response;
}

public class ErroRequisicaoInvalida
{
    public string? codigoMensagem { get; set; }
    public string? versaoMensagem { get; set; }
    public string? textoMensagem { get; set; }
    public string? codigoRetorno { get; set; }
}

public class ErrosRequisicaoInvalida
{
    public List<ErroRequisicaoInvalida>? erros { get; set; }
}

public class Attributes
{
    public string error { get; set; }
}

public class ErroNaoAutorizado
{
    public int statusCode { get; set; }
    public string error { get; set; }
    public string message { get; set; }
    public Attributes attributes { get; set; }
}





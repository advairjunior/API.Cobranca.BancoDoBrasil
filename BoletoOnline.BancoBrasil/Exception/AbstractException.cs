namespace BoletoOnlineAPI.BoletoOnline.BancoBrasil.Exception;
public abstract class AbstractException : SystemException
{
    public abstract void RequisicaoInvalida();

    public abstract void ErroInterno();
}


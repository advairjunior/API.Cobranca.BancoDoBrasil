using RestSharp;
using RestSharp.Serializers.Json;
using System.Text.Json;
using static BoletoOnlineAPI.BoletoOnline.BancoBrasil.Cobranca.ConsulteBoletoResponse.ConsulteBoletoResponse;
using static BoletoOnlineAPI.BoletoOnline.BancoBrasil.ErrorResponse;

namespace BoletoOnlineAPI.BoletoOnline.BancoBrasil
{
    public class BancoBrasilClient : ClientAbstrato
    {
        protected override async Task<T> ExecuteAsync<T>(RestRequest request)
        {
            RestResponse response = await _client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<T>(response.Content!)!;

                return result;
            }

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new ApplicationException($"Recurso não encontrado: {request.Resource}");
            }

            if (!string.IsNullOrEmpty(response.Content))
            {
                ListaErroRequisicaoInvalida requisicaoInvalida = JsonSerializer.Deserialize<ListaErroRequisicaoInvalida>(response.Content!)!;

                if (requisicaoInvalida.erros?.Count > 0)
                {
                    throw new ErrorExceptionRequisicaoInvalida(requisicaoInvalida.erros);
                }

                ErrorNaoAutorizado erroNaoAutorizado = JsonSerializer.Deserialize<ErrorNaoAutorizado>(response.Content!)!;

                if (!string.IsNullOrEmpty(erroNaoAutorizado?.error))
                {
                    throw new ErrorExceptionNaoAutorizado(erroNaoAutorizado!);
                }

                ErrosInconsistencia errosInconsistencia = JsonSerializer.Deserialize<ErrosInconsistencia>(response.Content!)!;

                if (errosInconsistencia.errors?.Count > 0)
                {
                    throw new ApplicationException(errosInconsistencia.errors.First()?.message); ;
                }
            }

            throw new ApplicationException($"Erro ao acessar o servico: {response.StatusCode}");
        }

        protected override RestClient ObtenhaClient()
        {
            TokenDeAcesso token = ObtenhaTokenDeAcesso();

            var cliente = ObtenhaBasicClient("https://api.hm.bb.com.br/cobrancas/v2")
                .UseSystemTextJson()
                .AddDefaultHeader(KnownHeaders.Authorization, $"Bearer {token.access_token}")
                .AddDefaultHeader(KnownHeaders.Accept, "application/json");

            return cliente;
        }

        private TokenDeAcesso ObtenhaTokenDeAcesso()
        {
            string key = "Basic ZXlKcFpDSTZJakl6TjJFaUxDSmpiMlJwWjI5UWRXSnNhV05oWkc5eUlqb3dMQ0pqYjJScFoyOVRiMlowZDJGeVpTSTZOVE00TkRJc0luTmxjWFZsYm1OcFlXeEpibk4wWVd4aFkyRnZJam94ZlE6ZXlKcFpDSTZJamN4WkRnMk5XTXRNRFl3T0MwMFpqZzVMV0U1WkdZaUxDSmpiMlJwWjI5UWRXSnNhV05oWkc5eUlqb3dMQ0pqYjJScFoyOVRiMlowZDJGeVpTSTZOVE00TkRJc0luTmxjWFZsYm1OcFlXeEpibk4wWVd4aFkyRnZJam94TENKelpYRjFaVzVqYVdGc1EzSmxaR1Z1WTJsaGJDSTZNU3dpWVcxaWFXVnVkR1VpT2lKb2IyMXZiRzluWVdOaGJ5SXNJbWxoZENJNk1UWTNORGMwTkRZMU5qSTROWDA=";
            string idClient = "eyJpZCI6IjIzN2EiLCJjb2RpZ29QdWJsaWNhZG9yIjowLCJjb2RpZ29Tb2Z0d2FyZSI6NTM4NDIsInNlcXVlbmNpYWxJbnN0YWxhY2FvIjoxfQ";
            string idClientSecret = "eyJpZCI6IjcxZDg2NWMtMDYwOC00Zjg5LWE5ZGYiLCJjb2RpZ29QdWJsaWNhZG9yIjowLCJjb2RpZ29Tb2Z0d2FyZSI6NTM4NDIsInNlcXVlbmNpYWxJbnN0YWxhY2FvIjoxLCJzZXF1ZW5jaWFsQ3JlZGVuY2lhbCI6MSwiYW1iaWVudGUiOiJob21vbG9nYWNhbyIsImlhdCI6MTY3NDc0NDY1NjI4NX0";

            var request = new RestRequest("", Method.Post)
                .AddHeader("Authorization", key)
                .AddHeader("cache-control", "no-cache")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddParameter("application/x-www-form-urlencoded", $"grant_type=client_credentials&client_id={idClient}&client_secret={idClientSecret}", ParameterType.RequestBody)
                .AddParameter("scope", "cobrancas.boletos-info&cobrancas.boletos-requisicao", ParameterType.RequestBody);

            RestClient client = ObtenhaBasicClient("https://oauth.hm.bb.com.br/oauth/token");

            RestResponse response = client.Execute(request);
            TokenDeAcesso token = JsonSerializer.Deserialize<TokenDeAcesso>(response.Content!)!;

            return token;
        }

        protected RestClient ObtenhaClientPix()
        {
            TokenDeAcesso token = ObtenhaTokenDeAcessoAuth();

            var cliente = ObtenhaBasicClient("http://api.sandbox.bb.com.br/pix/v1")
                //.AddDefaultHeader("X-Developer-Application-Key", "Basic ZXlKcFpDSTZJakl6TjJFaUxDSmpiMlJwWjI5UWRXSnNhV05oWkc5eUlqb3dMQ0pqYjJScFoyOVRiMlowZDJGeVpTSTZOVE00TkRJc0luTmxjWFZsYm1OcFlXeEpibk4wWVd4aFkyRnZJam94ZlE6ZXlKcFpDSTZJamN4WkRnMk5XTXRNRFl3T0MwMFpqZzVMV0U1WkdZaUxDSmpiMlJwWjI5UWRXSnNhV05oWkc5eUlqb3dMQ0pqYjJScFoyOVRiMlowZDJGeVpTSTZOVE00TkRJc0luTmxjWFZsYm1OcFlXeEpibk4wWVd4aFkyRnZJam94TENKelpYRjFaVzVqYVdGc1EzSmxaR1Z1WTJsaGJDSTZNU3dpWVcxaWFXVnVkR1VpT2lKb2IyMXZiRzluWVdOaGJ5SXNJbWxoZENJNk1UWTNORGMwTkRZMU5qSTROWDA=")
                .AddDefaultHeader(KnownHeaders.Authorization, $"Bearer {token.access_token}")
                .AddDefaultHeader(KnownHeaders.Accept, "application/json");

            return cliente;
        }


        private TokenDeAcesso ObtenhaTokenDeAcessoAuth()
        {
            string key = "Basic ZXlKcFpDSTZJakl6TjJFaUxDSmpiMlJwWjI5UWRXSnNhV05oWkc5eUlqb3dMQ0pqYjJScFoyOVRiMlowZDJGeVpTSTZOVE00TkRJc0luTmxjWFZsYm1OcFlXeEpibk4wWVd4aFkyRnZJam94ZlE6ZXlKcFpDSTZJamN4WkRnMk5XTXRNRFl3T0MwMFpqZzVMV0U1WkdZaUxDSmpiMlJwWjI5UWRXSnNhV05oWkc5eUlqb3dMQ0pqYjJScFoyOVRiMlowZDJGeVpTSTZOVE00TkRJc0luTmxjWFZsYm1OcFlXeEpibk4wWVd4aFkyRnZJam94TENKelpYRjFaVzVqYVdGc1EzSmxaR1Z1WTJsaGJDSTZNU3dpWVcxaWFXVnVkR1VpT2lKb2IyMXZiRzluWVdOaGJ5SXNJbWxoZENJNk1UWTNORGMwTkRZMU5qSTROWDA=";
            string idClient = "eyJpZCI6IjIzN2EiLCJjb2RpZ29QdWJsaWNhZG9yIjowLCJjb2RpZ29Tb2Z0d2FyZSI6NTM4NDIsInNlcXVlbmNpYWxJbnN0YWxhY2FvIjoxfQ";
            string idClientSecret = "eyJpZCI6IjcxZDg2NWMtMDYwOC00Zjg5LWE5ZGYiLCJjb2RpZ29QdWJsaWNhZG9yIjowLCJjb2RpZ29Tb2Z0d2FyZSI6NTM4NDIsInNlcXVlbmNpYWxJbnN0YWxhY2FvIjoxLCJzZXF1ZW5jaWFsQ3JlZGVuY2lhbCI6MSwiYW1iaWVudGUiOiJob21vbG9nYWNhbyIsImlhdCI6MTY3NDc0NDY1NjI4NX0";

            var request = new RestRequest("", Method.Post)
                .AddHeader("Authorization", key)
                .AddHeader("cache-control", "no-cache")
                .AddHeader("content-type", "application/x-www-form-urlencoded")
                .AddParameter("application/x-www-form-urlencoded", $"grant_type=client_credentials&client_id={idClient}&client_secret={idClientSecret}", ParameterType.RequestBody)
                .AddParameter("scope", "cobrancas.boletos-info&cobrancas.boletos-requisicao", ParameterType.RequestBody);

            RestClient client = ObtenhaBasicClient("https://oauth.hm.bb.com.br/oauth/token");

            //RestResponse response = client.Execute(request);
            //TokenDeAcesso token = JsonSerializer.Deserialize<TokenDeAcesso>(response.Content!)!;

            TokenDeAcesso token = new("ODMlu_gzKHkOgQa8FuvrVYiP9B10xtjrL6kkoWBZsc2EVntjl-cUOvo48ySttEiHfvaQoBBaj7zqlLS3usIBLQ.k7zqme0p0i9CWnvssHNGoN_Ly5HATicYTxdqkISkJ0qIVBvJ85oI-HrLZVR4--ODjpBYuWxugPWjYnGnAoj4f_cyRpEjpfjr7YjRNMqpT1fc2v0YVKifaYDeCi9mH5tIV9mdXocLzbME05bpQd4ryJ6WHhcgXuNTCIe1ep2UdMyl8vq7ThNXMIT32X6QP2A-Lj5vaTprMTj539APUeCnBs7ZnLnj17Sg3Ohm4tbRn5zzo6tyUpqvB4hGEo0ncYO02jKAs3VKd7-nCFq8vHUEVW3yWq96jNfrbmzAiBmnaYMFYRpokdy1jmaw2K5yRyiMny8REnMWigBI4XT9vasFoHEfR6w4gU6bXdv3xnmraAarHKzDY9aBhrvAukjrcUEQtXB4US837fubXobPxh1jkiQDy2dk8jGLGr59JwpFgNqPoRWFkZ3X9pfbZ1NtqwnVmQFBAJ5LcuQpIbb5dvBcIZyF6zsZIDgpvu7NHcPPHthqxJTFADCtKnV4A0IZq3elvjR_8kL6y95Fge9faV32m9j6g4Dreu6Ll_fdmIu6-kNaha1mq1lWGGNJcIGlkJYXnO3ZAAoBO0mu-UHvRJlNTM46E0dF4mETexSYC0dZYDK_USXNDEcZFMa6nEhpjD8BNkvcPlylqWI-Cp6LS8FYlHs_sfln48dtvApXgy_Ze61KgBM6C28m5SFxvGXlv8ZH2wi0o3f1zf2BobTxHHJWEs5EfAX-Ujqc7usuFp3OwNhkaVSr2ywrrzU8xMTppMhfyZfsvDBed8v4KoqeAtjySsPXRrYJ60RsMArihVzxrwP5SZNb_Cq6nDeSiERiE0mu3wBJs8NGjXepOnEPEZlkCMcQ7Vs3f2GV7AVBbv7jyZ7wOV73f54RuXKLgO5eyg3aVMD4eYTkCdfhOMD41j7IMGKA7sxW8TPx17P32pwA0g1aAHqSrHQHlDEPVTzuyRwFtbJ0nLx-1ORDguQnMeX-oM_iEVVsEMVOrQFreqxuKOq-cGuItECYNm5oyskSCEfF.d1XDX7vAnFL-IT1ooKtSLlHz3SH043wsaKnUfGyKko0DjzhJNRBN9457jkvB8IFXlsfmcvdLL8TgqD03CIsFnw");

            return token;

            //chaves que serão configuradas em uma tela específica a ser criada.
        }

        public RestClient ObtenhaBasicClient(string basicHttps)
        {
            RestClientOptions optionsAuth = new(basicHttps)
            {
                MaxTimeout = 50000,
                ThrowOnAnyError = false,
                ThrowOnDeserializationError = false,
            };

            return new RestClient(optionsAuth);
        }
    }
}

namespace ConsoleTolyID
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class GerarToken
    {
        public static async Task<string>? Gerar(Usuario user)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:8080/login/token";
                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Envie a requisição POST
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Verifique a resposta
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        //Console.WriteLine(result);
                        var tokenObject = JObject.Parse(result);
                        var sToken = tokenObject["token"]?.ToString();  
                        return sToken!; // Retorne o token
                    }
                    else
                    {
                        Console.WriteLine("Erro: " + response.StatusCode);
                        string error = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Detalhes do erro: " + error);
                        return null!; // Retorne nulo em caso de erro
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao enviar a requisição: " + e.Message);
                    return null!; // Retorne nulo em caso de exceção
                }
            }
        }
    }
}

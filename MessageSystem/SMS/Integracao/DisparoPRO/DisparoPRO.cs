using MessageSystem.SMS.DTO;
using MessageSystem.SMS.Integracao.DisparoPRO.Models;
using MessageSystem.SMS.Interface;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MessageSystem.SMS.Integracao.DisparoPRO
{
    public class DisparoPRO : ISMS
    {
        string url = "https://apihttp.disparopro.com.br:8433/";
        public string EnviaSMS(SMSRequest sms)
        {
            try
            {
                var client = new RestClient($"{url}mt");
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {sms.tokenIntegrator}");
                request.AddParameter("application/json", "[ " +
                    "{ " +
                    $"\"numero\": \"{sms.to}\"," +
                    "\"servico\": \"short\"," +
                    $"\"mensagem\": \"{sms.text}\"," +
                    "\"parceiro_id\": \"\"," +
                    "\"codificacao\": \"0\"" +
                    "}" +
                    "]", ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);


                if (response.StatusCode == HttpStatusCode.OK)
                    return "sucess";
                else
                {
                    responsedp a = JsonConvert.DeserializeObject<responsedp>(response.Content);
                    return $"fail: {a.detail}";

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

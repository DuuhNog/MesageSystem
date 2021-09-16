using MessageSystem.SMS.DTO;
using MessageSystem.SMS.Integracao.Zenvia.Models;
using MessageSystem.SMS.Interface;
using RestSharp;
using System;
using System.Net;
using Newtonsoft.Json;

namespace MessageSystem.SMS.Integracao.Zenvia
{
    public class Zenvia : ISMS
    {
        string url = "https://api.zenvia.com/v2/";

        public string EnviaSMS(SMSRequest sms)
        {
            try
            {
                var requestsms = new request
                {
                    from = sms.from,
                    to = sms.to,
                    contents = new contents
                    {
                        type = "text",
                        text = sms.text
                    }
                };

                var client = new RestClient($"{url}channels/sms/messages");
                var request = new RestRequest(Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("X-API-TOKEN", sms.tokenIntegrator);
                request.AddBody(requestsms);

                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                    return "sucess";
                else
                {
                    response a = JsonConvert.DeserializeObject<response>(response.Content);
                    return "fail: " + a.message ;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using Entiry.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsoleApp.Helper
{
    public class Api
    {
        static async Task<Message> callAapi(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:29041/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    //use JavaScriptSerializer from System.Web.Script.Serialization
                    JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    //deserialize to your class
                   // Message message = JSserializer.Deserialize<Message>(data);
                    return JSserializer.Deserialize<Message>(data);
                    //  Message message = await response.Content.ReadAsStringAsync<Message>();
                    //  Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                }else
                {
                    return null;
                }

            }
        }

        internal async static Task<Message> callApi(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:29041/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    //use JavaScriptSerializer from System.Web.Script.Serialization
                    JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    //deserialize to your class
                    // Message message = JSserializer.Deserialize<Message>(data);
                    return JSserializer.Deserialize<Message>(data);
                    //  Message message = await response.Content.ReadAsStringAsync<Message>();
                    //  Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                }
                else
                {
                    return null;
                }

            }
        }
    }
}

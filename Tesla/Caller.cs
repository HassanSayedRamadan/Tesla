using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Tesla.Models;

namespace Tesla
{
    public class Caller
    {
        public Response<string> PostAuth(string DestinationUrl, string RequestJsonBody)
        {
            try
            {
                HttpWebResponse response;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DestinationUrl);
                byte[] bytes;
                bytes = Encoding.ASCII.GetBytes(RequestJsonBody);
                request.ContentType = "application/json";
                request.ContentLength = bytes.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return Response<string>.Valid(responseStr);
                }
                else
                {
                    return Response<string>.Failed(responseStr);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        public Response<string> NewGETAuth(string DestinationUrl)
        {
            try
            {

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DestinationUrl);


                request.UserAgent = "Mozilla/5.0 (Linux; Android 10; Pixel 3 Build/QQ2A.200305.002; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/85.0.4183.81 Mobile Safari/537.36";
                request.Headers.Add("x-tesla-user-agent", "TeslaApp/3.10.9-433/adff2e065/android/10");
                request.Headers.Add("X-Requested-With", "com.teslamotors.tesla");

                request.Method = "GET";


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return Response<string>.Valid(responseStr);
                }
                else
                {
                    return Response<string>.Failed(responseStr);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        public Response<string> NewPOSTAuth(string DestinationUrl, string RequestBody)
        {
            try
            {
                HttpWebResponse response;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DestinationUrl);

                byte[] bytes;
                bytes = Encoding.ASCII.GetBytes(RequestBody);
                request.ContentType = "application/x-www-form-urlencoded";

                request.UserAgent = "Mozilla/5.0 (Linux; Android 10; Pixel 3 Build/QQ2A.200305.002; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/85.0.4183.81 Mobile Safari/537.36";
                request.Headers.Add("x-tesla-user-agent", "TeslaApp/3.10.9-433/adff2e065/android/10");
                request.Headers.Add("X-Requested-With", "com.teslamotors.tesla");

                request.ContentLength = bytes.Length;
                request.Method = "POST";
                request.AllowAutoRedirect = false;

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();

                if (response.StatusCode == HttpStatusCode.Found)
                {
                    return Response<string>.Valid(responseStr);
                }
                else
                {
                    return Response<string>.Failed(responseStr);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        public Response<string> PostRequest(string DestinationUrl, string RequestJsonBody)
        {
            try
            {
                HttpWebResponse response;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DestinationUrl);
                byte[] bytes;
                bytes = Encoding.ASCII.GetBytes(RequestJsonBody);
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", "Bearer " + ConfigurationManager.AppSettings["access_token"].ToString());
                request.ContentLength = bytes.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return Response<string>.Valid(responseStr);
                }
                else
                {
                    return Response<string>.Failed(responseStr);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }
        public Response<string> GetRequest(string DestinationUrl)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(DestinationUrl);
                request.Method = "GET";
                request.Headers.Add("Authorization", "Bearer " + ConfigurationManager.AppSettings["access_token"].ToString());
                request.ContentType = "application/json";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return Response<string>.Valid(responseStr);
                }
                else
                {
                    return Response<string>.Failed(responseStr);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }
    }
}
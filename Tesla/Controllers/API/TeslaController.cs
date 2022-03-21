using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tesla.Models.API.GET;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Tesla.Models;
using Tesla.Models.API.POST;
using System.Text;

namespace Tesla.Controllers.API
{
    [RoutePrefix("api/Tesla")]
    public class TeslaController : ApiController
    {
        string ResponsePresProcessing(string Response)
        {
            Response = Response.Replace("{\"response\":", "");
            Response = Response.Substring(0, Response.Length - 1);

            return Response;
        }

        [HttpGet, Route("GetVehicles")]
        public Response<ResponseVehicles> GetVehicles()
        {
            try
            {
                var ResponseVehiclesObj = new ResponseVehicles();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString());

                if (Response.State)
                {
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseVehicles>(Response.Result);

                    return Response<ResponseVehicles>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseVehicles>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseVehicles>.Failed(e);
            }

        }

        [HttpGet, Route("GetVehicle/{Id:long}")]
        public Response<ResponseVehicle> GetVehicle(long Id)
        {
            try
            {
                var ResponseVehiclesObj = new ResponseVehicle();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id);

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseVehicle>(Response.Result);

                    return Response<ResponseVehicle>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseVehicle>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseVehicle>.Failed(e);
            }
        }

        [HttpGet, Route("GetVehicleData/{Id:long}")]
        public Response<ResponseVehicleData> GetVehicleData(long Id)
        {
            try
            {
                var ResponseVehiclesObj = new ResponseVehicleData();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/vehicle_data");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseVehicleData>(Response.Result);

                    return Response<ResponseVehicleData>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseVehicleData>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseVehicleData>.Failed(e);
            }
        }

        [HttpGet, Route("GetVehicleServiceData/{Id:long}")]
        public Response<string> GetVehicleServiceData(long Id)
        {
            try
            {
                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/service_data");

                if (Response.State)
                {
                    return Response<string>.Valid("");
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpGet, Route("GetVehicleMobileEnabled/{Id:long}")]
        public Response<bool> GetVehicleMobileEnabled(long Id)
        {
            try
            {
                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/mobile_enabled");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);

                    return Response<bool>.Valid(JsonConvert.DeserializeObject<bool>(Response.Result));
                }
                else
                {
                    return Response<bool>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<bool>.Failed(e);
            }
        }

        [HttpGet, Route("GetVehicleChargeState/{Id:long}")]
        public Response<ResponseChargeState> GetVehicleChargeState(long Id)
        {
            try
            {
                var ResponseVehiclesObj = new ResponseChargeState();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/data_request/charge_state");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseChargeState>(Response.Result);

                    return Response<ResponseChargeState>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseChargeState>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseChargeState>.Failed(e);
            }
        }

        [HttpGet, Route("GetVehicleClimateState/{Id:long}")]
        public Response<ResponseClimateState> GetVehicleClimateState(long Id)
        {
            try
            {
                var ResponseVehiclesObj = new ResponseClimateState();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/data_request/climate_state");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseClimateState>(Response.Result);

                    return Response<ResponseClimateState>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseClimateState>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseClimateState>.Failed(e);
            }
        }

        [HttpGet, Route("GetVehicleDriveState/{Id:long}")]
        public Response<ResponseDriveState> GetVehicleDriveState(long Id)
        {
            try
            {
                var ResponseVehiclesObj = new ResponseDriveState();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/data_request/drive_state");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseDriveState>(Response.Result);

                    return Response<ResponseDriveState>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseDriveState>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseDriveState>.Failed(e);
            }
        }

        [HttpGet, Route("GetVehicleGUISettings/{Id:long}")]
        public Response<ResponseGuiSettings> GetVehicleGUISettings(long Id)
        {
            try
            {
                var ResponseVehiclesObj = new ResponseGuiSettings();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.GetRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/data_request/gui_settings");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseGuiSettings>(Response.Result);

                    return Response<ResponseGuiSettings>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseGuiSettings>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseGuiSettings>.Failed(e);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost, Route("GenerateAccessToken")]
        public Response<ResponseToken> GenerateAccessToken()
        {
            try
            {
                var ResponseTokenObj = new ResponseToken();

                var RequestToken = new RequestToken()
                {
                    client_id = "81527cff06843c8634fdc09e8ac0abefb46ac849f38fe1e431c2ef2106796384",
                    client_secret = "c7257eb71a564034f9419ee651c7d0e5f7aa6bfbd18bafb5c5c033b093bb2fa3",
                    email = "james@affinitycarrentals.com",
                    password = "Affinity123",
                    grant_type = "password"
                };

                string RequestJsonBody = JsonConvert.SerializeObject(RequestToken);

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostAuth("https://owner-api.teslamotors.com/oauth/token", RequestJsonBody);

                if (Response.State)
                {
                    ResponseTokenObj = JsonConvert.DeserializeObject<ResponseToken>(Response.Result);

                    return Response<ResponseToken>.Valid(ResponseTokenObj);
                }
                else
                {
                    return Response<ResponseToken>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseToken>.Failed(e);
            }
        }

        [HttpPost, Route("NewGenerateAccessToken")]
        public Response<string> NewGenerateAccessToken()
        {
            try
            {
                var ResponseTokenObj = new ResponseToken();

                string DestinationURL = "https://auth.tesla.com/oauth2/v3/authorize?audience=&client_id=ownerapi&code_challenge=WymOraPS-PnouwLRcvh6HVJAv2uAwsigM2sVWvwiLSo&code_challenge_method=S256&locale=en&prompt=login&redirect_uri=https://auth.tesla.com/void/callback&response_type=code&scope=openid+email+offline_access&state=ebSlaH-dKRQJA-7kcAtqzQ";

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.NewGETAuth(DestinationURL);

                if (Response.State)
                {
                    var results = Response.Result.Split(new string[] { "_csrf", "transaction_id", "value" }, StringSplitOptions.None);

                    var _csrfValue = results[5].Split(new string[] { "\"" }, StringSplitOptions.None)[1];
                    var transaction_idValue = results[9].Split(new string[] { "\"" }, StringSplitOptions.None)[1];

                    string Body = "_csrf=" + _csrfValue + "&_phase=authenticate&" + "_process=1" + "&transaction_id=" + transaction_idValue + "&cancel=" + "&identity=Juliana@ecosteamwash.com" + "&credential=kina2020";

                    Response<string> POSTResponse = CallerObj.NewPOSTAuth(DestinationURL, Body);

                    return Response<string>.Valid(POSTResponse.ExceptionMessage);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("RefreshAccessToken")]
        public Response<ResponseToken> RefreshAccessToken()
        {
            try
            {
                var ResponseTokenObj = new ResponseToken();

                var RequestToken = new RequestRefreshToken()
                {
                    grant_type = "refresh_token",
                    refresh_token = "qts-5bb482f355e22c90af51b8e1b10d376cf9a294c709b93bd1c562a57346034d99"
                };

                string RequestJsonBody = JsonConvert.SerializeObject(RequestToken);

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostAuth("https://owner-api.teslamotors.com/oauth/token", RequestJsonBody);

                if (Response.State)
                {
                    ResponseTokenObj = JsonConvert.DeserializeObject<ResponseToken>(Response.Result);

                    return Response<ResponseToken>.Valid(ResponseTokenObj);
                }
                else
                {
                    return Response<ResponseToken>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseToken>.Failed(e);
            }
        }


        [HttpPost, Route("POSTWakeUp/{Id:long}")]
        public Response<ResponseVehicle> POSTWakeUp(long Id)
        {
            try
            {
                var ResponseVehiclesObj = new ResponseVehicle();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/wake_up", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseVehiclesObj = JsonConvert.DeserializeObject<ResponseVehicle>(Response.Result);

                    return Response<ResponseVehicle>.Valid(ResponseVehiclesObj);
                }
                else
                {
                    return Response<ResponseVehicle>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<ResponseVehicle>.Failed(e);
            }
        }

        [HttpPost, Route("POSTUnlockDoors/{Id:long}")]
        public Response<string> POSTUnlockDoors(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/door_unlock", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTLockDoors/{Id:long}")]
        public Response<string> POSTLockDoors(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/door_lock", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTHonkHorn/{Id:long}")]
        public Response<string> POSTHonkHorn(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/honk_horn", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTFlashLights/{Id:long}")]
        public Response<string> POSTFlashLights(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/flash_lights", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTStartHVACSystem/{Id:long}")]
        public Response<string> POSTStartHVACSystem(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/auto_conditioning_start", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTStopHVACSystem/{Id:long}")]
        public Response<string> POSTStopHVACSystem(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/auto_conditioning_stop", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSetTemperature/{Id:long}/{DriverTemp:double}/{PassengerTemp:double}")]
        public Response<string> POSTSetTemperature(long Id, double DriverTemp, double PassengerTemp)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/set_temps?driver_temp=" + DriverTemp + "&passenger_temp=" + PassengerTemp, "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSetChargeLimit/{Id:long}/{LimitValue:double}")]
        public Response<string> POSTSetChargeLimit(long Id, double LimitValue)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/set_charge_limit?percent=" + LimitValue, "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSetMaxRangeChargeLimit/{Id:long}")]
        public Response<string> POSTSetMaxRangeChargeLimit(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/charge_max_range", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSetStandardChargeLimit/{Id:long}")]
        public Response<string> POSTSetStandardChargeLimit(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/charge_standard", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTControlSunRoof/{Id:long}/{State}/{Percent:double}")]
        public Response<string> POSTControlSunRoof(long Id, string State, double Percent)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/sun_roof_control?state=" + State + "&percent=" + Percent, "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTActuateTrunk/{Id:long}")]
        public Response<string> POSTActuateTrunk(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/actuate_trunk", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTRemoteStartDrive/{Id:long}")]
        public Response<string> POSTRemoteStartDrive(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/remote_start_drive?password=" + ConfigurationManager.AppSettings["password"].ToString(), "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTOpenChargePort/{Id:long}")]
        public Response<string> POSTOpenChargePort(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/charge_port_door_open", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTCloseChargePort/{Id:long}")]
        public Response<string> POSTCloseChargePort(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/charge_port_door_close", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTStartCharging/{Id:long}")]
        public Response<string> POSTStartCharging(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/charge_start", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTStopCharging/{Id:long}")]
        public Response<string> POSTStopCharging(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/charge_stop", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTUpcomingCalendarEntries/{Id:long}")]
        public Response<string> POSTUpcomingCalendarEntries(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/upcoming_calendar_entries", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSetValetMode/{Id:long}/{On:bool}")]
        public Response<string> POSTSetValetMode(long Id, bool On)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/set_valet_mode?on=" + On + "&password=" + ConfigurationManager.AppSettings["password"].ToString(), "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTResetvaletPIN/{Id:long}")]
        public Response<string> POSTResetvaletPIN(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/reset_valet_pin", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSpeedLimitActivate/{Id:long}")]
        public Response<string> POSTSpeedLimitActivate(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/speed_limit_activate", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSpeedLimitDeactivate/{Id:long}")]
        public Response<string> POSTSpeedLimitDeactivate(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/speed_limit_deactivate", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSpeedLimitSetLimit/{Id:long}")]
        public Response<string> POSTSpeedLimitSetLimit(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/speed_limit_set_limit", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }

        [HttpPost, Route("POSTSpeedLimitClearPIN/{Id:long}")]
        public Response<string> POSTSpeedLimitClearPIN(long Id)
        {
            try
            {
                var ResponseCommandObj = new ResponseCommand();

                var CallerObj = new Caller();
                Response<string> Response = CallerObj.PostRequest(ConfigurationManager.AppSettings["MainRequest"].ToString() + "/" + Id + "/command/speed_limit_clear_pin", "");

                if (Response.State)
                {
                    Response.Result = ResponsePresProcessing(Response.Result);
                    ResponseCommandObj = JsonConvert.DeserializeObject<ResponseCommand>(Response.Result);

                    if (ResponseCommandObj.result)
                        return Response<string>.Valid(ResponseCommandObj.reason);
                    else return Response<string>.Failed(ResponseCommandObj.reason);
                }
                else
                {
                    return Response<string>.Failed(Response.Description, Response.ExceptionMessage);
                }
            }
            catch (Exception e)
            {
                return Response<string>.Failed(e);
            }
        }
    }
}

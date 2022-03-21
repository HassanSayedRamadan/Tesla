using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.GET
{
    public class ResponseVehicleData
    {
        public long? id { get; set; }
        public long? user_id { get; set; }
        public int? vehicle_id { get; set; }
        public string vin { get; set; }
        public string display_name { get; set; }
        public string option_codes { get; set; }
        public string color { get; set; }
        public string access_type { get; set; }
        public List<string> tokens { get; set; }
        public string state { get; set; }
        public bool? in_service { get; set; }
        public string id_s { get; set; }
        public bool? calendar_enabled { get; set; }
        public int? api_version { get; set; }
        public string backseat_token { get; set; }
        public string backseat_token_updated_at { get; set; }
        public ResponseVehicleConfig vehicle_config { get; set; }
        public ResponseChargeState charge_state { get; set; }
        public ResponseClimateState climate_state { get; set; }
        public ResponseDriveState drive_state { get; set; }
        public ResponseGuiSettings gui_settings { get; set; }
        public ResponseVehicleState vehicle_state { get; set; }
    }
}
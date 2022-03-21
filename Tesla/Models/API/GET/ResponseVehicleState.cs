using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesla.Models.API.GET
{
    public class ResponseVehicleState
    {
        public int? api_version { get; set; }
        public string autopark_state_v2 { get; set; }
        public string autopark_style { get; set; }
        public bool? calendar_supported { get; set; }
        public string car_version { get; set; }
        public int? center_display_state { get; set; }
        public int? df { get; set; }
        public int? dr { get; set; }
        public int? fd_window { get; set; }
        public int? fp_window { get; set; }
        public int? ft { get; set; }
        public int? homelink_device_count { get; set; }
        public bool? homelink_nearby { get; set; }
        public bool? is_user_present { get; set; }
        public string last_autopark_error { get; set; }
        public bool? locked { get; set; }
        public MediaState media_state { get; set; }
        public bool? notifications_supported { get; set; }
        public double? odometer { get; set; }
        public bool? parsed_calendar_supported { get; set; }
        public int? pf { get; set; }
        public int? pr { get; set; }
        public int? rd_window { get; set; }
        public bool? remote_start { get; set; }
        public bool? remote_start_enabled { get; set; }
        public bool? remote_start_supported { get; set; }
        public int? rp_window { get; set; }
        public int? rt { get; set; }
        public bool? sentry_mode { get; set; }
        public bool? sentry_mode_available { get; set; }
        public bool? smart_summon_available { get; set; }
        public SoftwareUpdate software_update { get; set; }
        public SpeedLimitMode speed_limit_mode { get; set; }
        public bool? summon_standby_mode_enabled { get; set; }
        public long? timestamp { get; set; }
        public bool? valet_mode { get; set; }
        public string vehicle_name { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.mirle.ibg3k0.sc
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASECTION_CONTROL_100
    {
        public string SEC_ID { get; set; }
        public com.mirle.ibg3k0.sc.ProtocolFormat.OHTMessage.E_AreaSensorDir CHG_AREA_SECSOR_1 { get; set; }
        public com.mirle.ibg3k0.sc.ProtocolFormat.OHTMessage.E_AreaSensorDir CHG_AREA_SECSOR_2 { get; set; }
        public int OBS_SENSOR_F { get; set; }
        public int OBS_SENSOR_R { get; set; }
        public int OBS_SENSOR_L { get; set; }
        public int RANGE_SENSOR_F { get; set; }
        public bool IS_ADR_RPT { get; set; }
        public bool CAN_GUIDE_CHG { get; set; }
        public bool HID_CONTROL { get; set; }
        public bool BRANCH_FLAG { get; set; }
        public string SUB_VER { get; set; }
        public Nullable<System.DateTime> ADD_TIME { get; set; }
        public string ADD_USER { get; set; }
        public Nullable<System.DateTime> UPD_TIME { get; set; }
        public string UPD_USER { get; set; }
    }
}

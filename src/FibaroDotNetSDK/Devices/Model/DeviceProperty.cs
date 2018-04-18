using System.Collections.Generic;
using Newtonsoft.Json;

namespace FibaroDotNetSDK.Devices.Model
{
    public partial class DeviceProperty
    {
        [JsonProperty("parameters")]
        public List<DeviceParameter> Parameters { get; set; }

        [JsonProperty("pollingTimeSec")]
        public long PollingTimeSec { get; set; }

        [JsonProperty("wakeUpTime")]
        public long WakeUpTime { get; set; }

        [JsonProperty("zwaveCompany")]
        public string ZwaveCompany { get; set; }

        [JsonProperty("zwaveInfo")]
        public string ZwaveInfo { get; set; }

        [JsonProperty("zwaveVersion")]
        public string ZwaveVersion { get; set; }

        [JsonProperty("alarmDelay")]
        public string AlarmDelay { get; set; }

        [JsonProperty("alarmExclude")]
        public string AlarmExclude { get; set; }

        [JsonProperty("alarmLevel")]
        public string AlarmLevel { get; set; }

        [JsonProperty("alarmTimeTimestamp")]
        public string AlarmTimeTimestamp { get; set; }

        [JsonProperty("alarmType")]
        public string AlarmType { get; set; }

        [JsonProperty("armConditions")]
        public string ArmConditions { get; set; }

        [JsonProperty("armConfig")]
        public string ArmConfig { get; set; }

        [JsonProperty("armDelay")]
        public string ArmDelay { get; set; }

        [JsonProperty("armError")]
        public string ArmError { get; set; }

        [JsonProperty("armTimeTimestamp")]
        public string ArmTimeTimestamp { get; set; }

        [JsonProperty("armed")]
        public string Armed { get; set; }

        [JsonProperty("batteryLevel")]
        public string BatteryLevel { get; set; }

        [JsonProperty("batteryLowNotification")]
        public string BatteryLowNotification { get; set; }

        [JsonProperty("configured")]
        public bool Configured { get; set; }

        [JsonProperty("dead")]
        public string Dead { get; set; }

        [JsonProperty("defInterval")]
        public string DefInterval { get; set; }

        [JsonProperty("deviceControlType")]
        public string DeviceControlType { get; set; }

        [JsonProperty("deviceIcon")]
        public string DeviceIcon { get; set; }

        [JsonProperty("emailNotificationID")]
        public string EmailNotificationId { get; set; }

        [JsonProperty("emailNotificationType")]
        public string EmailNotificationType { get; set; }

        [JsonProperty("endPointId")]
        public string EndPointId { get; set; }

        [JsonProperty("fibaroAlarm")]
        public string FibaroAlarm { get; set; }

        [JsonProperty("firmwareUpdate")]
        public string FirmwareUpdate { get; set; }

        [JsonProperty("lastBreached")]
        public string LastBreached { get; set; }

        [JsonProperty("liliOffCommand")]
        public string LiliOffCommand { get; set; }

        [JsonProperty("liliOnCommand")]
        public string LiliOnCommand { get; set; }

        [JsonProperty("log")]
        public string Log { get; set; }

        [JsonProperty("logTemp")]
        public string LogTemp { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("markAsDead")]
        public string MarkAsDead { get; set; }

        [JsonProperty("maxInterval")]
        public string MaxInterval { get; set; }

        [JsonProperty("minInterval")]
        public string MinInterval { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("parametersTemplate")]
        public string ParametersTemplate { get; set; }

        [JsonProperty("productInfo")]
        public string ProductInfo { get; set; }

        [JsonProperty("pushNotificationID")]
        public string PushNotificationId { get; set; }

        [JsonProperty("pushNotificationType")]
        public string PushNotificationType { get; set; }

        [JsonProperty("remoteGatewayId")]
        public string RemoteGatewayId { get; set; }

        [JsonProperty("saveLogs")]
        public string SaveLogs { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("smsNotificationID")]
        public string SmsNotificationId { get; set; }

        [JsonProperty("smsNotificationType")]
        public string SmsNotificationType { get; set; }

        [JsonProperty("stepInterval")]
        public string StepInterval { get; set; }

        [JsonProperty("tamper")]
        public string Tamper { get; set; }

        [JsonProperty("updateVersion")]
        public string UpdateVersion { get; set; }

        [JsonProperty("useTemplate")]
        public string UseTemplate { get; set; }

        [JsonProperty("userDescription")]
        public string UserDescription { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
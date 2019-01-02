namespace FibaroDotNetSDK.Devices.Model
{
    public static class ActionFactory
    {
        public static DeviceAction SetValue(double value) => new DeviceAction("setValue", value);
        public static DeviceAction TurnOn() => new DeviceAction("turnOn");
        public static DeviceAction TurnOff() => new DeviceAction("turnOff");

        public static DeviceAction SetTargetLevel(double value) => new DeviceAction("setTargetLevel", value);
    }
}
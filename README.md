# FibaroDotNET
.NET SDK for Fibaro Home Center (still in development, but feel free to use it...)

# Usage
``` csharp
var settings = new HubSettings()
{
	Address = "http://xxx.xxx.xxx.xxx/api",
	Username = "xxxx",
	Password = "xxx"
};
var client = new FibaroClient(settings);

var deviceGw = new DeviceGateway(client);
var devices = await deviceGw.GetDevices();

var roomGw = new RoomGateway(client);
var room = await roomGw.GetRooms();

var sceneGw = new SceneGateway(client);
var scenes = await sceneGw.GetScenes();

var weatherGw = new WeatherGateway(client);
var weather = await weatherGw.GetWeather();
```
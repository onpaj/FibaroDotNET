using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FibaroDotNetSDK.Devices;
using FibaroDotNetSDK.Infrastructure;
using FibaroDotNetSDK.Rooms;
using FibaroDotNetSDK.Scenes;
using FibaroDotNetSDK.Weather;
using Xunit;

namespace FibaroDotNet.Tests
{
    public class HomeCenterTests
    {
        [Fact]
        public async Task GetDevices()
        {
            var settings = TestHelper.GetSettings();


            var client = new FibaroClient(settings);

            var gw = new DeviceGateway(client);
            var entities = await gw.GetDevices();

            Assert.NotEmpty(entities);
        }

        [Fact]
        public async Task GetDeviceById()
        {
            var settings = TestHelper.GetSettings();


            var client = new FibaroClient(settings);

            var gw = new DeviceGateway(client);
            var entities = await gw.GetDeviceById(1);

            Assert.NotNull(entities);
        }

        [Fact]
        public async Task GetRooms()
        {
            var settings = TestHelper.GetSettings();


            var client = new FibaroClient(settings);

            var gw = new RoomGateway(client);
            var entities = await gw.GetRooms();

            Assert.NotEmpty(entities);
        }

        [Fact]
        public async Task GetScenes()
        {
            var settings = TestHelper.GetSettings();


            var client = new FibaroClient(settings);

            var gw = new SceneGateway(client);
            var entities = await gw.GetScenes();

            Assert.NotEmpty(entities);
        }

        [Fact]
        public async Task GetWeather()
        {
            var settings = TestHelper.GetSettings();


            var client = new FibaroClient(settings);

            var gw = new WeatherGateway(client);
            var entities = await gw.GetWeather();

            Assert.NotNull(entities);
        }
    }
}

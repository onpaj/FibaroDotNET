using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using FibaroDotNetSDK.Infrastructure;
using FibaroDotNetSDK.Scenes.Model;

namespace FibaroDotNetSDK.Scenes
{
    public class SceneGateway : ISceneGateway
    {
        private readonly HomeCenterFibaroClient _client;

        public SceneGateway(HomeCenterFibaroClient client)
        {
            _client = client;
        }


        public Task<ICollection<Scene>> GetScenes()
        {
            var request = new GetScenesRequest();

            return _client.SendRequest<ICollection<Scene>>(request);
        }

        public Task<bool> RunScene(Scene scene)
        {
            throw new NotImplementedException();
        }

        public Task<bool> StopScene(Scene scene)
        {
            throw new NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using FibaroDotNetSDK.Scenes.Model;

namespace FibaroDotNetSDK.Scenes
{
    public interface ISceneGateway
    {
        Task<ICollection<Scene>> GetScenes();

        Task<bool> RunScene(Scene scene);

        Task<bool> StopScene(Scene scene);
    }
}
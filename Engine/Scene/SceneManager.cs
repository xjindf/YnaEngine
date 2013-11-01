using System.Collections.Generic;

namespace Yna.Engine.Scene
{
    /// <summary>
    /// The scene manager is responsible to play and switch all scenes of the game.
    /// </summary>
    public class SceneManager
    {
        protected List<Scene> _scenes;
        private Scene _nextScene;
        protected Scene _currentScene;
        protected GameTimeService _gameTimeService;

        public SceneManager()
        {
            _scenes = new List<Scene>();
            _nextScene = null;
            _currentScene = null;
            _gameTimeService = new GameTimeService();
        }

        internal void Initialize()
        {
            if (_currentScene != null)
                _currentScene.Initialize();
        }

        public void Add(Scene scene)
        {
            if (_scenes.IndexOf(scene) == -1)
                _scenes.Add(scene);
        }

        public void AddRange(Scene[] scenes)
        {
            foreach (Scene scene in scenes)
                Add(scene);
        }

        public void Execute()
        {
            _gameTimeService.Update();

            if (_nextScene != null)
            {
                //_currentScene.Exit();
                _currentScene = _nextScene;
                _currentScene.Initialize();
                _nextScene = null;
            }

            if (_currentScene != null)
            {
                _currentScene.Update();
                _currentScene.Draw();
            }
        }

        public void LoadScene(string name)
        {
            int index = -1;
            int i = 0;
            int count = _scenes.Count;

            while (i < count && index == -1)
            {
                index = (_scenes[i].Name == name) ? i : index;
                i++;
            }

            LoadScene(index);
        }

        public void LoadScene(int levelId)
        {
            if (levelId >= 0 && levelId < _scenes.Count)
                _nextScene = _scenes[levelId];
        }
    }
}

using System.Collections.Generic;

namespace Yna.Engine.Scene
{
    /// <summary>
    /// The scene manager is responsible to play and switch all scenes of the game.
    /// </summary>
    public class SceneManager
    {
        protected List<Scene> _levels;
        private Scene _nextScene;
        protected Scene _currentScene;
        protected GameTimeService _gameTimeService;

        public SceneManager()
        {
            _levels = new List<Scene>();
            _nextScene = null;
            _currentScene = null;
            _gameTimeService = new GameTimeService();
        }

        public void Start()
        {
            _currentScene.Initialize();
        }

        public void Execute()
        {
            if (_nextScene != null)
            {
                //_currentLevel.Exit();
                _currentScene = _nextScene;
                _nextScene = null;
                Start();
            }

            _gameTimeService.Update();
            _currentScene.Update();
            _currentScene.Draw();
        }

        public void LoadScene(string name)
        {
            int index = -1;
            int i = 0;
            int count = _levels.Count;

            while (i < count && index == -1)
            {
                index = (_levels[i].Name == name) ? i : index;
                i++;
            }

            LoadScene(index);
        }

        public void LoadScene(int levelId)
        {
            if (levelId >= 0 && levelId < _levels.Count)
                _nextScene = _levels[levelId];
        }
    }
}

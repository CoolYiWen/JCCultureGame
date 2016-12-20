using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : SingletonUnity<GameManager>
{
    private string[] scenes;

    public int currentScene = 1;
    public string DirScene;

    public bool IsGameRunning = true;
    public int BuildingId = 0;
    public bool[] BuildingStates = new bool[]{
        false, false, false, false,
        false, false, false, false,
        false, false, false, false};

    void Start()
    {
        scenes = Constant.Scenes;
        DontDestroyOnLoad (this.gameObject);

        Init ();
    }

    public void Init()
    {
        currentScene = DataManager.Instance.ReadCurrentScene ();
        BuildingStates = DataManager.Instance.ReadBuildingStates ();
    }

    public void loadScene(SceneType scene)
    {
        DirScene = scenes [(int)scene];
        SceneManager.LoadScene (Constant.Scenes[(int)SceneType.LoadingScene]);
    }

    public void RestartScene()
    {
        loadScene ((SceneType)currentScene);
    }



}

public enum SceneType
{
    SplashScene,
    Scene1,
    Scene2,
    Scene3,
    LoadingScene
}


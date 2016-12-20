using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingView : MonoBehaviour {

    private bool IsMusicOpen = true;

    public Image MusicState;

    void Start()
    {
        IsMusicOpen = DataManager.Instance.ReadMusicState ();  
        SetMusicState (IsMusicOpen);
    }

    private void SetMusicState(bool isMusicOpen)
    {
        if(IsMusicOpen)
        {
            MusicState.sprite = Resources.Load<Sprite> ("UI/Setting/open");
            MusicManager.Instance.musicVolume = 1f;
        }
        else
        {
            MusicState.sprite = Resources.Load<Sprite> ("UI/Setting/close");
            MusicManager.Instance.musicVolume = 0f;
        }
    }

    public void OnMusicChangedClick()
    {
        IsMusicOpen = !IsMusicOpen;
        SetMusicState (IsMusicOpen);
    }

    public void OnRestartGameClick()
    {
        DataManager.Instance.SetNewData ();
        GameManager.Instance.Init ();
        GameManager.Instance.loadScene ((SceneType)GameManager.Instance.currentScene);
    }

    public void OnQuitGameClick()
    {
        Application.Quit ();
    }

    public void OnBackClick()
    {
        UIManager.Instance.InitUIPanel ();
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{

    public void OnAchievementButtonClick()
    {
        UIManager.Instance.ShowAchievementPanel ();
    }

    public void OnSettingButtonClick()
    {
        UIManager.Instance.ShowSettingPanel ();
    }


}


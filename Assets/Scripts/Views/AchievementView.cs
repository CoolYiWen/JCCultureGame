using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AchievementView : MonoBehaviour {

    public GameObject AllView;
    public GameObject ContentView;
    public Image ContentImage;

    void OnEnable()
    {
        InitAchievementView ();
    }

    public void InitAchievementView()
    {
        for(int i = 0; i < 12; i++)
        {
            if(GameManager.Instance.BuildingStates[i])
            {
                GameObject Lock = GameObject.Find ("lock" + (i + 1));
                if(Lock)
                {
                    Lock.SetActive (false);
                }
            }
        }
    }

	public void OnBuildingContentClick(int buildingId)
    {
        if(GameManager.Instance.BuildingStates[buildingId - 1])
        {
            ContentImage.sprite = Resources.Load<Sprite> ("UI/Achievement/" + Constant.BuildingNames[buildingId - 1] + "02");
            AllView.SetActive (false);
            ContentView.SetActive (true);
        }

    }

    public void OnAllreadyReadContentClick()
    {
        AllView.SetActive (true);
        ContentView.SetActive (false);
    }

    public void OnCloseAchievementViewClick()
    {
        UIManager.Instance.InitUIPanel ();
    }

}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuildingView : MonoBehaviour
{
    public Image ContentImage;

    void OnEnable()
    {
        int id = GameManager.Instance.currentScene * 4 - 4 + GameManager.Instance.BuildingId - 1;
        ContentImage.sprite = Resources.Load<Sprite> ("UI/Achievement/" + Constant.BuildingNames[id] + "02");
    }

}


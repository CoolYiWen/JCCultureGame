using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    public SceneType GotoSceneType = SceneType.Scene3;
    public bool IsLimit = true;
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            if(IsLimit)
            {
                if(IsCanGo())
                {
                    GameManager.Instance.loadScene (GotoSceneType);
                    GameManager.Instance.currentScene = (int)GotoSceneType;
                    DataManager.Instance.SetCurrentScene ((int)GotoSceneType);
                }
            }
            else
            {
                GameManager.Instance.loadScene (GotoSceneType);
                GameManager.Instance.currentScene = (int)GotoSceneType;
                DataManager.Instance.SetCurrentScene ((int)GotoSceneType);
            }
        }
    }

    private bool IsCanGo()
    {
        bool result = true;
        bool[] buildingStates = GameManager.Instance.BuildingStates;
        int id = (GameManager.Instance.currentScene - 1) * 4;
        int max = id + 4;
        for(int i = id; i < max; i++)
        {
            if(! buildingStates[i])
            {
                result = false;
            }
        }

        return result;
    }

}

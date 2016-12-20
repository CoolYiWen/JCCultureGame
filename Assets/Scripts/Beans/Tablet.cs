using UnityEngine;
using System.Collections;

public class Tablet : MonoBehaviour {

	public int CryCostNumber = 0;
    public int BuildingId = 1;
    public GameObject BuildingFlog;

    void Start()
    {
        if(GameManager.Instance.BuildingStates[GameManager.Instance.currentScene * 4 - 4 + BuildingId - 1])
        {
            BuildingFlog.SetActive (false);
        }
        else
        {
            BuildingFlog.SetActive (true);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            if(ETCInput.GetButton(Constant.Button_Click))
            {
                if(BlackBoardHelper.GetCrysNumber() >= CryCostNumber)
                {
                    BlackBoardHelper.ChangeCrysNumber (-CryCostNumber);
                    BuildingFlog.SetActive (false);
                    GameManager.Instance.BuildingStates [GameManager.Instance.currentScene * 4 - 4 + BuildingId - 1] = true;
                    GameManager.Instance.BuildingId = BuildingId;

                    DataManager.Instance.SetBuildingStates (GameManager.Instance.BuildingStates);

                    UIManager.Instance.ShowBuildingPanel ();
                }
            }
        }
    }
}

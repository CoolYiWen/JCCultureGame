using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIManager : SingletonUnity<UIManager> {

	private GameObject rootView;
	
    [HideInInspector]public GameObject CurrentView;

    [HideInInspector]public GameObject GamePanel;
    [HideInInspector]public GameObject StartPanel;
    [HideInInspector]public GameObject TouchPanel;
    [HideInInspector]public GameObject AchievementPanel;
    [HideInInspector]public GameObject BuildingPanel;
    [HideInInspector]public GameObject MapPanel;
    [HideInInspector]public GameObject SettingPanel;

	void Awake()
	{
		//Screen.SetResolution (1024, 768, false);
	}

	void Start()
	{
		rootView = GameObject.Find ("UI");
        GamePanel = rootView.transform.Find (Constant.UI_Game).gameObject;
        StartPanel = rootView.transform.Find (Constant.UI_Start).gameObject;
        TouchPanel = rootView.transform.Find (Constant.UI_Touch).gameObject;
        AchievementPanel = rootView.transform.Find (Constant.UI_Achievement).gameObject;
        BuildingPanel = rootView.transform.Find (Constant.UI_Building).gameObject;
        MapPanel = rootView.transform.Find (Constant.UI_Map).gameObject;
        SettingPanel = rootView.transform.Find (Constant.UI_Setting).gameObject;

        InitUIPanel ();
        InitStart ();
	}

    public void InitStart()
    {
        /*bool[] buildingStates = GameManager.Instance.BuildingStates;
        int id = GameManager.Instance.currentScene * 4 - 4;
        if(buildingStates[id] || buildingStates[id + 1] || buildingStates[id + 2] || buildingStates[id + 3])
        {
            return;
        }*/

        GameManager.Instance.IsGameRunning = false;
        StartPanel.SetActive (true);
        GamePanel.SetActive (false);
        TouchPanel.SetActive (false);
        AchievementPanel.SetActive (false);
        BuildingPanel.SetActive (false);
        MapPanel.SetActive (false);
        SettingPanel.SetActive (false);
    }

    public void InitUIPanel()
    {
        GamePanel.SetActive (true);
        StartPanel.SetActive (false);
        TouchPanel.SetActive (true);
        AchievementPanel.SetActive (false);
        BuildingPanel.SetActive (false);
        MapPanel.SetActive (false);
        SettingPanel.SetActive (false);
        GameManager.Instance.IsGameRunning = true;
    }

	public void ShowAchievementPanel()
	{
        GameManager.Instance.IsGameRunning = false;
        GamePanel.SetActive (false);
        TouchPanel.SetActive (false);
        AchievementPanel.SetActive (true);
	}

    public void ShowSettingPanel()
    {
        GameManager.Instance.IsGameRunning = false;
        GamePanel.SetActive (false);
        TouchPanel.SetActive (false);
        SettingPanel.SetActive (true);
    }

    public void ShowMapPanel()
    {
        GameManager.Instance.IsGameRunning = false;
        GamePanel.SetActive (false);
        TouchPanel.SetActive (false);
        MapPanel.SetActive (true);
    }

    public void ShowBuildingPanel()
    {
        GameManager.Instance.IsGameRunning = false;
        GamePanel.SetActive (false);
        TouchPanel.SetActive (false);
        BuildingPanel.SetActive (true);
    }


}

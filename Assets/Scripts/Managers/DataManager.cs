using UnityEngine;
using System.Collections;

public class DataManager : SingletonUnity<DataManager>
{

    void Start()
    {
        if(! PlayerPrefs.HasKey("CurrentScene"))
        {
            SetNewData ();
        }
    }

    public void SetNewData()
    {
        PlayerPrefs.SetInt ("CurrentScene", 1);
        PlayerPrefs.SetInt ("1", 0);
        PlayerPrefs.SetInt ("2", 0);
        PlayerPrefs.SetInt ("3", 0);
        PlayerPrefs.SetInt ("4", 0);
        PlayerPrefs.SetInt ("5", 0);
        PlayerPrefs.SetInt ("6", 0);
        PlayerPrefs.SetInt ("7", 0);
        PlayerPrefs.SetInt ("8", 0);
        PlayerPrefs.SetInt ("9", 0);
        PlayerPrefs.SetInt ("10", 0);
        PlayerPrefs.SetInt ("11", 0);
        PlayerPrefs.SetInt ("12", 0);
        PlayerPrefs.SetInt ("MusicState", 1);
    }

    public void SetBuildingStates(bool[] buildingStates)
    {
        for(int i = 0; i < 12; i++)
        {
            if(buildingStates[i])
            {
                PlayerPrefs.SetInt ((i + 1).ToString(), 1);
            }
            else
            {
                PlayerPrefs.SetInt ((i + 1).ToString(), 0);
            }
        }
    }

    public void SetCurrentScene(int sceneId)
    {
        PlayerPrefs.SetInt ("CurrentScene", sceneId);
    }

    public void SetMusicState(bool isMusicOpen)
    {
        if(isMusicOpen)
        {
            PlayerPrefs.SetInt ("MusicState", 1);
        }
        else
        {
            PlayerPrefs.SetInt ("MusicState", 0);
        }

    }

    public int ReadCurrentScene()
    {
        return PlayerPrefs.GetInt ("CurrentScene", 0);
    }

    public bool[] ReadBuildingStates()
    {
        bool[] buildingStates = new bool[]{
            false, false, false, false,
            false, false, false, false,
            false, false, false, false};
        for(int i = 0; i < 12; i++)
        {
            if(PlayerPrefs.GetInt((i + 1).ToString(), 0) == 1)
            {
                buildingStates [i] = true;
            }
        }
        return buildingStates;
    }

    public bool ReadMusicState()
    {
        if(PlayerPrefs.GetInt("MusicState", 0) == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    /*private string fileName = "DataFile";
    private SaveData data;

    void Start ()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            data = SaveData.Load("jar:file://" + Application.dataPath + "!/assets/"+"\\"+fileName+".uml");
        }
        else
        {
            data = SaveData.Load(Application.dataPath + "/StreamingAssets"+"\\"+fileName+".uml");
        }


        if(data == null)
        {
            SetNewData ();
        }
    }

    public void SetNewData()
    {
        data = new SaveData(fileName);
        data ["CurrentScene"] = 1;
        data ["BuildingId"] = 0;
        data ["BuildingStates"] = new bool[]{
            false, false, false, false,
            false, false, false, false,
            false, false, false, false};
        data ["MusicState"] = true;
        data.Save ();
    }

    public void SetBuildingId(int buildingId)
    {
        data ["BuildingId"] = buildingId;
        data.Save ();
    }

    public void SetSaveBuildingStates(bool[] buildingStates)
    {
        data ["BuildingStates"] = buildingStates;
        data.Save ();
    }

    public void SetCurrentScene(int sceneId)
    {
        data ["CurrentScene"] = sceneId;
        data.Save ();
    }

    public void SetMusicState(bool isMusicOpen)
    {
        data ["MusicState"] = isMusicOpen;
        data.Save ();
    }

    public int ReadCurrentScene()
    {
        return data.GetValue<int> ("CurrentScene");
    }

    public int ReadSaveBuilding()
    {
        return data.GetValue<int> ("BuildingId");
    }

    public bool[] ReadBuildingStates()
    {
        return data.GetValue<bool[]> ("BuildingStates");
    }

    public bool ReadMusicState()
    {
        return data.GetValue<bool> ("MusicState");
    }*/

}


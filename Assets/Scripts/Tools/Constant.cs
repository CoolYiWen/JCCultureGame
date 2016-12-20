using System.Collections;

public class Constant
{
    static public string BB_CrysNumber = "CrysNumber";

    static public string Name_Player = "Player";

    static public string Tag_Ground = "Ground";

    static public string Par_State = "state";

    static public string Axis_Horizontal = "Horizontal";
    static public string Axis_Vertical = "Vertical";
    static public string Button_Jump = "Jump";
    static public string Button_Click = "Click";

    static public string UI_Achievement = "AchievementPanel";
    static public string UI_Building = "BuildingPanel";
    static public string UI_Map = "MapPanel";
    static public string UI_Setting = "SettingPanel";
    static public string UI_Game = "GamePanel";
    static public string UI_Start = "StartPanel";
    static public string UI_Touch = "TouchPanel";

    //建筑配置表
    public static string[] BuildingNames = new string[] {
        "hygys", "hmszs", "eswcc", "xtyqs",
        "xfdbft", "jzwsbt", "whhsbt", "xefyq",
        "whhhl", "wdsxl", "szxl", "xsxl"};
    
    //场景配置表
    public static string[] Scenes = new string[]{"Splash", "Scene1", "Scene2", "Scene3", "Loading"};
}


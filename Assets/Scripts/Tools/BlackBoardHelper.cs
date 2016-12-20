using UnityEngine;
using System.Collections;

public class BlackBoardHelper : MonoBehaviour
{

    static public int GetCrysNumber()
    {
        return BlackBoard.Instance.GetValue<int> (Constant.BB_CrysNumber, 0);
    }

    static public void ChangeCrysNumber(int deltaNumber)
    {
        BlackBoard.Instance.SetValue (Constant.BB_CrysNumber, BlackBoard.Instance.GetValue<int> (Constant.BB_CrysNumber, 0) + deltaNumber);
    }

}


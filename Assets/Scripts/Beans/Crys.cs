using UnityEngine;
using System.Collections;

public class Crys : MonoBehaviour {


    private int m_CrysNumber = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == Constant.Name_Player)
        {
            this.gameObject.SetActive (false);
            BlackBoardHelper.ChangeCrysNumber (m_CrysNumber);


        }

    }

}

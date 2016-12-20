using UnityEngine;
using System.Collections;

public class S3_6_2 : MonoBehaviour
{

    public GameObject Ship;
    public S3_6 S1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            if(S1.i < 2)
            {
                Ship.SetActive (false);
            }
        }
    }
}


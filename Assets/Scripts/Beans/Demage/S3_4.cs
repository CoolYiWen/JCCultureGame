using UnityEngine;
using System.Collections;

public class S3_4 : MonoBehaviour
{

    public GameObject Stone;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            Stone.SetActive (true);
        }
    }
}


using UnityEngine;
using System.Collections;

public class S3_3 : MonoBehaviour
{

    public GameObject Stone;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            Stone.GetComponent<Stone> ().StartUpMove ();
        }
    }
}


using UnityEngine;
using System.Collections;

public class S3_5 : MonoBehaviour {

    public GameObject Ship;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            Ship.SetActive (true);
        }
    }
}

using UnityEngine;
using System.Collections;

public class S3_6 : MonoBehaviour
{

    public GameObject Ship;

    public int i = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            i++;
            Ship.SetActive (true);
        }
    }
        
}


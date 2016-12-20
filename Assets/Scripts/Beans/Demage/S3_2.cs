using UnityEngine;
using System.Collections;

public class S3_2 : MonoBehaviour
{

    public GameObject Ship;
    public float DeltaX;

    public bool isDo = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            if(!isDo)
            {
                isDo = true;
                Ship.transform.position += new Vector3 (DeltaX, 0);
            }

        }
    }
}


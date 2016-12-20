using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public Transform DeadLine;

    void Update()
    {
        if(DeadLine != null)
        {
            if(this.gameObject.transform.position.y < DeadLine.position.y)
            {
                Scene3Manager.Instance.RestartScene ();
            }
        }
    }



}


using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour
{

    public float Speed = 50f;

    private bool up = false;
    private bool down = false;
    private bool left = false;
    private bool right = false;

    private Vector3 initPositon;

    void Start()
    {
        initPositon = transform.position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == Constant.Name_Player)
        {
            Scene3Manager.Instance.RestartScene ();
        }
    }

    void Update()
    {
        if(up)
        {
            transform.position += new Vector3 (0, Speed * Time.deltaTime);
        }
        if(down)
        {
            transform.position += new Vector3 (0, -Speed * Time.deltaTime);
        }
        if(left)
        {
            transform.position += new Vector3 (-Speed * Time.deltaTime, 0);
        }
        if(right)
        {
            transform.position += new Vector3 (Speed * Time.deltaTime, 0);
        }
    }

    public void StartUpMove()
    {
        up = true;
        down = false;
        left = false;
        right = false;
    }
    public void StartDownMove()
    {
        up = false;
        down = true;
        left = false;
        right = false;
    }
    public void StartLeftMove()
    {
        up = false;
        down = false;
        left = true;
        right = false;
    }
    public void StartRightMove()
    {
        up = false;
        down = false;
        left = false;
        right = true;
    }
    public void StopMove()
    {
        up = false;
        down = false;
        left = false;
        right = false;
    }

    public void Init()
    {
        StopMove ();
        transform.position = initPositon;
    }
}


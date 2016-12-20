using UnityEngine;
using System.Collections;

public class IceFlower : MonoBehaviour
{
    public Transform StartTransform;
    public Transform EndTransform;
    public float Speed = 300f;
    public float RangeX = 500f;
    public float RangeY = 100f;
    public float RotateSpeed = 10f;
    private Vector3 move;

    void Start()
    {
        InitMove ();
    }

    private void InitMove()
    {
        transform.position = new Vector3 (
            StartTransform.position.x + Random.Range(-RangeX, RangeX), 
            StartTransform.position.y + Random.Range(-RangeY, RangeY),
            transform.position.z);
        move = new Vector3 (Random.Range (-Speed / 10, Speed / 10), -Speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == Constant.Name_Player)
        {
            if(GameManager.Instance.IsGameRunning)
            {
                Scene1Manager.Instance.RestartScene ();
            }
        }
    }

    void Update()
    {
        transform.position += move * Time.deltaTime;

        transform.rotation *= Quaternion.Euler(new Vector3 (0, 0, RotateSpeed * Time.deltaTime));

        if(transform.position.y < EndTransform.position.y)
        {
            InitMove ();
        }
    }

}


using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

    private Rigidbody2D m_Rigidbody2D;

    [SerializeField]private float m_MaxSpeed = 250f;
    public Transform PlayerPos;

    private Vector3 initPositon;



    void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
    void Start()
    {
        initPositon = transform.position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == Constant.Name_Player)
        {
            PlayerController.Instance.IsOnShip = true;
            PlayerController.Instance.ShipController = this;
        }
    }

    public void MoveShip(float move)
    {
        m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, 0);
    }

    public Vector2 GetShipVelocity()
    {
        return m_Rigidbody2D.velocity;
    }

    public Vector2 GetShipPosition()
    {
        return PlayerPos.position;
    }

    public void SetFacingDir(Vector3 theScale)
    {
        gameObject.transform.localScale = new Vector3 ((theScale.x / Mathf.Abs (theScale.x)) * Mathf.Abs(gameObject.transform.localScale.x), 
            gameObject.transform.localScale.y, gameObject.transform.localScale.z);
    }

    public void Init()
    {
        if(m_Rigidbody2D != null)
        {
            m_Rigidbody2D.velocity = new Vector2 (0, 0);
        }
        transform.position = initPositon;
    }

}

using UnityEngine;
using System.Collections;

public class Scene3Manager : SingletonUnity<Scene3Manager>
{
    public Transform PlayerTransform;
    public Transform CameraTransform;

    private Vector3 m_PlayerPositon;
    private Vector3 m_CameraPositon;

    public Stone Stone1;
    public Stone Stone2;
    public GameObject Stone3;
    public Stone_static Stone4;
    public S3_6 Script;
    public S3_2 Script2;

    public Ship Ship0;
    public Ship Ship1;
    public Ship Ship2;
    public Ship Ship3;
    public Ship Ship4;

    void Start()
    {
        m_PlayerPositon = PlayerTransform.position;
        m_CameraPositon = CameraTransform.position;
    }

    public void RestartScene()
    {
        Stone1.Init ();
        Stone2.Init ();
        Stone3.SetActive (false);
        Stone4.Init ();
        Script.i = 0;
        Script2.isDo = false;

        Ship0.Init ();
        Ship1.Init ();
        Ship2.Init ();
        Ship2.gameObject.SetActive (false);
        Ship3.Init ();
        Ship3.gameObject.SetActive (false);
        Ship4.Init ();

        PlayerController.Instance.IsOnShip = false;
        PlayerTransform.position = m_PlayerPositon;
        CameraTransform.position = m_CameraPositon;



    }

}


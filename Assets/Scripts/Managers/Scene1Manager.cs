using UnityEngine;
using System.Collections;

public class Scene1Manager : SingletonUnity<Scene1Manager>
{

    public Transform PlayerTransform;
    public Transform CameraTransform;

    private Vector3 m_PlayerPositon;
    private Vector3 m_CameraPositon;

    // Use this for initialization
    void Start ()
    {
        m_PlayerPositon = PlayerTransform.position;
        m_CameraPositon = CameraTransform.position;
    }

    public void RestartScene()
    {
        PlayerTransform.position = m_PlayerPositon;
        CameraTransform.position = m_CameraPositon;
    }

}


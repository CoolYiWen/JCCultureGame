using UnityEngine;
using System.Collections;

public class MusicManager : SingletonUnity<MusicManager>
{

    public AudioSource musicSource;
    public float musicVolume = 1f;

    // Use this for initialization
    void Start ()
    {
    
    }
    
    // Update is called once per frame
    void Update ()
    {
        musicSource.volume = musicVolume;
    }
}


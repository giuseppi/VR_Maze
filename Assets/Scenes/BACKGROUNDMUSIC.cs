using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BACKGROUNDMUSIC : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource mainSong;

    void Start()
    {
        mainSong.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

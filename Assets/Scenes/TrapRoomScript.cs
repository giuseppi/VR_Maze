using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapRoomScript : MonoBehaviour
{
    // Start is called before the first frame update
    public WinCondition WinCondition;
    public CameraTeleport CameraTeleport;
    public StartTrapping StartTrapping;
    public GameObject TrapDoor1, TrapDoor2, Potion, directLight1, directLight2;
    public GameObject Lazer1, Lazer2, Lazer3, Lazer4, Lazer5, Lazer6, Lazer7, Lazer8;
    public Light d1Light, d2Light;
    public AudioSource mainSong, mini;
    public static bool trapStart = false;
    public static bool trapEnd = false;
    public static bool loseGame = false;
    bool trapping = false;
    public float trapDoorTimer = 0.0f;

    void Start()
    {
        d1Light = directLight1.GetComponent<Light>();
        d2Light = directLight2.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trapStart)
        {
            if (!trapping)
            {
                TrapDoor1.transform.position = new Vector3(29.2f, 2, -11);
                TrapDoor2.transform.position = new Vector3(50.85f, 2, -11);

                Potion.transform.position = new Vector3(39.9f, -8, -10.8f); //make disappear
                WinCondition.greenKey = true;

                Lazer1.transform.position = new Vector3(30.8f, 0.3f, -11);
                Lazer2.transform.position = new Vector3(30.8f, 0.3f, -11);
                Lazer3.transform.position = new Vector3(30.8f, 0.3f, -11);

                Lazer4.transform.position = new Vector3(49.6f, 0.3f, -11);
                Lazer5.transform.position = new Vector3(49.6f, 0.3f, -11);
                Lazer6.transform.position = new Vector3(49.6f, 0.3f, -11);

                Lazer7.transform.position = new Vector3(40, 2.3f, -19.6f);
                Lazer8.transform.position = new Vector3(40, 2.3f, -2.6f);
                d1Light.intensity = 0;
                d2Light.intensity = 0;
                trapping = true;
                mainSong.Stop();
                mini.Play();
            }
            if (trapping)
            {
                if (loseGame)
                {
                    CameraTeleport.charCnt.enabled = false;
                    CameraTeleport.charCnt.transform.position = new Vector3(132.3f, 2, -211.3f);
                    CameraTeleport.charCnt.enabled = true;
                    WinCondition.greenKey = false;
                    Potion.transform.position = new Vector3(39.83f, 0.08f, -10.8f); //make disappear
                    StartTrapping.oneTime = true;
                    trapEnd = true;
                }
                if (trapEnd)
                {
                    TrapDoor1.transform.position = new Vector3(29.2f, -8, -11);
                    TrapDoor2.transform.position = new Vector3(50.85f, -8, -11);
                    Lazer1.transform.position = new Vector3(30.8f, -2, -11);
                    Lazer2.transform.position = new Vector3(30.8f, -2, -11);
                    Lazer3.transform.position = new Vector3(30.8f, -2, -11);
                    Lazer4.transform.position = new Vector3(30.8f, -2, -11);
                    Lazer5.transform.position = new Vector3(30.8f, -2, -11);
                    Lazer6.transform.position = new Vector3(30.8f, -2, -11);
                    Lazer7.transform.position = new Vector3(30.8f, -2, -11);
                    Lazer8.transform.position = new Vector3(30.8f, -2, -11);
                    trapStart = false;
                    trapping = false;
                    trapEnd = false;
                    loseGame = false;
                    d1Light.intensity = 1;
                    d2Light.intensity = 1;
                    mini.Stop();
                    mainSong.Play();
                }
                Lazer1.transform.position += new Vector3(1f * Time.deltaTime, 0, 0);          //+x
                Lazer2.transform.position += new Vector3(2.5f * Time.deltaTime, 0, 0);
                Lazer3.transform.position += new Vector3(4f * Time.deltaTime, 0, 0);
                Lazer4.transform.position -= new Vector3(1.5f * Time.deltaTime, 0, 0);            //-x
                Lazer5.transform.position -= new Vector3(4f * Time.deltaTime, 0, 0);
                Lazer6.transform.position -= new Vector3(5f * Time.deltaTime, 0, 0);
                Lazer7.transform.position += new Vector3(0, 0, 5f * Time.deltaTime);            //+z
                Lazer8.transform.position -= new Vector3(0, 0, 5f * Time.deltaTime);            //-z
            }
        }
        
    }
}

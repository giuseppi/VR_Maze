using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGameLogic : MonoBehaviour
{
    public GameObject DoorDoor1, DoorDoor2, Door1, Door2, Door3, Door4, Door5, Door6;
    public static bool openDoor1 = false;
    public static bool openDoor2 = false;
    public static bool openDoor3 = false;
    public static bool openDoor4 = false;
    public static bool openDoor5 = false;
    public static bool openDoor6 = false;
    public static bool startDoor = false;
    public static bool endDoor = false;
    public static bool loseDoor = false;
    public bool trapping = false;
    public float startingTimer = 0.0f;
    public float Timer1 = 0.0f;
    public float Timer2 = 0.0f;
    public float Timer3 = 0.0f;
    public float Timer4 = 0.0f;
    public float Timer5 = 0.0f;
    public float Timer6 = 0.0f;
    public AudioSource mainSong, mini;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (startDoor)
        {
            if (!trapping)
            {
                if ((startingTimer += Time.deltaTime) < 1.5f)
                {
                    DoorDoor1.transform.position += new Vector3(0, 3.0f * Time.deltaTime, 0);
                }
                else
                {
                    startingTimer = 0.0f;
                    trapping = true;
                    mainSong.Stop();
                    mini.Play();
                }
            }
            if (trapping)
            {
                if (openDoor1 && !openDoor2 && !openDoor3 && (Timer1 += Time.deltaTime) < 4.0f)
                {
                    Door1.transform.position += new Vector3(0, 2.5f * Time.deltaTime, 0);
                }
                if (openDoor2 && !openDoor1 && !openDoor3 && (Timer2 += Time.deltaTime) < 4.0f)
                {
                    Door2.transform.position += new Vector3(0, 2.5f * Time.deltaTime, 0);
                }
                if (openDoor3 && !openDoor1 && !openDoor2 && (Timer3 += Time.deltaTime) < 4.0f)
                {
                    Door3.transform.position += new Vector3(0, 2.5f * Time.deltaTime, 0);
                }
                if (openDoor4 && !openDoor5 && !openDoor6 && (Timer4 += Time.deltaTime) < 4.0f)
                {
                    Door4.transform.position += new Vector3(0, 2.5f * Time.deltaTime, 0);
                }
                if (openDoor5 && !openDoor4 && !openDoor6 && (Timer5 += Time.deltaTime) < 4.0f)
                {
                    Door5.transform.position += new Vector3(0, 2.5f * Time.deltaTime, 0);
                }
                if (openDoor6 && !openDoor4 && !openDoor5 && (Timer6 += Time.deltaTime) < 4.0f)
                {
                    Door6.transform.position += new Vector3(0, 2.5f * Time.deltaTime, 0);
                }
                if (endDoor)
                {
                    if ((startingTimer += Time.deltaTime) < 4.0f)
                    {
                        DoorDoor1.transform.position -= new Vector3(0, 2.0f * Time.deltaTime, 0);
                        DoorDoor2.transform.position -= new Vector3(0, 2.0f * Time.deltaTime, 0);
                        Door3.transform.position += new Vector3(208.21f, -10, -19.765f);
                        Door4.transform.position += new Vector3(217.18f, -10, -7.18f);
                    }
                }
                else if (loseDoor)
                {
                    DoorDoor1.transform.position = new Vector3(199.45f, -2.53f, -13.46f);
                    DoorDoor2.transform.position = new Vector3(224.37f, 1.11f, -13.46f);

                    Door1.transform.position = new Vector3(208.21f, 1.748f, -7.18f);
                    Door2.transform.position = new Vector3(208.21f, 1.748f, -13.454f);
                    Door3.transform.position = new Vector3(208.21f, 1.748f, -19.765f);
                    Door4.transform.position = new Vector3(217.18f, 1.748f, -7.18f);
                    Door5.transform.position = new Vector3(217.18f, 1.748f, -13.454f);
                    Door6.transform.position = new Vector3(217.18f, 1.748f, -19.765f);

                    Timer1 = 0.0f;
                    Timer2 = 0.0f;
                    Timer3 = 0.0f;
                    Timer4 = 0.0f;
                    Timer5 = 0.0f;
                    Timer6 = 0.0f;
                    startingTimer = 0.0f;

                    trapping = false;

                    openDoor1 = false;
                    openDoor2 = false;
                    openDoor3 = false;
                    openDoor4 = false;
                    openDoor5 = false;
                    openDoor6 = false;
                    loseDoor = false;
                    endDoor = false;
                    startDoor = false;
                    mini.Stop();
                    mainSong.Play();
                }
            }
        }
    }
}


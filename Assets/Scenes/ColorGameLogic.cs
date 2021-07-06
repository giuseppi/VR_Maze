using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGameLogic : MonoBehaviour
{
    public FailColorGame FailColorGame;
    public FailColorGame2 FailColorGame2;
    public GameObject ColorDoor1, ColorDoor2, AllStands, ColorLight, directLight1, directLight2;
    public Light cLight, d1Light, d2Light;
    public static bool startColor = false;
    public static bool endColor = false;
    public static bool loseColor = false;
    public bool trapping = false;
    public float startingTimer = 0.0f;
    public float lightTimer = 0.0f;
    public AudioSource mainSong, purpleMini;

    // Start is called before the first frame update
    void Start()
    {
        cLight = ColorLight.GetComponent<Light>();
        d1Light = directLight1.GetComponent<Light>();
        d2Light = directLight2.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startColor)
        {
            if (!trapping)
            {
                if ((startingTimer += Time.deltaTime) < 4.0f)
                {
                    AllStands.transform.position += new Vector3(0, 1.0f * Time.deltaTime, 0);
                    ColorDoor1.transform.position += new Vector3(0, 1.0f * Time.deltaTime, 0);
                    ColorDoor2.transform.position += new Vector3(0, 1.0f * Time.deltaTime, 0);
                }
                else
                {
                    startingTimer = 0.0f;
                    d1Light.intensity = 0;
                    d2Light.intensity = 0;
                    trapping = true;
                    mainSong.Stop();
                    purpleMini.Play();
                }
            }
            if (trapping)
            {
                if (endColor)
                {
                    if ((startingTimer += Time.deltaTime) < 4.0f)
                    {
                        ColorDoor1.transform.position -= new Vector3(0, 1.0f * Time.deltaTime, 0);
                        ColorDoor2.transform.position -= new Vector3(0, 1.0f * Time.deltaTime, 0);
                        cLight.enabled = true;
                        FailColorGame.oneTime = false;
                        FailColorGame2.oneTime = false;
                        d1Light.intensity = 1;
                        d2Light.intensity = 1;
                        purpleMini.Stop();
                        mainSong.Play();
                    }

                }
                else if (loseColor)
                {
                    AllStands.transform.position = new Vector3(35.82f, -2.1f, -215.6f);
                    ColorDoor1.transform.position = new Vector3(43.89f, -2.53f, -215.47f);
                    ColorDoor2.transform.position = new Vector3(28.15f, -2.53f, -215.47f);
                    lightTimer = 0.0f;
                    startingTimer = 0.0f;
                    cLight.enabled = true;
                    trapping = false;
                    loseColor = false;
                    endColor = false;
                    startColor = false;
                    FailColorGame.oneTime = true;
                    FailColorGame2.oneTime = true;
                    d1Light.intensity = 1;
                    d2Light.intensity = 1;
                    purpleMini.Stop();
                    mainSong.Play();
                }
                else
                {
                    lightTimer += Time.deltaTime;
                    if (lightTimer < 3.0f)
                    {
                        cLight.enabled = false;
                    }
                    else if (lightTimer >= 3.0f && lightTimer < 4.0f)
                    {
                        cLight.enabled = true;

                    }
                    else
                    {
                        lightTimer = 0.0f;
                    }
                }
            }
        }
    }
}

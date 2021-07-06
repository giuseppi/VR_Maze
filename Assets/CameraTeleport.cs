using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.UI;

public class CameraTeleport : MonoBehaviour
{
    public static bool isGameOn { get; set; } = false;
    public static bool loseGame { get; set; } = false;
    public static bool winGame { get; set; } = false;
    public static float elapsedTime = 0.0f;
    public Text loseText, winText;
    //public static int randNum = 0;
    // Start is called before the first frame update
    public static CharacterController charCnt;
    public AudioSource mainSong, lose, win;
    void Start()
    {
        charCnt = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOn)
        {
            if (Input.GetKeyDown(KeyCode.F))              //start the game
            {
                charCnt.enabled = false;
                transform.position = new Vector3(125, 1, -221);
                charCnt.enabled = true;
                isGameOn = true;
                mainSong.Play();
                lose.Stop();
                win.Stop();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #else
                    Application.Quit();
                #endif
            }
        }
        else if (isGameOn)
        {
            if (Input.GetKeyDown(KeyCode.Escape) || loseGame)
            {
                isGameOn = false;
                loseGame = false;
                loseText.text = "\n\n\n\n\nUh-Oh\nYou Lost!\n\nYour Time Was: " + elapsedTime.ToString() + "\nTo Try Again Press F!";
                charCnt.enabled = false;
                transform.position = new Vector3(0, 12, 0);
                charCnt.enabled = true;
                mainSong.Stop();
                lose.Play();
            }
            if (winGame)
            {
                isGameOn = false;
                winGame = false;
                winText.text = "\n\n\n\n\nYay!\nYou finished the maze!\n\nYour Time Was: " + elapsedTime.ToString() + "\nTo Improve Your Time\nPress F!";
                charCnt.enabled = false;
                transform.position = new Vector3(0, 24, 0);
                charCnt.enabled = true;
                mainSong.Stop();
                win.Play();
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                charCnt.enabled = false;
                transform.position = new Vector3(197.32f, 5, -11);
                charCnt.enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                charCnt.enabled = false;
                transform.position = new Vector3(223.3f, 5, -214);
                charCnt.enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                charCnt.enabled = false;
                transform.position = new Vector3(24.4f, 5, -11);
                charCnt.enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                charCnt.enabled = false;
                transform.position = new Vector3(24.4f, 5, -214);
                charCnt.enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                charCnt.enabled = false;
                transform.position = new Vector3(124.9f, 1, -8);
                charCnt.enabled = true;
                isGameOn = true;
            }
            elapsedTime += Time.deltaTime;
        }
    }

}
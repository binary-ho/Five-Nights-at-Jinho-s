using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ailen : MonoBehaviour
{
    public static int whereNowAil;
    private int ticks;
    private int count;
    private int levelOfAilen;
    private int dice;
    private int dice2;

    [SerializeField]
    public GameObject ailen10;
    public GameObject ailen11;
    public GameObject ailen20;
    public GameObject ailen21;
    public GameObject ailen30;
    public GameObject ailen50;
    public GameObject ailen0;
    public GameObject ailenJump;
    public GameObject Cameras;
    public GameObject CamCube1;
    public GameObject CCTVUI;

    private AudioSource audioPlayer;
    public AudioClip KillClip;

    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    void Start()
    {
        //2345
        whereNowAil = 10;
        levelOfAilen = 2;
        ticks = 500;
        count = 0;
        ailen10.SetActive(true);
        ailen11.SetActive(false);
        ailen20.SetActive(false);
        ailen21.SetActive(false);
        ailen30.SetActive(false);
        ailen50.SetActive(false);
        ailen0.SetActive(false);
        ailenJump.SetActive(false);
    }

    void Update()
    {

        // if (UICount.TimeNow == 1)
        // {
        //     levelOfAilen = 2;
        // }
        // else 
        if (UICount.TimeNow == 1)
        {
            levelOfAilen = 3;
            //levelOfAilen = 4;
        }
        else if (UICount.TimeNow == 2)
        {
            levelOfAilen = 4;
            //levelOfAilen = 5;
        }
        else if (UICount.TimeNow == 3)
        {
            levelOfAilen = 5;
        }
        else if (UICount.TimeNow == 4)
        {
            levelOfAilen = 6;
        }

        if (count < ticks)
        {
            count++;
        }
        else
        {
            dice = Random.Range(0, 21);
            count = 0;
            if (dice <= levelOfAilen)
            {
                if (whereNowAil == 10)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAil = 11;
                        ailen10.SetActive(false);
                        ailen11.SetActive(true);
                    }
                    else
                    {
                        whereNowAil = 50;
                        ailen10.SetActive(false);
                        ailen50.SetActive(true);
                    }
                }
                else if (whereNowAil == 11)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAil = 20;
                        ailen11.SetActive(false);
                        ailen20.SetActive(true);
                    }
                    else
                    {
                        whereNowAil = 50;
                        ailen11.SetActive(false);
                        ailen50.SetActive(true);
                    }
                }
                else if (whereNowAil == 50)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAil = 11;
                        ailen50.SetActive(false);
                        ailen11.SetActive(true);
                    }
                    else
                    {
                        whereNowAil = 20;
                        ailen50.SetActive(false);
                        ailen20.SetActive(true);
                    }
                }//TODO:
                else if (whereNowAil == 30)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        Debug.Log("도착0");
                        whereNowAil = 0;
                        ailen30.SetActive(false);
                        ailen0.SetActive(true);
                        StartCoroutine(DoorCheck());
                    }
                    else
                    {
                        whereNowAil = 20;
                        ailen30.SetActive(false);
                        ailen20.SetActive(true);
                    }
                }
                else if (whereNowAil == 20)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAil = 21;
                        ailen20.SetActive(false);
                        ailen21.SetActive(true);
                    }
                    else
                    {
                        whereNowAil = 30;
                        ailen20.SetActive(false);
                        ailen30.SetActive(true);
                    }
                } //TODO:
                else if (whereNowAil == 21)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        Debug.Log("도착1");
                        whereNowAil = 0;
                        ailen21.SetActive(false);
                        ailen0.SetActive(true);
                        StartCoroutine(DoorCheck());
                    }
                    else
                    {
                        whereNowAil = 30;
                        ailen21.SetActive(false);
                        ailen30.SetActive(true);
                    }
                }
            }
        }
    }

    private IEnumerator GoDeadScene()
    {
        CCTVUI.SetActive(false);
        Cameras.SetActive(false);
        CamCube1.SetActive(false);
        CamCube1.SetActive(true);
        Cameras.SetActive(true);
        audioPlayer.PlayOneShot(KillClip);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("DeadScene");
    }

    private IEnumerator DoorCheck()
    {
        yield return new WaitForSeconds(10f);

        if (LightController1.isDoorOpen1 == true)
        {
            if (UICount.iKill == false)
            {
                Debug.Log("1");
                UIClickCtrl1.canCCTV = false;
                UICount.iKill = true;
                ailen0.SetActive(false);
                ailenJump.SetActive(true);

                StartCoroutine(GoDeadScene());
                Debug.Log("AilenKill");
            }
            else
            {
                Debug.Log("2");
                whereNowAil = 11;
                ailen0.SetActive(false);
                ailen11.SetActive(true);
            }
        }
        else
        {
            Debug.Log("3");
            whereNowAil = 11;
            ailen0.SetActive(false);
            ailen11.SetActive(true);
        }
    }

}

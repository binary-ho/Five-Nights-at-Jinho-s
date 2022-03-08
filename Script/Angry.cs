using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Angry : MonoBehaviour
{
    public static int whereNowAng;
    private int ticks;
    private int count;
    private int levelOfAngry;
    private int dice;
    private int dice2;

    [SerializeField]
    public GameObject angry10;
    public GameObject angry11;
    public GameObject angry70;
    public GameObject angry60;
    public GameObject angry40;
    public GameObject angry41;
    public GameObject angry0;
    public GameObject angryJump;
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
    {//345
        whereNowAng = 10;
        levelOfAngry = 1;
        ticks = 490;
        count = 0;
        angry10.SetActive(true);
        angry11.SetActive(false);
        angry70.SetActive(false);
        angry60.SetActive(false);
        angry40.SetActive(false);
        angry41.SetActive(false);
        angry0.SetActive(false);
        angryJump.SetActive(false);
    }

    void Update()
    {
        if (UICount.TimeNow == 1)
        {
            levelOfAngry = 3;
        }
        else if (UICount.TimeNow == 2)
        {
            levelOfAngry = 4;
        }
        else if (UICount.TimeNow == 4)
        {
            levelOfAngry = 5;
        }

        if (count < ticks)
        {
            count++;
        }
        else
        {
            dice = Random.Range(0, 21);
            count = 0;
            if (dice <= levelOfAngry)
            {
                if (whereNowAng == 10)
                {
                    whereNowAng = 11;
                    angry10.SetActive(false);
                    angry11.SetActive(true);
                }
                else if (whereNowAng == 11)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAng = 70;
                        angry11.SetActive(false);
                        angry70.SetActive(true);
                    }
                    else
                    {
                        whereNowAng = 60;
                        angry11.SetActive(false);
                        angry60.SetActive(true);
                    }
                }
                else if (whereNowAng == 70)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAng = 60;
                        angry70.SetActive(false);
                        angry60.SetActive(true);
                    }
                    else
                    {
                        whereNowAng = 40;
                        angry70.SetActive(false);
                        angry40.SetActive(true);
                    }
                }
                else if (whereNowAng == 60)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAng = 70;
                        angry60.SetActive(false);
                        angry70.SetActive(true);
                    }
                    else
                    {
                        whereNowAng = 40;
                        angry60.SetActive(false);
                        angry40.SetActive(true);
                    }
                }
                else if (whereNowAng == 40)
                {
                    dice2 = Random.Range(0, 5);
                    if (dice2 <= 1)
                    {
                        whereNowAng = 11;
                        angry40.SetActive(false);
                        angry11.SetActive(true);
                    }
                    else
                    {
                        whereNowAng = 41;
                        angry40.SetActive(false);
                        angry41.SetActive(true);
                    }
                }
                else if (whereNowAng == 41)
                {
                    dice2 = Random.Range(0, 2);
                    if (dice2 == 0)
                    {
                        whereNowAng = 0;
                        angry41.SetActive(false);
                        angry0.SetActive(true);
                        StartCoroutine(DoorCheck());
                    }
                    else
                    {
                        whereNowAng = 40;
                        angry41.SetActive(false);
                        angry40.SetActive(true);
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

        yield return new WaitForSeconds(9f);
        if (LightController1.isDoorOpen2 == true)
        {
            if (UICount.iKill == false)
            {
                UIClickCtrl1.canCCTV = false;
                UICount.iKill = true;
                angry0.SetActive(false);
                angryJump.SetActive(true);
                StartCoroutine(GoDeadScene());
                Debug.Log("AngryKill");
            }
            else
            {
                whereNowAng = 41;
                angry0.SetActive(false);
                angry41.SetActive(true);
            }
        }
        else
        {
            whereNowAng = 41;
            angry0.SetActive(false);
            angry41.SetActive(true);
        }
    }

}

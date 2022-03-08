using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Passport : MonoBehaviour
{
    [SerializeField]
    private static int whereNowP;
    private int ticks;
    private int count;
    private int levelOfP;
    private int dice;
    private int dice2;
    private int dice3;
    private int dice4;
    public string passNow;


    [SerializeField]
    public GameObject passport10;
    public GameObject passport11;
    public GameObject passport70;
    public GameObject passport60;
    public GameObject passport40;
    public GameObject passport41;
    public GameObject passport0;
    public GameObject passportJump;
    public GameObject Cam4B;
    public GameObject RightDoor;
    public GameObject Cameras;
    public GameObject CamCube1;
    public GameObject CCTVUI;

    private AudioSource audioPlayer;
    public AudioClip moveLaughClip;
    public AudioClip moveLaughClip2;
    public AudioClip moveStepClip;
    public AudioClip KillClip;

    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    void Start()
    {//134
        whereNowP = 10;
        levelOfP = 1;
        ticks = 497; // 대략 8초
        count = 0;
        passNow = "Cam1AN";


        passport10.SetActive(true);
        passport11.SetActive(false);
        passport70.SetActive(false);
        passport60.SetActive(false);
        passport40.SetActive(false);
        passport41.SetActive(false);
        passport0.SetActive(false);
        passportJump.SetActive(false);
    }

    void Update()
    {
        if (UICount.TimeNow == 1)
        {
            levelOfP = 3;
        }
        else if (UICount.TimeNow == 2)
        {
            levelOfP = 4;
        }

        if (count < ticks && UIClickCtrl1.cameraNow != passNow)
        {
            count++;
        }
        else if (count >= ticks && UIClickCtrl1.cameraNow != passNow)
        {
            dice = Random.Range(0, 21);
            count = 0;
            if (dice <= levelOfP)
            {
                if (whereNowP == 10)
                {
                    dice3 = Random.Range(1, 4);
                    if (dice3 < 3)
                    {
                        whereNowP = 11;
                        passport10.SetActive(false);
                        passport11.SetActive(true);
                        passNow = "Cam1BN";
                        audioPlayer.volume = 0.2f;
                        audioPlayer.PlayOneShot(moveLaughClip);
                        audioPlayer.PlayOneShot(moveStepClip);
                        audioPlayer.volume = 1f;
                    }
                    else
                    {
                        dice2 = Random.Range(0, 2);
                        if (dice2 == 0)
                        {
                            whereNowP = 70;
                            passport10.SetActive(false);
                            passport70.SetActive(true);
                            passNow = "Cam7N";
                            audioPlayer.volume = 0.2f;
                            StartCoroutine(DoubleSmile());
                            audioPlayer.volume = 1f;
                        }
                        else
                        {
                            whereNowP = 60;
                            passport10.SetActive(false);
                            passport60.SetActive(true);
                            passNow = "Cam6N";
                            audioPlayer.volume = 0.2f;
                            StartCoroutine(DoubleSmile());
                            audioPlayer.volume = 1f;
                        }
                    }
                }
                else if (whereNowP == 11)
                {
                    dice3 = Random.Range(1, 4);
                    if (dice3 < 3)
                    {
                        dice2 = Random.Range(0, 2);
                        if (dice2 == 0)
                        {
                            whereNowP = 70;
                            passport11.SetActive(false);
                            passport70.SetActive(true);
                            passNow = "Cam7N";
                            audioPlayer.volume = 0.2f;
                            dice4 = Random.Range(0, 3);
                            if (dice4 == 0)
                            {
                                audioPlayer.PlayOneShot(moveLaughClip2);
                                audioPlayer.PlayOneShot(moveStepClip);
                            }
                            else
                            {
                                audioPlayer.PlayOneShot(moveLaughClip);
                                audioPlayer.PlayOneShot(moveStepClip);
                            }
                            audioPlayer.volume = 1f;
                        }
                        else
                        {
                            whereNowP = 60;
                            passport11.SetActive(false);
                            passport60.SetActive(true);
                            passNow = "Cam6N";
                            audioPlayer.volume = 0.2f;
                            dice4 = Random.Range(0, 3);
                            if (dice4 == 0)
                            {
                                audioPlayer.PlayOneShot(moveLaughClip2);
                                audioPlayer.PlayOneShot(moveStepClip);
                            }
                            else
                            {
                                audioPlayer.PlayOneShot(moveLaughClip);
                                audioPlayer.PlayOneShot(moveStepClip);
                            }
                            audioPlayer.volume = 1f;
                        }
                    }
                    else
                    {
                        whereNowP = 40;
                        passport11.SetActive(false);
                        passport40.SetActive(true);
                        passNow = "Cam4AN";
                        audioPlayer.volume = 0.2f;
                        StartCoroutine(DoubleSmile());
                        audioPlayer.volume = 1f;
                    }
                }
                else if (whereNowP == 70)
                {
                    dice3 = Random.Range(1, 4);
                    if (dice3 < 3)
                    {
                        whereNowP = 40;
                        passport70.SetActive(false);
                        passport40.SetActive(true);
                        passNow = "Cam4AN";
                        audioPlayer.volume = 0.3f;
                        dice4 = Random.Range(0, 3);
                        if (dice4 == 0)
                        {
                            audioPlayer.PlayOneShot(moveLaughClip2);
                            audioPlayer.PlayOneShot(moveStepClip);
                        }
                        else
                        {
                            audioPlayer.PlayOneShot(moveLaughClip);
                            audioPlayer.PlayOneShot(moveStepClip);
                        }
                        audioPlayer.volume = 1f;
                    }
                    else
                    {
                        whereNowP = 41;
                        passport70.SetActive(false);
                        passport41.SetActive(true);
                        passNow = "Cam4BN";
                        audioPlayer.volume = 0.3f;
                        StartCoroutine(DoubleSmile());
                        audioPlayer.volume = 1f;
                    }
                }
                else if (whereNowP == 60)
                {
                    dice3 = Random.Range(1, 4);
                    if (dice3 < 3)
                    {
                        whereNowP = 40;
                        passport60.SetActive(false);
                        passport40.SetActive(true);
                        passNow = "Cam4AN";
                        audioPlayer.volume = 0.3f;
                        dice4 = Random.Range(0, 3);
                        if (dice4 == 0)
                        {
                            audioPlayer.PlayOneShot(moveLaughClip2);
                            audioPlayer.PlayOneShot(moveStepClip);
                        }
                        else
                        {
                            audioPlayer.PlayOneShot(moveLaughClip);
                            audioPlayer.PlayOneShot(moveStepClip);
                        }
                        audioPlayer.volume = 1f;
                    }
                    else
                    {
                        whereNowP = 41;
                        passport60.SetActive(false);
                        passport41.SetActive(true);
                        passNow = "Cam4BN";
                        audioPlayer.volume = 0.3f;
                        StartCoroutine(DoubleSmile());
                        audioPlayer.volume = 1f;
                    }
                }
                else if (whereNowP == 40)
                {
                    whereNowP = 41;
                    passport40.SetActive(false);
                    passport41.SetActive(true);
                    passNow = "Cam4BN";
                    audioPlayer.volume = 0.3f;
                    dice4 = Random.Range(0, 3);
                    if (dice4 == 0)
                    {
                        audioPlayer.PlayOneShot(moveLaughClip2);
                        audioPlayer.PlayOneShot(moveStepClip);
                    }
                    else
                    {
                        audioPlayer.PlayOneShot(moveLaughClip);
                        audioPlayer.PlayOneShot(moveStepClip);
                    }
                    audioPlayer.volume = 1f;
                }
                else if (whereNowP == 41)
                {
                    StartCoroutine(WaitFor3sconds());

                    if (LightController1.isDoorOpen2)
                    {
                        StartCoroutine(PassportKill());
                    }
                    else
                    {
                        whereNowP = 11;
                        passport41.SetActive(false);
                        passport11.SetActive(true);
                        levelOfP = 5;
                        passNow = "Cam1BN";
                        audioPlayer.volume = 0.3f;
                        audioPlayer.PlayOneShot(moveLaughClip);
                        audioPlayer.PlayOneShot(moveStepClip);
                        audioPlayer.PlayOneShot(moveStepClip);
                        audioPlayer.volume = 1f;
                    }
                }
            }
        }

        if (whereNowP == 41 && UIClickCtrl1.cameraNow == "Cam4BN" && LightController1.isDoorOpen2)
        {
            StartCoroutine(PassportKill());
        }
        else if (whereNowP == 41 && UIClickCtrl1.cameraNow == "Cam4BN" && !LightController1.isDoorOpen2)
        {
            StartCoroutine(PassportBack());
            audioPlayer.volume = 0.3f;
            audioPlayer.PlayOneShot(moveLaughClip);
            audioPlayer.PlayOneShot(moveStepClip);
            audioPlayer.PlayOneShot(moveStepClip);
            audioPlayer.volume = 1f;
        }
    }
    private IEnumerator GoDeadScene()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("DeadScene");
    }

    private IEnumerator PassportKill()
    {
        if (UICount.iKill == false)
        {
            UICount.iKill = true;
            UIClickCtrl1.canCCTV = false;
            yield return new WaitForSeconds(3f);


            whereNowP = 0;
            passport41.SetActive(false);
            passport0.SetActive(true);
            RightDoor.SetActive(false);

            yield return new WaitForSeconds(10f);

            Cameras.SetActive(false);
            CamCube1.SetActive(false);
            CamCube1.SetActive(true);
            Cameras.SetActive(true);
            passport0.SetActive(false);
            passportJump.SetActive(true);
            Debug.Log("PassportKill");
            audioPlayer.PlayOneShot(KillClip);
            StartCoroutine(GoDeadScene());
        }
        else
        {
            StartCoroutine(PassportBack());
        }
    }
    private IEnumerator PassportBack()
    {
        yield return new WaitForSeconds(3f);
        whereNowP = 11;
        passport41.SetActive(false);
        passport11.SetActive(true);
        levelOfP = 5;
        passNow = "Cam1BN";

    }
    // private IEnumerator DoorCheck() // neededit
    // {
    //     yield return new WaitForSeconds(8.5f);
    //     if (LightController1.isDoorOpen2)
    //     {
    //         passport0.SetActive(false);
    //         passportJump.SetActive(true);
    //         StartCoroutine(GoDeadScene());
    //     }
    //     else
    //     {
    //         whereNowP = 41;
    //         passport0.SetActive(false);
    //         passport41.SetActive(true);
    //     }
    // }
    private IEnumerator DoubleSmile()
    {
        audioPlayer.volume = 0.2f;
        audioPlayer.PlayOneShot(moveLaughClip);
        audioPlayer.PlayOneShot(moveStepClip);
        yield return new WaitForSeconds(1.5f);
        audioPlayer.PlayOneShot(moveLaughClip);
        audioPlayer.PlayOneShot(moveStepClip);
        audioPlayer.volume = 1f;

    }
    private IEnumerator WaitFor3sconds()
    {
        yield return new WaitForSeconds(3f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vain : MonoBehaviour
{
    private static int whereNowV;
    private int ticks;
    private int count;
    private int levelOfVain;
    private int dice;
    private int dice2;
    bool didYouSee;

    [SerializeField]
    public GameObject Ailen2A;

    [SerializeField]
    public GameObject VainP0;
    public GameObject VainP1;
    public GameObject VainP2;
    public GameObject VainP3Coff;
    public GameObject VainP4Run;
    public GameObject VainJump;
    public GameObject Cameras;
    public GameObject CamCube1;
    public GameObject CCTVUI;
    public GameObject leftDoor;

    private AudioSource audioPlayer;
    public AudioClip KillClip;
    public AudioClip knockClip;
    public AudioClip angryClip;

    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    void Start()
    {//04
        whereNowV = 0;
        levelOfVain = 1;
        ticks = 317;
        count = 0;
        VainP0.SetActive(true);
        VainP1.SetActive(false);
        VainP2.SetActive(false);
        VainP3Coff.SetActive(false);
        VainP4Run.SetActive(false);
        VainJump.SetActive(false);
        CCTVUI.SetActive(false);
        didYouSee = false;
    }

    void Update()
    {

        if (UICount.TimeNow == 2)
        {
            levelOfVain = 5;
        }
        else if (UICount.TimeNow == 3)
        {
            levelOfVain = 6;
        }


        if (count < ticks && !UIClickCtrl1.onCCTV)
        {
            count++;
        }
        else if (count >= ticks && !UIClickCtrl1.onCCTV)
        {
            dice = Random.Range(1, 21);
            count = 0;
            if (dice <= levelOfVain)
            {
                if (whereNowV == 0)
                {

                    whereNowV = 1;
                    VainP0.SetActive(false);
                    VainP1.SetActive(true);
                }
                else if (whereNowV == 1)
                {

                    whereNowV = 2;
                    VainP1.SetActive(false);
                    VainP2.SetActive(true);
                }
                else if (whereNowV == 2)
                {

                    whereNowV = 3;
                    VainP2.SetActive(false);
                    VainP3Coff.SetActive(true);
                    VainP4Run.SetActive(true);
                    StartCoroutine(DoorCheck());
                    if (Ailen.whereNowAil == 20)
                    {
                        Ailen2A.SetActive(false);
                    }

                }
            }
        }

        if (whereNowV == 3 && UIClickCtrl1.cameraNow == "Cam2AN" && LightController1.isDoorOpen1)
        {
            UIClickCtrl1.canCCTV = false;
            LightController1.isDoorOpen1 = true;
            leftDoor.SetActive(false);
            didYouSee = true;
        }
    }

    private IEnumerator GoDeadScene()
    {
        //UIClickCtrl1
        CCTVUI.SetActive(false);
        Cameras.SetActive(false);
        CamCube1.SetActive(false);
        CamCube1.SetActive(true);
        Cameras.SetActive(true);
        VainJump.SetActive(true);
        audioPlayer.PlayOneShot(KillClip);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("DeadScene");
    }
    // private IEnumerator WaitVain()
    // {
    //     yield return new WaitForSeconds(8f);
    //     VainP3Coff.SetActive(false);
    //     VainP4Run.SetActive(false);
    //     VainJump.SetActive(true);
    // }
    private IEnumerator DoorCheck()
    {
        if (UICount.iKill == false)
        {
            UICount.iKill = true;

            yield return new WaitForSeconds(8.5f);
            VainP4Run.SetActive(false);
            if (LightController1.isDoorOpen1 || didYouSee == true)
            {
                Debug.Log("VainKill");
                UIClickCtrl1.canCCTV = false;
                didYouSee = false;
                //VainJump.transform.LookAt(CamCube1.transform);
                StartCoroutine(GoDeadScene());
            }
            else
            {
                whereNowV = 1;
                VainP0.SetActive(false);
                VainP1.SetActive(true);
                VainP3Coff.SetActive(false);
                VainP4Run.SetActive(false);
                VainRun.run = 0;

                if (Ailen.whereNowAil == 20)
                {
                    Ailen2A.SetActive(true);
                }
                UICount.iKill = false;
                levelOfVain = 3;
                audioPlayer.PlayOneShot(knockClip);
                audioPlayer.PlayOneShot(angryClip);
            }
        }
        else
        {
            whereNowV = 1;
            VainP0.SetActive(false);
            VainP1.SetActive(true);
            VainP3Coff.SetActive(false);
            VainP4Run.SetActive(false);
            VainRun.run = 0;
            if (Ailen.whereNowAil == 20)
            {
                Ailen2A.SetActive(true);
            }
            UICount.iKill = false;
            levelOfVain = 3;
        }
    }
}

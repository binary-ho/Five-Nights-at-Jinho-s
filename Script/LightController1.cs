using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// 필요 사운드
// 1. 문 열고 닫는 소리
// 2. 불 켜지고 꺼지는 소리
// 3. 오작동 소리
// 4. 정전소리

public class LightController1 : MonoBehaviour
{
    [SerializeField]
    public GameObject lightObject1;
    public GameObject lightObject2;
    public GameObject lightObject3;
    public GameObject DoorObject1;
    public GameObject DoorObject2;
    //public LeftDoor1 leftDoor1ScriptVirable;
    public DoorController Door1;
    public DoorController Door2;

    public Camera cam1;
    public GameObject camM;
    public GameObject camMain;

    public GameObject doll2Eye;
    public GameObject doll3Eye;

    // public GameObject EnemyLight1;
    // public GameObject EnemyLight2;

    //public Animator LFA;

    public static bool isLightOn1 { get; set; }
    public static bool isLightOn2 { get; set; }
    public static bool isDoorOpen1 { get; set; }
    public static bool isDoorOpen2 { get; set; }
    //public static bool camMainOn { get; set; }

    private AudioSource auidoPlayer;
    public AudioClip doorClip;
    //public AudioClip lightClip;
    public AudioClip malfuntionClip;
    public AudioClip digitalClip;
    public AudioClip watchClip;

    private void Awake()
    {
        auidoPlayer = GetComponent<AudioSource>();
    }
    void Start()
    {
        isLightOn1 = false;
        isLightOn2 = false;
        isDoorOpen1 = true;
        isDoorOpen2 = true;
        //camMainOn = true;
        Door1.OpenIt();
        Door2.OpenIt();
        doll2Eye.SetActive(false);
        doll3Eye.SetActive(false);

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !UIClickCtrl1.onCCTV)
        {
            RaycastHit hit1;
            Ray ray1 = cam1.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray1, out hit1))
            {
                //Debug.Log(hit1.transform.name);
                if (hit1.transform.name == "Left Light Button")
                {
                    if (!isLightOn1 && UICount.LeftPower > 0)
                    {
                        lightObject1.SetActive(true);
                        isLightOn1 = true;
                        UICount.BatteryStack++;
                        auidoPlayer.PlayOneShot(malfuntionClip);
                        if (Ailen.whereNowAil == 0)
                        {
                            auidoPlayer.PlayOneShot(watchClip);
                        }
                    }
                    else if (isLightOn1 && UICount.LeftPower > 0)
                    {
                        lightObject1.SetActive(false);
                        isLightOn1 = false;
                        UICount.BatteryStack--;
                        auidoPlayer.PlayOneShot(malfuntionClip);
                    }
                    else
                    {
                        auidoPlayer.PlayOneShot(malfuntionClip);
                    }
                }
                else if (hit1.transform.name == "Right Light Button")
                {
                    if (!isLightOn2 && UICount.LeftPower > 0)
                    {
                        lightObject2.SetActive(true);

                        isLightOn2 = true;
                        doll2Eye.SetActive(true);
                        doll3Eye.SetActive(true);
                        UICount.BatteryStack++;
                        auidoPlayer.PlayOneShot(malfuntionClip);
                        if (Angry.whereNowAng == 0)
                        {
                            auidoPlayer.PlayOneShot(watchClip);
                        }
                    }
                    else if (isLightOn2 && UICount.LeftPower > 0)
                    {
                        lightObject2.SetActive(false);
                        isLightOn2 = false;
                        doll2Eye.SetActive(false);
                        doll3Eye.SetActive(false);
                        UICount.BatteryStack--;
                        auidoPlayer.PlayOneShot(malfuntionClip);
                    }
                    else
                    {
                        auidoPlayer.PlayOneShot(malfuntionClip);
                    }
                }
                else if (hit1.transform.name == "Left Door Button")
                {
                    if (!isDoorOpen1 && UICount.LeftPower > 0)
                    {
                        isDoorOpen1 = true;
                        Door1.OpenIt();
                        UICount.BatteryStack--;
                        auidoPlayer.PlayOneShot(doorClip);
                    }
                    else if (isDoorOpen1 && UICount.LeftPower > 0)
                    {
                        isDoorOpen1 = false;
                        Door1.CloseIt();
                        UICount.BatteryStack++;
                        auidoPlayer.PlayOneShot(doorClip);
                    }
                    else
                    {
                        auidoPlayer.PlayOneShot(malfuntionClip);
                    }
                }
                else if (hit1.transform.name == "Right Door Button")
                {
                    if (!isDoorOpen2 && UICount.LeftPower > 0)
                    {
                        isDoorOpen2 = true;
                        Door2.OpenIt();
                        UICount.BatteryStack--;
                        auidoPlayer.PlayOneShot(doorClip);
                    }
                    else if (isDoorOpen2 && UICount.LeftPower > 0)
                    {
                        isDoorOpen2 = false;
                        Door2.CloseIt();
                        UICount.BatteryStack++;
                        auidoPlayer.PlayOneShot(doorClip);
                    }
                    else
                    {
                        auidoPlayer.PlayOneShot(malfuntionClip);
                    }
                }
                else if (hit1.transform.name == "Moniter" && UICount.LeftPower > 0)
                {
                    auidoPlayer.PlayOneShot(digitalClip);
                }
            }
        }

        if (UICount.LeftPower == 0)
        {
            Door1.gameObject.SetActive(false);
            Door2.gameObject.SetActive(false);
            isDoorOpen1 = true;
            isDoorOpen2 = true;
            lightObject1.SetActive(false);
            isLightOn1 = false;
            lightObject2.SetActive(false);
            isLightOn2 = false;
            lightObject3.SetActive(false);
        }
    }

}


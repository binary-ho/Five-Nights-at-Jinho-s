using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UICount : MonoBehaviour
{
    [SerializeField]
    public Text TimeText;
    public static float TimeCount;
    public static int TimeNow;
    public static bool iKill;
    float startTime;

    [SerializeField]
    public Text LeftPowerText;
    public static int LeftPower;
    public static int BatteryStack;
    private float BatteryCount;
    private float BatteryReset;
    // private로 가봅니다.
    public GameObject Battery1;
    public GameObject Battery2;
    public GameObject Battery3;
    public GameObject Battery4;
    public GameObject OffLight1;
    public GameObject OffLight2;
    public UIClickCtrl1 CCTVONScript;

    [SerializeField]
    public Text DayText;
    public static int Day;
    public Text UsageText;

    void Start()
    {
        LeftPower = 99;
        DayText.text = "Night " + (Day + 1);
        TimeCount = 90f;
        TimeNow = 0;
        BatteryStack = 1;
        BatteryCount = 0;
        BatteryReset = 4620f;
        iKill = false;
        startTime = Time.time;
    }

    void Update()
    {
        // About Time
        if (TimeNow >= 1 && TimeNow < 6)
        {
            TimeText.text = TimeNow + " AM";
        }
        else if (TimeNow == 6)
        {
            TimeNow = 0;
            SceneManager.LoadScene("ClearScene");
        }

        if ((Time.time - startTime) >= TimeCount)
        {//90
            TimeCount += 90f;
            TimeNow++;
        }

        //BatteryCount
        if (BatteryStack == 1)
        {
            BatteryCount += 544f * Time.deltaTime;
            Battery2.SetActive(false);
        }
        else if (BatteryStack == 2)
        {
            BatteryCount += 840f * Time.deltaTime;
            Battery2.SetActive(true);
            Battery3.SetActive(false);
        }
        else if (BatteryStack == 3)
        {
            BatteryCount += 1320f * Time.deltaTime;
            Battery3.SetActive(true);
            Battery4.SetActive(false);
        }
        else if (BatteryStack >= 4)
        {
            BatteryCount += 2310f * Time.deltaTime;
            Battery4.SetActive(true);
        }
        else if (BatteryStack < 1)
        {
            BatteryStack = 1;
        }
        // Powerleft
        if (BatteryCount >= BatteryReset)
        {
            LeftPower -= 1;
            BatteryCount = 0;
            LeftPowerText.text = "Power left: " + LeftPower + "%";
        }

        if (LeftPower == 0)
        {
            LeftPowerText.gameObject.SetActive(false);
            UsageText.gameObject.SetActive(false);
            OffLight1.SetActive(false);
            OffLight2.SetActive(false);
            CCTVONScript.CCTVON();
        }
    }
}


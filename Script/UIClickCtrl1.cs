using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIClickCtrl1 : MonoBehaviour
{
    [SerializeField]
    public GameObject CamMain;
    public GameObject Cam1A;
    public GameObject Cam1B;
    public GameObject Cam1C;
    public GameObject Cam2A;
    public GameObject Cam2B;
    public GameObject Cam3;
    public GameObject Cam4A;
    public GameObject Cam4B;
    public GameObject Cam5;
    public GameObject Cam6;
    public GameObject Cam7;
    public GameObject CamM;
    public GameObject CCTVUI;
    public GameObject Blink;
    public Text RoomText;
    public static bool canCCTV;
    public static bool onCCTV;

    [SerializeField]
    public static string cameraNow;
    int dotBlink;
    private AudioSource audioPlayer;
    public AudioClip buzzClip;
    public AudioClip cctvsoundClip;

    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    void Start()
    {
        cameraNow = "MainN";
        dotBlink = 1;
        canCCTV = true;
        onCCTV = false;
    }
    void Update()
    {
        if (CCTVUI)
        {
            if (dotBlink == 60)
            {
                Blink.gameObject.SetActive(false);
                dotBlink++;
            }
            else if (dotBlink == 120)
            {
                Blink.gameObject.SetActive(true);
                dotBlink = 1;
            }
            else { dotBlink++; }
        }
    }

    public void CCTVON()
    {
        if (cameraNow == "MainN" && UICount.LeftPower > 0 && canCCTV == true)
        {
            onCCTV = true;
            CamMain.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            Cam1A.gameObject.SetActive(true);
            CCTVUI.gameObject.SetActive(true);
            RoomText.text = "Show Stage";
            cameraNow = "Cam1AN";
            UICount.BatteryStack++;
            audioPlayer.PlayOneShot(cctvsoundClip);
        }
        else
        {
            onCCTV = false;
            CamMain.gameObject.SetActive(true);
            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            CCTVUI.gameObject.SetActive(false);
            cameraNow = "MainN";
            UICount.BatteryStack--;
            if (UICount.LeftPower > 0)
            {
                audioPlayer.PlayOneShot(cctvsoundClip);
            }
        }
    }
    public void CCTVShift(string cameraShift)
    {
        if (cameraShift == "1A")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "Show Stage";

            Cam1A.gameObject.SetActive(true);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam1AN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "1B")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "Dining Area";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(true);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam1BN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "1C")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "Prop Room";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(true);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam1CN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "2A")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "West Hall";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(true);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam2AN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "2B")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "W. Hall Corner";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(true);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam2BN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "3")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "Supply Closet";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(true);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam3N";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "4A")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "East Hall";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(true);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam4AN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "4B")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "E.Hall Coner";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(true);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam4BN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "5")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "Storage";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(true);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam4BN";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "6")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "Kitchen";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(true);
            Cam7.gameObject.SetActive(false);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam6N";
            audioPlayer.PlayOneShot(buzzClip);
        }
        else if (cameraShift == "7")
        {
            CamMain.gameObject.SetActive(false);
            RoomText.text = "Restrooms";

            Cam1A.gameObject.SetActive(false);
            Cam1B.gameObject.SetActive(false);
            Cam1C.gameObject.SetActive(false);
            Cam2A.gameObject.SetActive(false);
            Cam2B.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
            Cam4A.gameObject.SetActive(false);
            Cam4B.gameObject.SetActive(false);
            Cam5.gameObject.SetActive(false);
            Cam6.gameObject.SetActive(false);
            Cam7.gameObject.SetActive(true);
            CamM.gameObject.SetActive(false);
            cameraNow = "Cam7N";
            audioPlayer.PlayOneShot(buzzClip);
        }
    }
}
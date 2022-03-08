using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinningSquence : MonoBehaviour
{
    //public ShakeClear Shake;
    public GameObject text5AM;
    public GameObject text6AM;
    public GameObject thanksMassage;
    public GameObject madeText;
    public GameObject winText;
    public GameObject congText;

    private AudioSource audioPlayer;
    public AudioClip timeUpClip;
    public AudioClip congClip;

    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    void Start()
    {
        text5AM.SetActive(true);
        text6AM.SetActive(false);
        thanksMassage.SetActive(false);
        madeText.SetActive(false);
        //ShakeClear Shake = GetComponent<ShakeClear>();
        //Shake.enabled = true;
        StartCoroutine(ShakeTime());
        //Shake.enabled = false;

    }

    IEnumerator ShakeTime()
    {
        yield return new WaitForSeconds(2.5f);
        text5AM.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        text6AM.SetActive(true);
        audioPlayer.PlayOneShot(timeUpClip);
        yield return new WaitForSeconds(3f);
        text6AM.SetActive(false);
        congText.SetActive(true);
        audioPlayer.PlayOneShot(congClip);
        yield return new WaitForSeconds(2f);
        congText.SetActive(false);
        winText.SetActive(true);
        yield return new WaitForSeconds(2f);
        winText.SetActive(false);
        thanksMassage.SetActive(true);
        yield return new WaitForSeconds(5f);
        thanksMassage.SetActive(false);
        madeText.SetActive(true);
        yield return new WaitForSeconds(3f);
        madeText.SetActive(false);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("LobbyScenes");
    }
}

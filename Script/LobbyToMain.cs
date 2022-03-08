using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyToMain : MonoBehaviour
{
    public GameObject News;
    private AudioSource audioPlayer;
    public AudioClip welcomeClip;
    public GameObject sceneObject;


    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    void Start()
    {
    }
    public void StartGame()
    {
        sceneObject.SetActive(false);
        //News.SetActive(true);
        audioPlayer.PlayOneShot(welcomeClip);
        //StartCoroutine(ShowNews());
        SceneManager.LoadScene("MainScenes");
    }

    IEnumerator ShowNews()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainScenes");
    }
}

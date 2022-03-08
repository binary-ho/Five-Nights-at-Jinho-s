using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    int playonetime = 0;
    public GameObject sceneStart;
    public GameObject sceneEnd;

    private AudioSource audioPlayer;
    public AudioClip gameOverClip;

    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    void Start()
    {
        sceneStart.SetActive(true);
        sceneEnd.SetActive(false);
    }
    void Update()
    {
        if (playonetime == 0)
        {
            StartCoroutine(GameOverPlay());
            playonetime++;
        }
    }

    IEnumerator GameOverPlay()
    {
        yield return new WaitForSeconds(5f);
        sceneStart.SetActive(false);
        sceneEnd.SetActive(true);
        audioPlayer.PlayOneShot(gameOverClip);
        yield return new WaitForSeconds(10f);
        playonetime = 0;
        SceneManager.LoadScene("LobbyScenes");
    }
}

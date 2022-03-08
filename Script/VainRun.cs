using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VainRun : MonoBehaviour
{
    public static int run = 0;
    public GameObject vain2A;
    private AudioSource audioPlayer;
    public AudioClip runClip;
    public AudioClip runClip2;
    // Update is called once per frame

    private void Awake()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    void Update()
    {
        vain2A.transform.localPosition += new Vector3(0, 0, -28f * Time.deltaTime * 2f);
        if (run == 0)
        {
            run++;
            StartCoroutine(RunSound());
        }
    }

    private IEnumerator RunSound()
    {
        audioPlayer.PlayOneShot(runClip);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip2);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip2);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip2);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip2);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip2);
        yield return new WaitForSeconds(0.08f);
        audioPlayer.PlayOneShot(runClip);
        yield return new WaitForSeconds(10f);
        run = 0;
    }
}

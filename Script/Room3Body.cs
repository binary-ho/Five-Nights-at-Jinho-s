using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Body : MonoBehaviour
{
    //int Count;
    public GameObject Body1;
    public GameObject Body2;

    void Start()
    {
        Body1.SetActive(true);
        Body2.SetActive(false);
        //Count = 0;
    }
    void Update()
    {
        StartCoroutine(BodyWait());
        StartCoroutine(BodyChange());
    }

    private IEnumerator BodyWait()
    {
        float t = Random.Range(0, 1f);
        yield return new WaitForSeconds(t);
    }
    private IEnumerator BodyChange()
    {
        Body1.SetActive(false);
        Body2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Body1.SetActive(true);
        Body2.SetActive(false);
        //yield return new WaitForSeconds(1.5f);
    }

}

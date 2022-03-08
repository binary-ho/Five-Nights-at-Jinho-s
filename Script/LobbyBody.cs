using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyBody : MonoBehaviour
{
    int Count;
    public GameObject Body1;
    public GameObject Body2;

    void Start()
    {
        Body1.SetActive(true);
        Body2.SetActive(false);
        Count = 0;
    }
    void Update()
    {
        Count++;
        if (Count >= 420 && Count <= 540)
        {
            StartCoroutine(BodyChange());
        }
        else if (Count > 660)
        {
            Count = 0;
        }
    }

    private IEnumerator BodyWait()
    {
        float t = Random.Range(4f, 6f);
        yield return new WaitForSeconds(t);
    }
    private IEnumerator BodyChange()
    {
        Body1.SetActive(false);
        Body2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Body1.SetActive(true);
        Body2.SetActive(false);
    }

}

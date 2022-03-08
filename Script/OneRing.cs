using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneRing : MonoBehaviour
{
    public GameObject phoneRing;
    // Start is called before the first frame update
    void Start()
    {
        phoneRing.SetActive(false);
        StartCoroutine(Ring());
        // phoneRing.SetActive(true);
        // StartCoroutine(RingStop());
        // phoneRing.SetActive(false);
    }

    // Update is called once per frame
    private IEnumerator Ring()
    {
        yield return new WaitForSeconds(20f);
        phoneRing.SetActive(true);
        yield return new WaitForSeconds(30f);
        phoneRing.SetActive(false);
    }
    private IEnumerator RingStop()
    {
        yield return new WaitForSeconds(30f);
    }
}

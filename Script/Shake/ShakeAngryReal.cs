using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeAngryReal : MonoBehaviour
{

    Vector3 originPos;

    void Start()
    {
        originPos = transform.localPosition;
        StartCoroutine(Shake(0.01f, 3));
        //StartCoroutine(Shake(1f, 10));
    }

    public IEnumerator Shake(float _amount, float _duration)
    {
        float timer = 0;
        while (timer <= _duration)
        {
            transform.localPosition = (Vector3)Random.insideUnitCircle * _amount + originPos;

            timer += Time.deltaTime;
            yield return 0.01f;    //null;
        }
        transform.localPosition = originPos;

    }
}

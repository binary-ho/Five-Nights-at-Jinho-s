using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakeClear : MonoBehaviour
{

    Vector3 originPos;
    public Text t5AM;

    void Start()
    {
        originPos = t5AM.rectTransform.localPosition;
        //originPos = transform.localPosition;
        StartCoroutine(Shake(1f, 2.3f));
    }

    public IEnumerator Shake(float _amount, float _duration)
    {
        float timer = 0;
        while (timer <= _duration)
        {
            t5AM.rectTransform.localPosition = (Vector3)Random.insideUnitCircle * _amount + originPos;

            timer += Time.deltaTime;
            yield return 0.01f;    //null;
        }
        t5AM.rectTransform.localPosition = originPos;

    }
}

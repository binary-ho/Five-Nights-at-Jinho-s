using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    public GameObject WorningText;
    public GameObject ThanksMassage;
    public GameObject Scene1;
    public GameObject SceneText;
    public GameObject brightObject;
    public GameObject brightText;
    public GameObject brightButton;


    void Start()
    {
        WorningText.SetActive(true);
        ThanksMassage.SetActive(false);
        Scene1.SetActive(false);
        SceneText.SetActive(false);
        brightObject.SetActive(false);
        brightText.SetActive(false);
        brightButton.SetActive(false);
        StartCoroutine(OpenTheGame());
    }

    IEnumerator OpenTheGame()
    {
        yield return new WaitForSeconds(3f);
        WorningText.SetActive(false);
        ThanksMassage.SetActive(true);
        yield return new WaitForSeconds(3f);
        ThanksMassage.SetActive(false);
        brightObject.SetActive(true);
        brightText.SetActive(true);
        brightButton.SetActive(true);

    }

    public void LobbyOpen()
    {
        brightObject.SetActive(false);
        brightText.SetActive(false);
        brightButton.SetActive(false);
        Scene1.SetActive(true);
        SceneText.SetActive(true);
    }
}

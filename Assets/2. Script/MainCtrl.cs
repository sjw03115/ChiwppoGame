using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //���� �߰��ϰڴ�

public class MainCtrl : MonoBehaviour

{
    public VideoPlayer Vd;
    public GameObject UI;

    public float timer;
    float waitingTime;
    // Start is called before the first frame update

    void Start()

    {
        timer = 0.0f;
        waitingTime = 5.0f;
        //inside = false;

    }

    // Update is called once per frame

    void Update()

    {

        if (Input.anyKeyDown)
        {
            NextGame();
        }

        timer += Time.deltaTime;

        if (timer > waitingTime) //isPrepared: �ε��� �� �ƴ�. �� �ε��� �ٵư� �÷������� �ƴ϶���� ��.
        {   
            UI.SetActive(false);
            Vd.Play();

            if (Input.anyKeyDown)
            {
                UI.SetActive(true);
            }
        }
    }


    public void NextGame()
    {
        SceneManager.LoadScene("GAME");
    }



}
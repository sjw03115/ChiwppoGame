using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement; //씬을 추가하겠다

public class MainCtrl : MonoBehaviour

{

    // Start is called before the first frame update

    void Start()

    {



    }

    // Update is called once per frame

    void Update()

    {



    }

    public void NextPage()

    {

        SceneManager.LoadScene("GAME");

    }

}
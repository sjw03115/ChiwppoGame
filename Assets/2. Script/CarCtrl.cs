using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCtrl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)

    {
        

        if (collision.transform.tag == "PLAYER")

        {

            SceneManager.LoadScene("Over");
        }
    }

    }



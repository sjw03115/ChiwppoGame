using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{

    public float speed = 1;
    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))

        {

            transform.position += Vector3.left * speed * Time.deltaTime;
            //Animation.Play("ButtonWrong", -1, 0f);
            anim.SetBool("isWalk", true); //setBool(

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("isWalk", false);
        }



        if (Input.GetKey(KeyCode.RightArrow))

        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            anim.SetBool("isWalk", true);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("isWalk", false);
        }



        if (Input.GetKey(KeyCode.UpArrow))

        {

            transform.position += Vector3.forward * speed * Time.deltaTime;
            anim.SetBool("isWalk", true);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetBool("isWalk", false);
        }



        if (Input.GetKey(KeyCode.DownArrow))

        {

            transform.position += Vector3.back * speed * Time.deltaTime;
            anim.SetBool("isWalk", true);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("isWalk", false);
        }


        if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.Space))

        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);

        }

        if (gameObject.transform.position.y < -20f) //y포지션값이 20f보다 작으면
        {
            SceneManager.LoadScene("Over");
        }
    }
    public AudioSource walksound;
    void WindPlay()

    {
    walksound.Play();
    }

}

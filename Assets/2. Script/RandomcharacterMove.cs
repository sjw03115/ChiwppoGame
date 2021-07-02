using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomcharacterMove : MonoBehaviour
{
    public float Speed = 50.0f;
    private Transform myTransform = null;
    //자기 자신을 불러오는
 
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveAmount = Speed * Vector3.back * Time.deltaTime;
        myTransform.Translate(moveAmount);

        .Vector3(Random.Range(-10f, 10f), 23f, Random.Range(-10f, 10f)) = new Vector3(Random.Range(-60.0f, 60.0f), -11f, 0.0f);

    }
}

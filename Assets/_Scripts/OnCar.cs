using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCar : MonoBehaviour
{
    public float speed;

    public bool carCrash;

    private float tempSpeed;
    // Start is called before the first frame update
    void Start()
    {
        if (speed == 0) speed = 5;

        tempSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x < -100)
        {
            GetComponent<OnCar>().enabled = false;
        }

        if (transform.position.z < Camera.main.transform.position.z - 30)
        {
            enabled = false;
            transform.position = new Vector3(-999,0,0);
        }

        if (carCrash)
        {
            speed -= Time.deltaTime * tempSpeed;
        }

        if (speed < 0) speed = 0;
    }

    public void SetSpeed(float spd)
    {
        speed = spd;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{
    public GameObject breakWay;
    public GameObject gaz;
    public GameObject hitEffect;
    public float speed;
    private float imp;

    private bool carCrash;

    private int crossed;
    
    private GameObject t_cross;
    private GameObject t_cross2;
    // Start is called before the first frame update
    void Start()
    {
        imp = 0.5f;

        t_cross = GameObject.Find("t_cross");
        t_cross2 = GameObject.Find("t_cross2");
        
        var cr = Instantiate(GameObject.Find("_SkinsCar").GetComponent<skinsCar>().carSkin[PlayerPrefs.GetInt("skin")],
            transform.position, transform.rotation);
        
        cr.transform.localEulerAngles = new Vector3(0,180,0);
        cr.transform.parent = transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed * imp);

        if (carCrash == false)
        {
            if (Input.GetMouseButton(0))
            {
                imp += Time.deltaTime * 3;
                if (Input.GetMouseButtonDown(0))
                {
                    Instantiate(gaz, transform.position, gaz.transform.rotation);
                    
                    GameObject.Find("Gas").GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                if (Input.GetMouseButtonUp(0) && imp > 1f)
                {
                    var bw = Instantiate(breakWay, transform.position, gaz.transform.rotation);
                    bw.transform.parent = transform;
                }

                imp -= Time.deltaTime * 3;
            }

            if (imp > 1.2) imp = 1.2f;
            if (imp < 0.4f)
            {
                imp = 0.4f;
            }
        }
        else
        {
            speed *= 0.97f;
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (carCrash == false)
        {
            collision.gameObject.GetComponent<OnCar>().carCrash = true;
            carCrash = true;

            Instantiate(hitEffect, transform.position + new Vector3(0, 5, 0), hitEffect.transform.rotation);

            GameObject.Find("endLevel").GetComponent<endLevel>().levelEnded = true;

            if (PlayerPrefs.GetInt("score") < crossed)
            {
                PlayerPrefs.SetInt("score", crossed);
            }

        }
        GameObject.Find("Crash").GetComponent<AudioSource>().Play();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cross" && carCrash == false)
        {
            crossed += 1;
           t_cross.GetComponent<TextMesh>().text = crossed + "";
           t_cross2.GetComponent<TextMesh>().text = crossed + "";
           t_cross.AddComponent<ScaleUpEffect>();
        }
    }
}

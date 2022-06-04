using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    [SerializeField]
    AudioSource buttonClickSound;
    [SerializeField]
    AudioSource heelCollectSound;
    [SerializeField]
    AudioSource collectCoinSound;
    [SerializeField]
    AudioSource slidingSound;
    [SerializeField]
    AudioSource dropHeelSound;
    [SerializeField]
    AudioSource coinCollectSound;


    private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonClick() {
        buttonClickSound.Play();

    }
    public void heelCollect()
    {
        heelCollectSound.Play();
    }
    public void collectcoin()
    {
        collectCoinSound.Play();
    }
    public void enableSlidingSound()
    {
        slidingSound.Play();

    }
    public void  disableSlidingSound()
    {
        slidingSound.Stop();
    }
    public void enabledropHeelSound()
    {
        dropHeelSound.Play();
    }
    public void enableCoinCollectSound()
    {
        coinCollectSound.Play();
    }

}

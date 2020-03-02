using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdieController : MonoBehaviour
{
    public bool introTrigger;
    public bool hasBeenCompleted = false;
    public bool speak;
    public GameObject audioManager;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        Animation();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        introTrigger = true;
        GameObject.Find("Canvas").GetComponent<GameManager>().inIntro = true;
        audioManager.GetComponent<AudioManager>().Play("Chirps");
      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        introTrigger = false;
        hasBeenCompleted = true;

        // GameObject.Find("Canvas").GetComponent<GameManager>().inIntro = false;
    }
    private void OnBecameInvisible()
    {
        if (hasBeenCompleted == true)
        {
            Destroy(gameObject);
        }
       
    }
    private void Animation()
    {
        anim.SetBool("Speak", speak);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro1 : MonoBehaviour
{
    public bool startIntro;
    
    public bool actionNow;
    private KeyCode action = KeyCode.DownArrow;

    //object for the introtexts
    public int introTextLength;
    public GameObject[] introTexts;

    public GameObject audioManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actionNow = GameObject.Find("Player").GetComponent<PlayerController>().actionNow;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // startIntro = true;
        StartCoroutine(IntroText());
    
    }

    IEnumerator IntroText()
    {
        {
           // GameObject.Find("Birdie").
            GetComponent<BirdieController>().speak = true;
            startIntro = false;
            int i = 0;
            
             while(i < introTexts.Length)
             {
                introTexts[i].SetActive(true);
                yield return new WaitForEndOfFrame();
                yield return new WaitUntil(() =>Input.GetKeyUp(KeyCode.DownArrow));
                yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.DownArrow));

                introTexts[i].SetActive(false);
                i++;
             }
            GetComponent<BirdieController>().speak = false;
            audioManager.GetComponent<AudioManager>().Stop("Chirps");

            GameObject.Find("Canvas").GetComponent<GameManager>().inIntro = false;

        }
    }
   
       
    }
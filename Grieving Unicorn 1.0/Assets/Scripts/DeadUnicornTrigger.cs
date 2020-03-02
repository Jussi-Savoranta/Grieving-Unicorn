using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadUnicornTrigger : MonoBehaviour
{
   
    public int daisyCount;
    public int violetCount;
    public int lilyCount;
    public GameObject graveDaisy;
    public GameObject graveLily;
    public GameObject graveViolet;
    public Transform actionSpot;
    public Transform violetSpot;
    public Transform lilySpot;
    public bool unicornTrigger;
    public bool actionNow;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        daisyCount = GameObject.Find("Canvas").GetComponent<GameManager>().daisyCount;
        violetCount = GameObject.Find("Canvas").GetComponent<GameManager>().violetCount;
        lilyCount = GameObject.Find("Canvas").GetComponent<GameManager>().lilyCount;

        actionNow = GameObject.Find("Player").GetComponent<PlayerController>().actionNow;

        if (unicornTrigger == true && actionNow == true)
        {
            if (daisyCount > 0)
            {
                GameObject graveFloverclone = Instantiate(graveDaisy,
               actionSpot.position,
               actionSpot.rotation);
                GameObject.Find("Canvas").GetComponent<GameManager>().daisyCount--;

            }
            else if (lilyCount > 0)
            {
                GameObject graveFloverclone = Instantiate(graveLily,
               lilySpot.position,
               lilySpot.rotation);
                GameObject.Find("Canvas").GetComponent<GameManager>().lilyCount--;
            }
            else if (violetCount > 0)
            {
                GameObject graveFloverclone = Instantiate(graveViolet,
               violetSpot.position,
               violetSpot.rotation);
                GameObject.Find("Canvas").GetComponent<GameManager>().violetCount--;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        unicornTrigger = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        unicornTrigger = false;
    }
}

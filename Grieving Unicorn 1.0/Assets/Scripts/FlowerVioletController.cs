using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerVioletController : MonoBehaviour
{
    public bool flowerTrigger;
    public bool pick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pick = GameObject.Find("Player").GetComponent<PlayerController>().actionNow;
        if (flowerTrigger == true && pick == true)
        {
            GameObject.Find("Canvas").GetComponent<GameManager>().violetCount++;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flowerTrigger = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        flowerTrigger = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowController : MonoBehaviour
{
    public GameObject rbEffect1;
    public GameObject rbEffect2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        rbEffect1.SetActive(true);
        rbEffect2.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        rbEffect1.SetActive(false);
        rbEffect2.SetActive(false);
    }
}

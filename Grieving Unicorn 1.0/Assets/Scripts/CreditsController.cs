using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsController : MonoBehaviour
{
    public GameObject[] credits;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        credits[i].SetActive(true);
        if (i > 0)
        {
            credits[i - 1].SetActive(false);

        }
    }
    public void Next()
    {
        
        if (i >= 8)
        {
            credits[i].SetActive(false);
            i = 0;
        }
        else
        {
            i++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int daisyCount;
    public int violetCount;
    public int lilyCount;
    public bool inIntro;
    public int graveFlowerCount;
    public bool openGame;
    public GameObject spawnFlower;
    public Transform spawnPoint;
    public bool spawnOneFlower;

    public GameObject daisyPic;
    public GameObject lilyPic;
    public GameObject violetPic;

    public Text daisyText;
    public Text lilyText;
    public Text violetText;

    public GameObject daisyTextObject;
    public GameObject lilyTextObject;
    public GameObject violetTextObject;



    // Start is called before the first frame update
    void Start()
    {
        openGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        graveFlowerCount = GameObject.FindGameObjectsWithTag("GraveFlower").Length;
        if (graveFlowerCount >= 2 && openGame == false)
        {
            openGame = true;
            //spawnOneFlower = true;

           StartCoroutine(SpawnOneFlower());
              
                //spawnOneFlower = false;
            

        }
        if (daisyCount > 0)
        {
            daisyPic.SetActive(true);
            daisyText.text = "x " + daisyCount.ToString();
            if (daisyCount < 2)
            {
                daisyTextObject.SetActive(false);
            }
            else
            {
                daisyTextObject.SetActive(true);
            }

        }
        else
        {
            daisyPic.SetActive(false);

        }
        if (lilyCount > 0)
        {
            lilyPic.SetActive(true);
            lilyText.text = "x " + lilyCount.ToString();
            if (lilyCount < 2)
            {
                lilyTextObject.SetActive(false);
            }
            else
            {
                lilyTextObject.SetActive(true);
                
            }
        }
        else
        {
            lilyPic.SetActive(false);

        }
        if (violetCount > 0)
        {
            violetPic.SetActive(true);
            violetText.text = "x " + violetCount.ToString();
            if (violetCount < 2)
            {
                violetTextObject.SetActive(false);
            }
            else
            {
                violetTextObject.SetActive(true);

            }
        }
        else
        {
            violetPic.SetActive(false);

        }
    }
    IEnumerator SpawnOneFlower()
    {
        yield return new WaitForSecondsRealtime(2);
        GameObject spawnFlowerclone = Instantiate(spawnFlower,
                 spawnPoint.position,
                 spawnPoint.rotation);
    }

}

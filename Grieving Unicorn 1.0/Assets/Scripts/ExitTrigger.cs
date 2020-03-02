using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitTrigger : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject player;
    public Transform spawnPoint;
    public string mainMenu;

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
        Time.timeScale = 0;
        exitPanel.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Resume()
    {
        exitPanel.SetActive(false);
        player.SetActive(false);
        Time.timeScale = 1;
        player.transform.position = spawnPoint.position;
        player.SetActive(true);
    }
}

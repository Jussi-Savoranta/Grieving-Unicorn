using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnchor : MonoBehaviour
{
    public Transform player;
    public float cameraPositionY;
    public float cameraPositionX;
    private float x;
    private float y;
    //mikä tää oli?
    private float distance = 3.8f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        y = player.position.y;
        if (y < 0)
        {
            cameraPositionY = 0;
        }
        else
        {
            cameraPositionY = y;
        }

        x = player.position.x;
        if (x < 0)
        {
            cameraPositionX = 0;
        }
        else
        {
            cameraPositionX = x;
        }

    }



    void LateUpdate()
    {
        if (GameObject.Find("Canvas").GetComponent<GameManager>().openGame == true)
        {
            MoveCamera();
        }
        

    }
    private void MoveCamera()
    {
            transform.position =
                  new Vector3(cameraPositionX,
                  cameraPositionY, transform.position.z);
    }
}

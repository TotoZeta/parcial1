using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float forwardSpeed;
    public float rotateSpeed;
    bool pauseOn;
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        PauseOff();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {                                                                    
            transform.position = transform.position + (transform.forward * forwardSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (transform.forward * -forwardSpeed * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
        }

         if (Input.GetKeyDown(KeyCode.P))
         {
                pauseOn = !pauseOn;
                pausePanel.SetActive(pauseOn);
                if (!pauseOn)
                {
                    Time.timeScale = 1;
                }
                else
                {
                    Time.timeScale = 0;
                }
         }
        


    }
    public void PauseOff()
    {
        pauseOn = !pauseOn;
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Navigation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        int EscenaMenu = 0;
        int Escena1 = 1;

        if (CurrentScene.name == "Escena 1")
        {
            SceneManager.LoadScene(EscenaMenu);
        }
        if(CurrentScene.name == "Main Menu")
        {
            SceneManager.LoadScene(Escena1);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

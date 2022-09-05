using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject panel,pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void On() 
    {
     panel.SetActive(true);
     Time.timeScale = 0;
     pause.SetActive(false);
    }
    public void Off() 
    {
     panel.SetActive(false);
     Time.timeScale = 1;
     pause.SetActive(true);
    }
    public void reset()
    {
     SceneManager.LoadScene("Level");
     Time.timeScale = 1;
     pause.SetActive(true);
    }
    public void MainMenu() 
    {
     SceneManager.LoadScene("MainMenu");
     Time.timeScale = 1;
    }
}

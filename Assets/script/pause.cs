using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    [SerializeField] GameObject pauseUI;
    public static bool gameIsPaused=false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused){
                resume();
            }else{
                Paused();
            } 
        }
        
    }
    void Paused ()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
        gameIsPaused = true;
    }
    void resume ()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
        gameIsPaused = false;
    }
}

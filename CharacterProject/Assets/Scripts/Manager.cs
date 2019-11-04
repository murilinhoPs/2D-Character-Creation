using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{


	public void LoadScene(int index)
	{
		SceneManager.LoadScene(index);
        
	}

    
    public void Exit()
    {
        Application.Quit();
    }

    private void Update()
    {
        
        if(SceneManager.GetActiveScene().name != "Menu")
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}

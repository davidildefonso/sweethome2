using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    

    public void changeScene()
    {
        StartCoroutine(LoadNextSceneExist());
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    IEnumerator LoadNextSceneExist()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void restart()
    {
       StartCoroutine(LoadNextScene());
      // SceneManager.LoadScene(0);
   
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update

    public void salir()
    {
        Debug.Log("fin del juego");
       Application.Quit(); 
    }

    
    
}

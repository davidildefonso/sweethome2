using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class rocaFinal : MonoBehaviour
{
    private Animator anim;
    
    
    public void OnCollisionEnter2D(Collision2D other)
    {
       anim = GameObject.FindWithTag("imagen2").GetComponent<Animator>();
       // canvas = GameObject.FindGameObjectWithTag("myCanvas").GetComponent<Canvas>();
       // Debug.Log("colision");
       if(other.transform.tag == "player")
       {
           Debug.Log(anim);
           anim.Play("fadeIn");

           StartCoroutine(LoadNextScene());
           
           
       } 
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    
    public Animator transition;
    public float transitionTime=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if(Input.GetMouseButtonDown(0))
      //  {
            LoadNextLevel();
       // }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        //play animation
        transition.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        //Load scene

//        SceneManager.LoadScene(levelIndex);
    }

}



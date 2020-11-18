using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoAnims : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.RightArrow)))
        {
            anim.SetBool("caminando",true);
        }else{            
            anim.SetBool("caminando",false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("saltando");
        }
    }
}

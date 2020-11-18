using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonMove : MonoBehaviour
{
    public Button thisBtn;
    // Start is called before the first frame update
    void Start()
    {
        thisBtn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
        thisBtn.transform.position=  new Vector3(0,-500,0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

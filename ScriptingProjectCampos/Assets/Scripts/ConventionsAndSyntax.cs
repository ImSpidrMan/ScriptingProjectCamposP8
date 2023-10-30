using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    void Start ()
    {
        //this line is here to tell me the x position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);
        if(transform.position.y <=5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}

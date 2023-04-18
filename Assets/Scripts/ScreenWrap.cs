using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public float xLeftWrap = -14.5f;
    public float xRightWrap = 64.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //left side wrap
        if(this.transform.position.x < xLeftWrap)
        {
            this.transform.position = new Vector2( 64, this.transform.position.y);
        }


        //right side wrap
        if (this.transform.position.x > xRightWrap)
        {
            this.transform.position = new Vector2(-14, this.transform.position.y);
        }
    }
}

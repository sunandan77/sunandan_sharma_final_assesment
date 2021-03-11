using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    bool abcd,b;
   
    public void Scale()
    {

        if (abcd)
        {//positive scale

            this.transform.localScale += new Vector3(0, 0, 0.1f);
            Scale();
           
        }
        if(b)
        { //negative scale

            this.transform.localScale += new Vector3(0, 0, -0.1f);
            Scale();
            if (this.transform.localScale == new Vector3(5,5,5))
            {
                b = false;
                abcd = false;
            }
        }
    }
    public void button1()
    {
        abcd = true;
        b = false;
        Scale();
    }

    private void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.tag == "obstacle")
        {
            Destroy(GameObject.FindWithTag("obstacle"));

            abcd = false;
            b = true;
            Scale();
        }



    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubescaleing_east : MonoBehaviour

{
    public Button yourButton;


    void TaskOnClick()
    { IEnumerator DoSomething(float someParameter)
    {
        while (middlecube.abcd)
        {
            this.transform.localScale += new Vector3(0, 0, 0.1f);
            yield return null;
        }
        while (!middlecube.abcd)
        {
            if (this.transform.localScale != new Vector3(1, 1, 1))
            {
                this.transform.localScale += new Vector3(0, 0, -0.1f);
                yield return null;
            }
        }

    }}




    public static bool abcd = true;
    IEnumerator Start()
    {

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        StartCoroutine("DoSomething", 2.0F);
        yield return new WaitForSeconds(1);
        StopCoroutine("DoSomething");
    }

    

    public void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.tag == "obstacle")
        {
            IEnumerator DoSomething(float someParameter)
            {
                while (middlecube.abcd)
                {
                    this.transform.localScale += new Vector3(0, 0, -0.1f);
                    yield return null;
                }
            }

            Destroy(GameObject.FindWithTag("obstacle"));

            abcd = false;

        }



    } 
}

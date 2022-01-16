using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}













































/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickyplatform : MonoBehaviour
{
        
   private void  OnCollisionEnter2D(Collision collision)
    {
        if ( collision.object.name == "Player" )
                {

                     collision.gameobject.transform.SetParent(transform);
                    


                }



    }

    private void OnCollisionExit2D(Collison collison)
    {

        if(collison.object.name == "Player")
                {

                     collison.gameobject.transform.SetParent(null);

                

                }


    }






}
*/
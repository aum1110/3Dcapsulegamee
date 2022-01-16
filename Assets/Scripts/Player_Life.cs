using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Life : MonoBehaviour
{
    bool dead = false;
    private void Update()
    {
        if(transform.position.y < -1.12 && !dead)
        {

            Die();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
   void Die()
    {
       GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Player_move>().enabled = false;
        dead = true;
        Invoke(nameof(reload),1f);
    }



    void reload()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }
}

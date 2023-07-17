using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    bool isdead=false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Die();
            ReloadLevel();
        }
       
    }

    private void Update()
    {
        if(transform.position.y<-12 && !isdead) 
        {
            Die();
            ReloadLevel() ;        
        }
    }
    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic=true;
        //GetComponent<PlayerMovement>().enabled = false;
        isdead = true;
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

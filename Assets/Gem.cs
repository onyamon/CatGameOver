using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player")){

            collider.GetComponent<PlayCollectible>().GemCollect();

            GetComponent<AudioSource>().Play();

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            //Destroy(collider);
        }
    }
  
    
}

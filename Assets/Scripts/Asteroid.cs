using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    bool contato = false;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();       
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameover)
        {
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime,
                transform.position.y);
        }
        
        if (transform.position.x < -5) //se l'asteroide esce dalla schermata
            Destroy(gameObject);
        
        if (!contato && transform.position.x < 4)
        {
            audioSource.Play();
            contato = true;
            Punti.valorePunti += 1;
        }
    }
}

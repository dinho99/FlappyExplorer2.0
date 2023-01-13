using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explorer : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    public GameObject menu;
    public GameObject newRecord;
    public AudioClip[] audioClips;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f, 7f);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameController.gameover && (Punti.valorePunti/10)%2==0) //se clicca il tasto sx, non è finito il gioco e la gravità è normale
        {
            audioSource.PlayOneShot(audioClips[0]);
            rb.velocity = new Vector2(0f, 7f); //salto
        } 
        if (Input.GetMouseButtonDown(0) && !GameController.gameover && (Punti.valorePunti/10)%2!=0)
        {
            audioSource.PlayOneShot(audioClips[0]);
            rb.velocity = new Vector2(0f, -7f); //salto con gravità invertita
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Punti.valorePunti > BestScore.record)
        {
            BestScore.record = Punti.valorePunti;
            newRecord.SetActive(true);
        }
        audioSource.PlayOneShot(audioClips[1]);
        GameController.gameover = true;
        gameover.SetActive(true);
        restart.SetActive(true);
        menu.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0, -9.8f);   
    }

    // Update is called once per frame
    void Update()
    {
        if ((Punti.valorePunti/10)%2!=0) //da 11-19; 30-39; 50-59... = penultimo numero dispari
            Physics2D.gravity = new Vector2(0, 9.8f);
        if ((Punti.valorePunti/10)%2==0) //da 0-9, 20-29, 40-49... = penultimo numero pari
            Physics2D.gravity = new Vector2(0, -9.8f);
    }
}

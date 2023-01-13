using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public static int record = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = record.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

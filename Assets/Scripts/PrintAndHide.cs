using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomInt;
 
    // Start is called before the first frame update
    void Start()
    {
        
        randomInt = Random.Range(150, 251);
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        
        if (this.gameObject.tag == "Red" && i == 100) { 
            this.gameObject.SetActive(false);
        }

        if (this.gameObject.tag == "Blue" && i == randomInt)
        {
            rend.enabled = false;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Target: MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    
    public int count;
    
    void Start()
    {
        count = 6;

        SetCountText();
        
        winTextObject.SetActive(false);
    }



    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Projectile"))
        {
          

        
            count = count - 1;

          
            SetCountText();
        }
    }


    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count <= 0)
        {
            
            winTextObject.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class projectile : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            
        }
    }
}

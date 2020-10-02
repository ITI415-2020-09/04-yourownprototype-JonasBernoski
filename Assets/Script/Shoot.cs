using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shoot : MonoBehaviour
{
    public KeyCode shootKey = KeyCode.F;
    public GameObject projectile;
    public float shootForce;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private int count;
    void Start()
    {
     
    }
    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
        }
    }
 

}
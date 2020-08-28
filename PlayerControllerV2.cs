/*

Çok basit mantıkta bir player hareket ettirme. Sadece sağ, sol ve zıplama mekaniği var.

*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    void Start()
    {
        
    }

    public float speed = 1;
    public float jumpforce = 1;

    void Update()
    {

        var hareket = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hareket, 0, 0) * Time.deltaTime * speed;

        if (Input.GetButtonDown("Jump")) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }

    }

}

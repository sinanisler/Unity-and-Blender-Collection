/*

Oyuncu fiziği ve hareketi için transform sınıfını kullanıyoruz. 
transform.translate ile yer, yön ve boyut ayarlayabiliriz.

Birde Time.deltaTime var. En basit mantık ile anlatırsam bu da nesne hızını 
saniyeye göre ayarlar diğer türlü nesne hızlı bilgisayarda hızlı yavaşta yavaş 
hareket eder. Evrensel bir zamana hızı bağlamazsak herkes aynı oyunu oynayamaz 🙂



*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // değişkeni public yaptığım için editörden de düzenlenebilir
    public float speed;

    void Start()
    {
    }

    void Update()
    {

        // player hareket ettirmek için transform.Translate kullanmalıyız
        // direk transform.position kullanırsak teleport etmiş oluruz hareket ettirmiş değil

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(horizontalInput,0,0) * Time.deltaTime * speed);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    private Rigidbody2D rb;

    IEnumerator Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;

        yield return new WaitForSeconds(2.0f);
        
        rb.bodyType = RigidbodyType2D.Dynamic;
        transform.localScale = Vector2.one;
        DisappearSeed();
        
    }

    public void DisappearSeed(){
        transform.LeanScale(Vector2.zero, 5f).setEaseInBack();
    }
}

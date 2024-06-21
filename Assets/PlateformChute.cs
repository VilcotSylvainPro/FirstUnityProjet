using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformChute : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private float fallDelay = 0.5f;
    private float destroyDelay = 2f;


    // Start is called before the first frame update


    // Update is called once per frame


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }

}

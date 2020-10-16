using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float velocidade = 5;

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gem" )
        {
            Destroy(other.gameObject);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "box")
        {
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        transform.Translate(moveHorizontal, 0, moveVertical);
    }
}

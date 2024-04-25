using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    //Comprueba por colisi�n
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            FindAnyObjectByType<GameManager>().AddCollectible();

            Destroy(gameObject);
        }
    }

}

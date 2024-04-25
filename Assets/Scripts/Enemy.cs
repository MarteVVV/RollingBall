using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    private NavMeshAgent agent;

    private Transform playerTransform;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        playerTransform = FindAnyObjectByType<Jugador>().transform;
    }

    void Update()
    {
        agent.destination = playerTransform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

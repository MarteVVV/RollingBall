using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public AudioSource audioSource;

    public TMP_Text collectiblesNumberText;
    public TMP_Text totalCollectiblesText;

    private int collectiblesNumber;
    private int totalCollectiblesNumber;

    void Start()
    {
        totalCollectiblesNumber = transform.childCount;
        totalCollectiblesText.text = totalCollectiblesNumber.ToString();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            Invoke("LoadNextLevel", 0.5f);
        }
    }

    public void LoadNextLevel()
    {
        Debug.Log("Win");
        //Si ganamos se carga la siguiente escena
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AddCollectible()
    {
        //Para el sonido al coger un coleccionable
        audioSource.Play();

        //Incrementar coleccionables
        collectiblesNumber++;

        collectiblesNumberText.text = collectiblesNumber.ToString();
    }
}

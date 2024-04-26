using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PipeHolder;
    public GameObject[] Pipes;

    [SerializeField]
    int totalPipes = 0;

    [SerializeField]
    int crctPipes = 0;

    private bool lvlComplete = false;

    public GameObject resultDisplay;

    void Start()
    {
        totalPipes = PipeHolder.transform.childCount;
        Pipes = new GameObject[totalPipes];
        for(int i=0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipeHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    public void correctMove()
    {
        crctPipes += 1;
        Debug.Log("Correct Move");
        if (crctPipes == totalPipes)
        {
            lvlComplete = true;
            resultDisplay.SetActive(true);
            Invoke("completeLvl", 2f);
            Debug.Log("You Win");
        }
    }

    public void wrongMove()
    {
        crctPipes -= 1;
        resultDisplay.SetActive(false);
    }

    private void completeLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}

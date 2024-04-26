using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };

    public float[] crctRotation;
    [SerializeField]
    bool isPlaced = false;

    int possibleRotation = 1;

    GameManager gm;

    private void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Start()
    {
        possibleRotation = crctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        if (possibleRotation > 1)
        {
            if (transform.eulerAngles.z == crctRotation[0] || transform.eulerAngles.z == crctRotation[1])
            {
                isPlaced = true;
                gm.correctMove();
            }
        }
        else
        {
            if(transform.eulerAngles.z == crctRotation[0])
            {
                isPlaced = true;
                gm.correctMove();
            }
        }
        
    }
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if (possibleRotation > 1)
        {
            if (transform.eulerAngles.z == crctRotation[0] || transform.eulerAngles.z == crctRotation[1] && isPlaced == false)
            {
                isPlaced = true;
                gm.correctMove();
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gm.wrongMove();
            }
        }
        else
        {
            if (transform.eulerAngles.z == crctRotation[0] && isPlaced == false)
            {
                isPlaced = true;
                gm.correctMove();

            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gm.wrongMove();
            }
        }

        
    }
}

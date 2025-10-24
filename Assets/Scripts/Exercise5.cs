using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    int numberToFind;
    int arraySize;
    [SerializeField] private int numberOffset;

    // Start is called before the first frame update
    void Start()
    {
        numberToFind = 10;
        arraySize = 5;

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            if (i == 4)
            {
                array[i] = numberToFind + numberOffset;
            }
            else if (i == 3) 
            {
                array[i] = numberToFind - numberOffset;
            }
            else if (i % 3 == 0) 
            {
                array[i] = numberToFind + numberOffset - i;
            }
            else if (i % 2 == 0)
            {
                array[i] = numberToFind - numberOffset + i;
            }
        }

        for (int i = 0; i < arraySize; i++)
        {
            if (array[i] == numberToFind)
            {
                Debug.Log("Found");
            }
            else
            {
                Debug.Log("Not Found");
            }

        }
        Debug.Log("Iterations Finished");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

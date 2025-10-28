using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[4];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 20);
        }

        Debug.Log("la somma e': " + (array[0] + array[1] + array[2] + array[3]));
        Debug.Log("il prodotto e': " + (array[0] * array[1] * array[2] * array[3]));
    }
}

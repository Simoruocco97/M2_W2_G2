using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    [SerializeField] private int startNumber;
    [SerializeField] private int amount;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= amount; i++)
        {
            Debug.Log(startNumber + i);
        } 
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

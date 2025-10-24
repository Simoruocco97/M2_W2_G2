using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    [SerializeField] private int index;
    [SerializeField] private int num;

    // Start is called before the first frame update
    void Start()
    {
        while (index > 0)
        {
            num++;
            Debug.Log(num);
            index--;
        }
        Debug.Log("Loop finito");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

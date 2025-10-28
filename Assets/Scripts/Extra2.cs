using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra2 : MonoBehaviour
{
    [SerializeField] int moltiplicatore;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int operazione = moltiplicatore * i;
            Debug.Log(operazione);
        }
    }
}

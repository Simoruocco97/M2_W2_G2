using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra1 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    [SerializeField] int numero3;

    // Start is called before the first frame update
    void Start()
    {
        if (numero1 > numero2 && numero1 > numero3)
        {
            Debug.Log(numero1 + " e' il numero maggiore");
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            Debug.Log(numero2 + " e' il numero maggiore");
        }
        else if (numero3 > numero1 && numero3 > numero2)
        {
            Debug.Log(numero3 + " e' il numero maggiore");
        }
        else
        {
            Debug.Log("I numeri sono tutti uguali!");
        }
    }
}

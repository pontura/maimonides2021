using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public List<int> lista;

    void Start()
    {
        print( lista[0] );
    }
    private void Update()
    {
        print(lista[1]);
    }
}

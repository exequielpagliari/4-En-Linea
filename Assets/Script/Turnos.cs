using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnos : MonoBehaviour
{
    public GameObject FichaJugador1;
    public GameObject FichaJugador2;

    // Start is called before the first frame update
    void Start()
    {
        FichaJugador1.SetActive(true);
        FichaJugador2.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Turnos : MonoBehaviour
{
    public TextMeshProUGUI TextoTurno;
    private int Jugador;

    // Start is called before the first frame update
    void Start()
    {
        Jugador = 1;
        TextoTurno.text = "Turno de Jugador " + Jugador;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jugador += 1;
            if (Jugador > 2)
            {
                Jugador = 1;
            }
            TextoTurno.text = "Turno de Jugador " + Jugador;
        }
    }
}

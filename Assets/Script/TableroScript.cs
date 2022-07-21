using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableroScript : MonoBehaviour
{

    public GameObject Colum1;
    public GameObject Colum2;
    public GameObject Colum3;
    public GameObject Colum4;
    public GameObject Colum5;
    public GameObject Colum6;
    public GameObject Fila1;
    public GameObject Fila2;
    public GameObject Fila3;
    public GameObject Fila4;
    public GameObject Fila5;
    public GameObject Fila6;
    public MeshFilter Ficha;
    public MeshFilter FichaOrg;
    public MeshFilter FichaAzul;
    public MeshFilter FichaRoja;
    public MeshFilter FichaJugador1;
    public MeshFilter FichaJugador2;
    public GameObject FichaJugador1obj;
    public GameObject FichaJugador2obj;
    private int turno;
    private int ColNumber;
    private int FilNumber;
    private int Col1Ficha;
    private int Col2Ficha;
    private int Col3Ficha;
    private int Col4Ficha;
    private int Col5Ficha;
    private int Col6Ficha;

    int rows;
    int columns;
    int [,] matrix;
    // Start is called before the first frame update
    void Start()
    {
        rows = 6;
        columns = 6;
        matrix = new int[rows, columns];
        turno = 0;
        FichaJugador2obj.SetActive(false);
        FichaJugador1obj.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (turno == 0)
        {
            FichaJugador2obj.SetActive(false);
            FichaJugador1obj.SetActive(true);
            FichaOrg = FichaJugador1;
        }

        if (turno == 1)

        {
            FichaJugador2obj.SetActive(true);
            FichaJugador1obj.SetActive(false);
            FichaOrg = FichaJugador2;
        }




        float Fil;
        Fil = FichaOrg.transform.position.y;
        if (Fil == Fila1.transform.position.y)
        {
            FilNumber = 6;
        }

        if (Fil == Fila2.transform.position.y)
        {
            FilNumber = 5;
        }

        if (Fil == Fila3.transform.position.y)
        {
            FilNumber = 4;
        }

        if (Fil == Fila4.transform.position.y)
        {
            FilNumber = 3;
        }

        if (Fil == Fila5.transform.position.y)
        {
            FilNumber = 2;
        }

        if (Fil == Fila6.transform.position.y)
        {
            FilNumber = 1;
        }




        float Col;
        Col = FichaOrg.transform.position.x;
        if (Col == Colum1.transform.position.x)
        {
            ColNumber = 6;
        }

        if (Col == Colum2.transform.position.x)
        {
            ColNumber = 5;
        }

        if (Col == Colum3.transform.position.x)
        {
            ColNumber = 4;
        }

        if (Col == Colum4.transform.position.x)
        {
            ColNumber = 3;
        }

        if (Col == Colum5.transform.position.x)
        {
            ColNumber = 2;
        }

        if (Col == Colum6.transform.position.x)
        {
            ColNumber = 1;
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            

            if (turno == 0)
            {
                FichaJugador2obj.SetActive(false);
                FichaJugador1obj.SetActive(true);
                FichaOrg = FichaJugador1;
                Ficha = FichaRoja;
                


                if (ColNumber == 1 && Col1Ficha < 6)
                {

            
                    matrix[0, Col1Ficha] = 1;
                    Col1Ficha += 1;

                    if (matrix[0, 0] == 1 && Col1Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 1] == 1 && Col1Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 2] == 1 && Col1Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 3] == 1 && Col1Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 4] == 1 && Col1Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 5] == 1 && Col1Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }
                }

                if (ColNumber == 2 && Col2Ficha < 6)
                {
                        matrix[1, Col2Ficha] = 1;
                        Col2Ficha += 1;

                    if (matrix[1, 0] == 1 && Col2Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 1] == 1 && Col2Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 2] == 1 && Col2Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 3] == 1 && Col2Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 4] == 1 && Col2Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 5] == 1 && Col2Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }

                if (ColNumber == 3 && Col3Ficha < 6)
                {
                    matrix[2, Col3Ficha] = 1;
                    Col3Ficha += 1;

                    if (matrix[2, 0] == 1 && Col3Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 1] == 1 && Col3Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 2] == 1 && Col3Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 3] == 1 && Col3Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 4] == 1 && Col3Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 5] == 1 && Col3Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }

                if (ColNumber == 4 && Col4Ficha < 6)
                {
                    matrix[3, Col4Ficha] = 1;
                    Col4Ficha += 1;

                    if (matrix[3, 0] == 1 && Col4Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 1] == 1 && Col4Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 2] == 1 && Col4Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 3] == 1 && Col4Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 4] == 1 && Col4Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 5] == 1 && Col4Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }


                if (ColNumber == 5 && Col5Ficha < 6)
                {
                    matrix[4, Col5Ficha] = 1;
                    Col5Ficha += 1;

                    if (matrix[4, 0] == 1 && Col5Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 1] == 1 && Col5Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 2] == 1 && Col5Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 3] == 1 && Col5Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 4] == 1 && Col5Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 5] == 1 && Col5Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }

                if (ColNumber == 6 && Col6Ficha < 6)
                {
                    matrix[5, Col6Ficha] = 1;
                    Col6Ficha += 1;

                    if (matrix[5, 0] == 1 && Col6Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 1] == 1 && Col6Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 2] == 1 && Col6Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 3] == 1 && Col6Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 4] == 1 && Col6Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 5] == 1 && Col6Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

            
                }

            }

            if (turno == 1)
            {
                FichaJugador2obj.SetActive(true);
                FichaJugador1obj.SetActive(false);
                FichaOrg = FichaJugador2;
                Ficha = FichaAzul;
                


                if (ColNumber == 1 && Col1Ficha < 6)
                {


                    matrix[0, Col1Ficha] = 2;
                    Col1Ficha += 1;

                    if (matrix[0, 0] > 0 && Col1Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 1] > 0 && Col1Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 2] > 0 && Col1Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 3] > 0 && Col1Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 4] > 0 && Col1Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[0, 5] > 0 && Col1Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum6.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }
                }

                if (ColNumber == 2 && Col2Ficha < 6)
                {
                    matrix[1, Col2Ficha] = 2;
                    Col2Ficha += 1;

                    if (matrix[1, 0] > 0 && Col2Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 1] > 0 && Col2Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 2] > 0 && Col2Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 3] > 0 && Col2Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 4] > 0 && Col2Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[1, 5] > 0 && Col2Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum5.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }

                if (ColNumber == 3 && Col3Ficha < 6)
                {
                    matrix[2, Col3Ficha] = 2;
                    Col3Ficha += 1;

                    if (matrix[2, 0] > 0 && Col3Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 1] > 0 && Col3Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 2] > 0 && Col3Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 3] > 0 && Col3Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 4] > 0 && Col3Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[2, 5] > 0 && Col3Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum4.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }

                if (ColNumber == 4 && Col4Ficha < 6)
                {
                    matrix[3, Col4Ficha] = 2;
                    Col4Ficha += 1;

                    if (matrix[3, 0] > 0 && Col4Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 1] > 0 && Col4Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 2] > 0 && Col4Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 3] > 0 && Col4Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 4] > 0 && Col4Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[3, 5] > 0 && Col4Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum3.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }


                if (ColNumber == 5 && Col5Ficha < 6)
                {
                    matrix[4, Col5Ficha] = 2;
                    Col5Ficha += 1;

                    if (matrix[4, 0] > 0 && Col5Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 1] > 0 && Col5Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 2] > 0 && Col5Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 3] > 0 && Col5Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 4] > 0 && Col5Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[4, 5] > 0 && Col5Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum2.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                }

                if (ColNumber == 6 && Col6Ficha < 6)
                {
                    matrix[5, Col6Ficha] = 2;
                    Col6Ficha += 1;

                    if (matrix[5, 0] > 0 && Col6Ficha == 1)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila6.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 1] > 0 && Col6Ficha == 2)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila5.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 2] > 0 && Col6Ficha == 3)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila4.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 3] > 0 && Col6Ficha == 4)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila3.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 4] > 0 && Col6Ficha == 5)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila2.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }

                    if (matrix[5, 5] > 0 && Col6Ficha == 6)
                    {
                        Instantiate(Ficha, new Vector3(Colum1.transform.position.x, Fila1.transform.position.y, Colum6.transform.position.z + 0.1f), Quaternion.identity);
                    }


                }

            }

            turno += 1;

            if (turno == 2)
            {
                turno = 0;
            }



            Debug.Log("1 -1 / " + matrix[0, 0]);
            Debug.Log("1 -2 / " + matrix[0, 1]);
            Debug.Log("1 -3 / " + matrix[0, 2]);
            Debug.Log("1 -4 / " + matrix[0, 3]);
            Debug.Log("1 -5 / " + matrix[0, 4]);
            Debug.Log("1 -6 / " + matrix[0, 5]);
            Debug.Log("2 -1 / " + matrix[1, 0]);
            Debug.Log("2 -2 / " + matrix[1, 1]);
            Debug.Log("2 -3 / " + matrix[1, 2]);
            Debug.Log("2 -4 / " + matrix[1, 3]);
            Debug.Log("2 -5 / " + matrix[1, 4]);
            Debug.Log("2 -6 / " + matrix[1, 5]);
            Debug.Log("3 -1 / " + matrix[2, 0]);
            Debug.Log("3 -2 / " + matrix[2, 1]);
            Debug.Log("3 -3 / " + matrix[2, 2]);
            Debug.Log("3 -4 / " + matrix[2, 3]);
            Debug.Log("3 -5 / " + matrix[2, 4]);
            Debug.Log("3 -6 / " + matrix[2, 5]);
            Debug.Log("4 -1 / " + matrix[3, 0]);
            Debug.Log("4 -2 / " + matrix[3, 1]);
            Debug.Log("4 -3 / " + matrix[3, 2]);
            Debug.Log("4 -4 / " + matrix[3, 3]);
            Debug.Log("4 -5 / " + matrix[3, 4]);
            Debug.Log("4 -6 / " + matrix[3, 5]);
            Debug.Log("5 -1 / " + matrix[4, 0]);
            Debug.Log("5 -2 / " + matrix[4, 1]);
            Debug.Log("5 -3 / " + matrix[4, 2]);
            Debug.Log("5 -4 / " + matrix[4, 3]);
            Debug.Log("5 -5 / " + matrix[4, 4]);
            Debug.Log("5 -6 / " + matrix[4, 5]);
            Debug.Log("6 -1 / " + matrix[5, 0]);
            Debug.Log("6 -2 / " + matrix[5, 1]);
            Debug.Log("6 -3 / " + matrix[5, 2]);
            Debug.Log("6 -4 / " + matrix[5, 3]);
            Debug.Log("6 -5 / " + matrix[5, 4]);
            Debug.Log("6 -6 / " + matrix[5, 5]);
        }
        

    }
}

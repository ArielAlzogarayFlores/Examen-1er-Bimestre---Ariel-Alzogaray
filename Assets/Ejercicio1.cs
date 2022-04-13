using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public string codigoA;
    public int dias;
    
    // Start is called before the first frame update
    void Start()
    {

        int morfiG = 300 * dias;
        int morfiPP = 400 * dias;
        int morfiPG = 700 * dias;


        if (codigoA != "PP" && codigoA != "G" && codigoA != "PG")
        {
            Debug.Log("Error, código no válido.");
        }
        else if (dias < 3)
        {
            Debug.Log("Error.");
        }
        else
        {

     
        switch (codigoA)
        {
            case "PP":

                
                Debug.Log("Para ese período se necesitan  " + morfiPP + " gramos de alimento\n");
                Debug.Log("El costo del alimento es de  $" + (morfiPP / 100)*80);

                break;

            case "PG":


                Debug.Log("Para ese período se necesitan  " + morfiPG + " gramos de alimento\n");
                Debug.Log("El costo del alimento es de  $" + (morfiPG / 100) * 80);
                break;

            case "G":


                Debug.Log("Para ese período se necesitan  " + morfiG + " gramos de alimento\n");
                Debug.Log("El costo del alimento es de  $" + (morfiG / 100) * 80);
                break;
            }
        }
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

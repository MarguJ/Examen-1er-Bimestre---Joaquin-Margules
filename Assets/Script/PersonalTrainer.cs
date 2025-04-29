using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoDeEntrenamiento;
    public int cantidadDeHoras;
    float precioCardio = 1000;
    float precioFuerza = 1500;
    float precioRecreativo = 2500;
    float descuento = 0.9f;
    float precioFinal;
    float precioDescuento;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDeHoras < 1 || cantidadDeHoras > 6)
        {
            Debug.Log("Error. Maxima cantidad de horas: 6, Minima cantidad de horas: 1.");
        }
        else
        {
            if (tipoDeEntrenamiento == "Cardio")
            {
                if (cantidadDeHoras == 6)
                {
                    precioFinal = precioCardio * cantidadDeHoras;
                    precioDescuento = precioFinal * descuento;
                }
                else
                {
                    precioFinal = precioCardio * cantidadDeHoras;
                    precioDescuento = precioFinal;
                }
            }
            else if (tipoDeEntrenamiento == "Fuerza")
            {
                if (cantidadDeHoras == 6)
                {
                    precioFinal = precioFuerza * cantidadDeHoras;
                    precioDescuento = precioFinal * descuento;
                }
                else
                {
                    precioFinal = precioFuerza * cantidadDeHoras;
                    precioDescuento = precioFinal;
                }
            }
            else if (tipoDeEntrenamiento == "Recreativo")
            {
                if (cantidadDeHoras == 6)
                {
                    precioFinal = precioRecreativo * cantidadDeHoras;
                    precioDescuento = precioFinal * descuento;
                }
                else
                {
                    precioFinal = precioRecreativo * cantidadDeHoras;
                    precioDescuento = precioFinal;
                }
            }
            else
            {
                Debug.Log("Error. Solo hay tres tipos de entrenamiento, Fuerza, Cardio o Recreativo. Ademas de que tienen que estar bien escritos (mayus en la primera letra). Elija alguno de ellos.");
                return;
            }
            Debug.Log("." + tipoDeEntrenamiento);
            Debug.Log("." + cantidadDeHoras);
            Debug.Log("." + precioFinal);
            Debug.Log("." + precioDescuento);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public static Manager Singleton;

    public float EscalaDeTiempo = 1;

    public int TasaDeHambre = 10;

    public int Felicidad = 100;
    public int Hambre = 100;
    public int Sueno = 100;

    public Mascota MascotaActual;  

    public Mascota[] EstadoDeMascotas;
    //0- normal, 1-gordo

    public Slider SLDHambre;
    public Slider SLDFelicidad;
    public Slider SLDSueno;

    void Awake(){
        if(Singleton == null)
        {
            Singleton = this;
        }
        else
        {
            Destroy(this);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
       MascotaActual = Instantiate(EstadoDeMascotas[0], Vector3.zero, Quaternion.identity) as Mascota;
       InvokeRepeating("ActualizarCosas", 0, EscalaDeTiempo);
        
    }

    int TiempoTranscurrido;
    int TiempoHambre;

    void ActualizarCosas()
    {
        if(TiempoHambre > TasaDeHambre)
        {
            TiempoHambre=0;
            Hambre--;
            SLDHambre.value = Hambre;
        }

        TiempoHambre++;
        TiempoTranscurrido++;
    }

    
}

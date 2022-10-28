using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

     // Creamos las variables:
    public int Felicidad = 100;
    public int Hambre = 100;
    public int Sueno = 100;

    public Image UIImagen; 
   
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(hambre(3.0f)); //el tiempo  será cada cuantos segundos le baja el parámetrol
       StartCoroutine(felicidad(5.0f));
       StartCoroutine(sueno(10.0f));
        
    }
    
    void Update()
    {
        if(Felicidad > 50)
            UIImagen.sprite = Resources.Load<Sprite>("Assets/Sprites/feliz");
        else 
            UiImagen
            
        

        
    }

 //Subrutinas de Hambre, Sueno y Felicidad

    private IEnumerator hambre(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);

           Hambre --;
        }
    }

    private IEnumerator felicidad(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);

           Felicidad --;
        }
    }

    private IEnumerator sueno(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);

           Sueno --;
        }
    }

    


    
}

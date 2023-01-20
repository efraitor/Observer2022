using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    //El scriptable object asociado
    public Event dropped;
    public Event pickup;
    //Icono asociado a este objeto
    public Image icon;

    // Start is called before the first frame update
    void Start()
    {
        //Del scriptable object ejecutamos el método para este objeto concreto, 
        //que hará que se ejecute el evento para todos los "escuchadores"
        dropped.Ocurred(this.gameObject);
    }

    //Cuando colisionemos contra un objeto
    private void OnCollisionEnter(Collision collision)
    {
        //Si el objeto colisiona contra el jugador
        if(collision.gameObject.tag == "Player")
        {
            //Ocurre el evento asociado para este objeto en concreto
            //Recoger el kit médico o el huevo
            pickup.Ocurred(this.gameObject);
            //Desactivamos el componente MeshRenderer para este objeto
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            //Desactivamos el componente Collider para este objeto
            this.gameObject.GetComponent<Collider>().enabled = false;
            //Destruimos el objeto
            Destroy(this.gameObject, 5);
        }
    }

}

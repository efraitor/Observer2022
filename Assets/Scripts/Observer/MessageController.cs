using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    Text message;

    // Start is called before the first frame update
    void Start()
    {
        message = this.GetComponent<Text>();
        //Cuando empiece el juego el texto estará desactivado
        message.enabled = false;
    }

    //Activamos el mensaje al recoger un objeto
    public void SetMessage(GameObject go)
    {
        message.text = "You picked up an item!";
        message.enabled = true;
        Invoke("TurnOff", 2);
    }

    //Desactivamos el mensaje pasado un tiempo
    private void TurnOff()
    {
        message.enabled = false;
    }
}

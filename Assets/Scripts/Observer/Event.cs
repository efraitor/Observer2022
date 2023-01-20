using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    //Lista de escuchadores de eventos
    private List<EventListener> elisteners = new List<EventListener>();

    //M�todo que registra en la lista los escuchadores
    public void Register(EventListener listener)
    {
        elisteners.Add(listener);
    }

    //M�todo que borra los escuchadores de la lista
    public void Unregister(EventListener listener)
    {
        elisteners.Remove(listener);
    }
    
    //Recorre la lista de escuchadores y ejecuta el m�todo de los eventos para cada listener
    public void Ocurred(GameObject go)
    {
        for(int i = 0; i < elisteners.Count; i++)
        {
            elisteners[i].OnEventOccurs(go);
        }
    }
}

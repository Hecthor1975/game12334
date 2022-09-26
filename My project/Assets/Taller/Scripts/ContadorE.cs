using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContadorE : MonoBehaviour
{
    
    public UnityEvent customActionsEnd;
    int contador;
    public int max;

   public void contar()
    {
        contador += 1;
        if (contador >= max)
        {
            customActionsEnd.Invoke();
        }
    }

}

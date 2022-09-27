using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Arcos.Taller;

public class score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoUI;
    [SerializeField] int initialScore;
    [SerializeField] UnityEvent invoke1;
    [SerializeField] UnityEvent invoke2;
    [SerializeField] UnityEvent invoke3;
    [SerializeField] private UIScript userI;
    [SerializeField] private DataChanger dataToChange;



    public void UpdateScore(int n)
    {
        initialScore += n;
        // initialScore = initialScore + n;
        textoUI.text = "Coins: "+ initialScore;
    }

    public void InvokeChar1()
    {
        if (initialScore >= 3)
        {
            initialScore -= 3;
            invoke1?.Invoke();
            UpdateScore(0);
        }
    }
    public void InvokeChar2()
    {
        if (initialScore >= 5)
        {
            initialScore -= 5;
            invoke2?.Invoke();
            UpdateScore(0);
        }
    }
    public void InvokeChar3()
    {
        if (initialScore >= 7)
        {
            initialScore -= 7;
            invoke3?.Invoke();
            UpdateScore(0);
        }
    }
    public void UpdateData()
    {
        dataToChange.ChangeValue(initialScore);
    }

    public void AddScoreFromData(float newValue)
    {
        initialScore = (int)(newValue);

    }
}

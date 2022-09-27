using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuardarScore : MonoBehaviour
{
    string id = "score";

    [SerializeField] TextMeshProUGUI texto_ui;
    int score_actual;

    // Start is called before the first frame update
    void Start()
    {
        // Leer
        score_actual = PlayerPrefs.GetInt(id, 0);

        // Escribir en ui
        texto_ui.text = "Score:" + score_actual;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Funcion de ejemplo, actualizar el puntaje "score"
    public void AddScore(int addScore)
    {
        score_actual = score_actual + addScore;
        Debug.Log("score added " + addScore + " Score Final "+ score_actual);

        // Escribir en ui
        texto_ui.text = "Score:" + score_actual;

        // Escribir
        PlayerPrefs.SetFloat(id, score_actual);
    }
}

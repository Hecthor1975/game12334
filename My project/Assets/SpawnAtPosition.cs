using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class SpawnAtPosition : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] UnityEvent onTimerZero;
    float innerTimer = 0;
    bool timerIsActive = false;

    public void SpawnNow()
    {
        Instantiate(prefab,transform.position,transform.rotation);
    }

    public void StartTimer(float time)
    {
        innerTimer = time;
        timerIsActive = true;
    }

    public void Update()
    {
        if (timerIsActive)
        {
            innerTimer -= Time.deltaTime;

            if (innerTimer <= 0)
            {
                onTimerZero?.Invoke();
                timerIsActive = false;
            }
        }
    }
}

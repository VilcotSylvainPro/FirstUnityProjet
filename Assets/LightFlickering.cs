using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightFlickering : MonoBehaviour
{


    [SerializeField] Light2D testLight;
    [SerializeField] private float MinWaitTime; 
    [SerializeField] private float MaxWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing() 
    { 
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(MinWaitTime, MaxWaitTime));
            testLight.enabled = ! testLight.enabled;
        }
    }
}

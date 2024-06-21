using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Chronometre : MonoBehaviour
{
    private float _timer = 300.0f;
    private float _timerBis = 0.0f;

    [SerializeField] private GameObject _Chrono;
    [SerializeField] private GameObject _Player;


    // Start is called before the first frame update
    void Start()
    {

        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        _Chrono.GetComponent<Text>().text = _timerBis.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Chrono();

    }

    void Chrono()
    {
        if (_timer > -1)
        {
            _timer = _timer - Time.deltaTime;
        }


        if (_timer < 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //Debug.Log(_timer);
        if (_timer > 0)
        {
            _timerBis = Mathf.FloorToInt(_timer);

            _Chrono.GetComponent<Text>().text = _timerBis.ToString();


        }


    }
}

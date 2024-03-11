using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _do, _re, _mi;
    void Start()
    {
        Debug.Log("Bat dau:");
        _do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Ban nhan phim A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _do.Play();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _re.Play();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            _mi.Play();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experimental : MonoBehaviour
{
    [SerializeField] private float speed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaSpeed = speed * Time.deltaTime;
        transform.Rotate(deltaSpeed, deltaSpeed, deltaSpeed);
    }
}

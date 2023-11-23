using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotationPickUp : MonoBehaviour
{
    public float girox = 2f;
    public float giroy = 0f;
    public float giroz = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(girox, giroy, giroz);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padlet2 : MonoBehaviour
{

    public float velocidad = 1;

    void Update()
    {

        if (Input.GetKey(KeyCode.I))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + 10 * Time.deltaTime * velocidad, -3.5f, 3.5f), transform.position.z);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y - 10 * Time.deltaTime * velocidad, -3.5f, 3.5f), transform.position.z);
        }
    }
}

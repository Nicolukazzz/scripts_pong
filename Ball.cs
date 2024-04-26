using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject textoEmpezar1;
    [SerializeField] private GameObject textoEmpezar2;
    [SerializeField] private GameObject textoSalir;

    private float velocidad_inicial = 5f;
    private float velocidad_m = 1.1f;
    private Rigidbody2D rb;
    private bool launched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !launched)
        {
            textoEmpezar1.SetActive(false);
            textoEmpezar2.SetActive(false);
            textoSalir.SetActive(false);
            Launch();
            launched = true;
        }
    }

    private void Launch()
    {
        float rvx = Random.Range(0, 2) == 0 ? 1 : -1;
        float rvy = Random.Range(0, 2) == 0 ? 1 : -1;
        rb.velocity = new Vector2(rvx, rvy) * velocidad_inicial;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Padlet"))
        {
            rb.velocity *= velocidad_m;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gol1"))
        {
            GameManager.Instance.paddle2scored();
            GameManager.Instance.restart();
            rb.velocity= Vector2.zero;
            textoEmpezar1.SetActive(true);
            textoEmpezar2.SetActive(true);
            textoSalir.SetActive(true);
            launched = false;
        }
        else
        {
            GameManager.Instance.paddle1scored();
            GameManager.Instance.restart();
            rb.velocity = Vector2.zero;
            textoEmpezar1.SetActive(true);
            textoEmpezar2.SetActive(true);
            textoSalir.SetActive(true);
            launched = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");

    }
}

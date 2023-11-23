using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Libreria de los elementos UI
using UnityEngine.SceneManagement; //libreria para cambiar de escenas,cerrar juego,etc.
using TMPro;//LIBRERIA PARA REFERENCIAR OBJETOS DE TEXTMESHPRO


public class Gamemanager : MonoBehaviour
{
    [Header("GameManagement")]
    public int points; //cantidad de puntos actuales del jugador
    [SerializeField] int winPoints;//cantidad de puntos para ganar.
    // Start is called before the first frame update
    [Header("Public References")]
    [SerializeField] TMP_Text pointsText; //Referencia al texto de puntos actuales
    [SerializeField] GameObject winPanel; //Referencia al panel de victoria

    void Start()
    {
        points = 0;

    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Points;" + points.ToString();
        if (points >= winPoints) { winPanel.SetActive(true); }
    }
    public void ResetGame(int sceneToLoad)
    {

        SceneManager.LoadScene(sceneToLoad);//carga la escena del mismo valor que sceneToLoad
    }
    public void QuitGame()
    {
        Application.Quit();//cerrar el juego

    }
}
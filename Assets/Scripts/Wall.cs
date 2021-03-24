using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    [SerializeField]
    ScoreKeeper marcador;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
         * Quando a bola bater, avisamos o ScoreKeeper 
         * para aumentar a pontuação
         */

        marcador.Goal();

    }
}

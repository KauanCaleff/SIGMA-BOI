using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void Pausado(){
        Time.timeScale = 0;// para o jogo

    }

    public void SairdoPause(){
        Time.timeScale = 1;
    }
}

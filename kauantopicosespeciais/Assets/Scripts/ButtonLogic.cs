using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private GameObject PainelMenuInicial;
    [SerializeField] private GameObject PainelOpcoes;
    [SerializeField] private GameObject PainelConfirmar;
    [SerializeField] private GameObject SeletorDificuldade;

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape)){
            AbrirConfirmar();
        }

    }
    
    public void Jogar() {
        SeletorDificuldade.SetActive(true);
    }


    public void AbrirOpcoes() {
        PainelMenuInicial.SetActive(false);
        PainelOpcoes.SetActive(true);

    }

    public void FecharOpcoes() {
        PainelMenuInicial.SetActive(true);
        PainelOpcoes.SetActive(false);

    }

    public void SairJogo() {
        Debug.Log("Sair do Jogo");
        Application.Quit();

    }

    public void Return(){
        SceneManager.LoadScene(0);
    }

    public void AbrirConfirmar() {
        PainelMenuInicial.SetActive(false);
        PainelConfirmar.SetActive(true);
        

    }

    public void FecharConfirmar() {
        PainelMenuInicial.SetActive(true);
        PainelConfirmar.SetActive(false);

    }

    public void Medio()
    {
        SceneManager.LoadScene(1);
    }

    public void Facil()
    {
        SceneManager.LoadScene(3);
    }

    public void Dificil()
    {
        SceneManager.LoadScene(2);
    }


  

}

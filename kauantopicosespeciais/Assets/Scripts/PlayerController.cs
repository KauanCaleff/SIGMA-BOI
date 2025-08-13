using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public GameObject projectilePrefab;
    public int vida = 3;
    public int kills;
    private float xRange;
    public Text killtxt;
    public Text vidatxt;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            
            float screenWidth = mainCamera.orthographicSize * mainCamera.aspect;
            xRange = screenWidth; 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        // movimenta o player para esquerda e direita a partir da entrada do usu�rio
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        // mant�m o player dentro dos limites do jogo (eixo x)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.y);
        }
        // dispara comida ao pressionar barra de espa�o
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        //}
        
    
    }
    
    public void Kill(int quantity)
    {
        kills += quantity;
        killtxt.text = kills.ToString();
    }
    
    public void Diminui(int quantidade)
    {
        vida -= quantidade;
        vidatxt.text = vida.ToString();

        if (vida == 0){
            Debug.Log("Game Over");
        }
    }
    
    public void OnMoveEvent(InputAction.CallbackContext value)
    {
        horizontalInput = value.ReadValue<Vector2>().x;
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
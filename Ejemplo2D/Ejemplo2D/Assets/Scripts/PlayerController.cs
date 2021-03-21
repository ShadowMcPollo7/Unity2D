using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //Atributos
    public float fuerzaSalto = 5.5f;
    public float playerSpeed = 3f;
    private Rigidbody2D myRigibody2D;
    private Manager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        myRigibody2D = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Comprueba si ha pulsado el espacio
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Le aplicamos el valor de la fuerza en la componente vertical
            myRigibody2D.velocity = new Vector2(myRigibody2D.velocity.x, fuerzaSalto);
        }

        //Modificamos la coordenada x para movimiento horizontal
        myRigibody2D.velocity = new Vector2(playerSpeed, myRigibody2D.velocity.y);
    }

    //Se llama cuando player colisiona con cualquier objeto con la propiedad collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MonedaOro"))
        {
            Debug.Log("Ganas 10 puntos!");
            gameManager.incrementaPuntos(10);
            Destroy(collision.gameObject);

        }
        else if (collision.CompareTag("MonedaPlata"))
        {
            Debug.Log("Ganas 5 puntos!");
            gameManager.incrementaPuntos(5);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("MonedaMuerte"))
        {
            Debug.Log("Pierdes 10 puntos!");
            gameManager.incrementaPuntos(-20);
            Destroy(collision.gameObject);

        } else if (collision.CompareTag("ZonaMuerte"))
        {
            Debug.Log("Has muerto!!");
            PlayerDead();
        }
            
    }

    private void PlayerDead()
    {
        //Carga una escena o reinicia -> Pantalla inicial del juego
        SceneManager.LoadScene("Level1");
        
    }
}

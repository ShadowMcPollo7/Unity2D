using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] bloques;
    public float tiempoMin = 1f;
    public float tiempoMax = 2f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creación de una corrutina (se ejecuta en tiempo)
    IEnumerator SpawnCoroutine(float time)
    {
        yield return new WaitForSeconds(time);

        //Crea un GameObject
        Instantiate(bloques[Random.Range(0, bloques.Length)], transform.position, Quaternion.identity);

        //Para que la corrutina vuelva a ejecutarse
        StartCoroutine(SpawnCoroutine(Random.Range(tiempoMin, tiempoMax)));
            
    }
}

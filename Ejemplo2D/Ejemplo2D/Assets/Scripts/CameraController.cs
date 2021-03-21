using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Atributos para enfocar siempre al Player
    public Transform seguidorPlayer;

    // Start is called before the first frame update
    void Start()
    {
        //Metodo alternativo para tomar una referencia del objeto
        if (seguidorPlayer == null)
            seguidorPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Unity3D. Una cámara siempre trabaja en 3D -> Vector3()
        transform.position = new Vector3(seguidorPlayer.position.x, transform.position.y, transform.position.z);
    }
}

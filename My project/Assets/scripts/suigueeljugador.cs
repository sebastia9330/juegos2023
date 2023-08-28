using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 sueguir = new Vector3(0, 6, -12);
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + sueguir;
    }
}

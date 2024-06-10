using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 3;

    private float cronometro;

    [SerializeField]
    private GameObject modeloObstaculo;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}

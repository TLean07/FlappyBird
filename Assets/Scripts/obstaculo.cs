using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.5f;

    [SerializeField]
    private float variacaoposicaoY;
    private Vector3 posicaoPassaro;
    private bool pontuei; Handheld   b   

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoposicaoY, variacaoposicaoY));
    }

    private void Start(){
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        if(this.pontuei && this.transform.position.x < this.posicaoPassaro.x){
            Debug.Log("Pontuou!");
            this.pontuei = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}

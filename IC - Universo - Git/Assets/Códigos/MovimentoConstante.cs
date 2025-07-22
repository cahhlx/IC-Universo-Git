using UnityEngine;

public class MovimentoConstante : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        // Move o objeto para cima (eixo Y) com uma velocidade constante
        transform.Translate(Vector3.up * velocidade * Time.deltaTime);
    }
}

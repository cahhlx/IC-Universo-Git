using UnityEngine;

public class MovimentoConstanteY : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        // Move o objeto para cima (eixo Y) a uma velocidade constante
        transform.Translate(Vector3.up * velocidade * Time.deltaTime);
    }
}

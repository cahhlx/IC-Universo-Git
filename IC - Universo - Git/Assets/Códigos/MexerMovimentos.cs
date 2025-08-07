using UnityEngine;

public class MexerMovimentos : MonoBehaviour
{
    public orbita orbitaScript;            // Script da órbita
    public GameObject objetoParaMover;     // Objeto que será reposicionado (ex: Lua)

    /// <summary>
    /// Define uma nova velocidade de rotação e órbita.
    /// </summary>
    public void DefinirVelocidade(float valor)
    {
        if (orbitaScript != null)
        {
            orbitaScript.velocidadeOrbita = valor;
            orbitaScript.velocidadeRotacao = valor;
        }
    }

    /// <summary>
    /// Para o movimento (zera velocidades) e reseta a posição do objeto.
    /// </summary>
    public void PararMovimentos()
    {
        if (orbitaScript != null)
        {
            orbitaScript.velocidadeOrbita = 0f;
        }

        if (objetoParaMover != null)
        {
            // Mantém x = 10, zera y e z
            objetoParaMover.transform.position = new Vector3(10f, 0f, 0f);
        }
    }
}

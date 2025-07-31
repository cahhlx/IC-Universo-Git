using UnityEngine;

public class TeletransportarObjetoXR : MonoBehaviour
{
    [Header("Objeto a mover")]
    public GameObject objetoParaMover;

    [Header("Distância em frente à câmera")]
    public float distancia = 2.0f;

    // Este método será chamado pelo botão
    public void Teletransportar()
    {
        if (objetoParaMover == null) return;

        Camera cam = Camera.main;
        if (cam != null)
        {
            Vector3 novaPosicao = cam.transform.position + cam.transform.forward * distancia;
            objetoParaMover.transform.position = novaPosicao;

            // Se quiser que o objeto olhe para o jogador:
            objetoParaMover.transform.rotation = Quaternion.LookRotation(-cam.transform.forward);
        }
    }
}

using UnityEngine;

public class MoverObjetoXR : MonoBehaviour
{
    public float distancia = 2.0f;

    public void MoverParaFrenteDaCamera(GameObject objetoParaMover)
    {
        if (objetoParaMover == null) return;

        Camera camera = Camera.main;
        if (camera != null)
        {
            Vector3 novaPos = camera.transform.position + camera.transform.forward * distancia;
            objetoParaMover.transform.position = novaPos;

            // Faz o objeto olhar para o jogador (opcional)
            objetoParaMover.transform.rotation = Quaternion.LookRotation(-camera.transform.forward);

            // Zera movimento se tiver Rigidbody
            Rigidbody rb = objetoParaMover.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}

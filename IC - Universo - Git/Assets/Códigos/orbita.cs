using UnityEngine;

public class orbita : MonoBehaviour
{
    public Transform Target;
    public float velocidadeOrbita = 10f;
    public float velocidadeRotacao = 10f;
    
    void Update()
    {
        transform.RotateAround(Target.position, Vector3.up, velocidadeOrbita * Time.deltaTime);
        transform.Rotate(Vector3.up, velocidadeRotacao * Time.deltaTime);
    }
}

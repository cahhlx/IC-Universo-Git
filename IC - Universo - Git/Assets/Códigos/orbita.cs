using UnityEngine;

public class orbita : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public Transform Target;
    public float velocidadeOrbita = 10f;
    public float velocidadeRotacao = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.position, Vector3.up, velocidadeOrbita * Time.deltaTime);
        transform.Rotate(Vector3.up, velocidadeRotacao * Time.deltaTime);
    }
}

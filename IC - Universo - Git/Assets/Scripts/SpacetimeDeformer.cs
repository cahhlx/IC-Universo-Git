using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SpacetimeDeformer : MonoBehaviour
{
    public Transform mass;        // arraste a Sphere aqui
    public float massValue = 100; // quanto �pesa� (experimente 50-300)
    public float G = 1f;          // ajuste geral de profundidade
    public float softness = 1f;   // evita buraco infinito no centro

    Mesh mesh;
    Vector3[] baseVerts, workVerts;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        baseVerts = mesh.vertices;           // posi��o original de cada v�rtice
        workVerts = new Vector3[baseVerts.Length];
    }

    void Update()
    {
        // posi��o da massa no mesmo espa�o do plano
        Vector3 mp = transform.InverseTransformPoint(mass.position);

        for (int i = 0; i < baseVerts.Length; i++)
        {
            Vector3 v = baseVerts[i];
            // dist�ncia horizontal (x-z) at� a massa
            float r2 = (v.x - mp.x) * (v.x - mp.x) + (v.z - mp.z) * (v.z - mp.z);
            // f�rmula de �po�o gravitacional� simples
            float depth = -G * massValue / (r2 + softness);
            workVerts[i] = new Vector3(v.x, depth, v.z);
        }
        mesh.vertices = workVerts;
        mesh.RecalculateNormals();  // faz a luz acompanhar o relevo
    }
}

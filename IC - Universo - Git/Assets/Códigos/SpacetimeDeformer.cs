using UnityEngine;

[System.Serializable]
public class GravityMass
{
    public Transform transform;
    public float massValue = 100;
}

public class SpacetimeDeformer : MonoBehaviour
{
    public MeshFilter meshFilter;       // plano a ser deformado
    public GravityMass[] masses;        // lista de corpos com massa
    public float G = 1f;
    public float softness = 1f;

    Mesh mesh;
    Vector3[] baseVerts, workVerts;

    void Start()
    {
        if (meshFilter == null)
        {
            Debug.LogError("SpacetimeDeformer: meshFilter não atribuído!");
            return;
        }

        mesh = meshFilter.mesh;
        baseVerts = mesh.vertices;
        workVerts = new Vector3[baseVerts.Length];
    }

    void Update()
    {
        if (mesh == null || masses == null || masses.Length == 0) return;

        for (int i = 0; i < baseVerts.Length; i++)
        {
            Vector3 v = baseVerts[i];
            float totalDepth = 0f;

            foreach (GravityMass gm in masses)
            {
                if (gm.transform == null) continue;
                Vector3 mp = meshFilter.transform.InverseTransformPoint(gm.transform.position);
                float r2 = (v.x - mp.x) * (v.x - mp.x) + (v.z - mp.z) * (v.z - mp.z);
                totalDepth += -G * gm.massValue / (r2 + softness);
            }

            workVerts[i] = new Vector3(v.x, totalDepth, v.z);
        }

        mesh.vertices = workVerts;
        mesh.RecalculateNormals();
    }
}

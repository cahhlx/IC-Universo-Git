using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class PlaneGenerator : MonoBehaviour
{
    [SerializeField] int seg = 100;   // quantidade de divisões
    [SerializeField] float size = 10; // lado em metros

    void Awake()                          // roda ao dar Play
    {
        GetComponent<MeshFilter>().mesh = BuildGrid();
    }

    Mesh BuildGrid()
    {
        int n = seg + 1;                       // vértices por lado
        Vector3[] v = new Vector3[n * n];
        int[] tri = new int[seg * seg * 6];

        float step = size / seg, half = size / 2f;

        // --- vértices ---
        for (int z = 0, i = 0; z < n; z++)
            for (int x = 0; x < n; x++, i++)
                v[i] = new Vector3(x * step - half, 0, z * step - half);

        // --- triângulos ---
        for (int z = 0, t = 0, i = 0; z < seg; z++, i++)
            for (int x = 0; x < seg; x++, i++, t += 6)
            {
                tri[t] = i;
                tri[t + 1] = i + seg + 1;
                tri[t + 2] = i + 1;
                tri[t + 3] = i + 1;
                tri[t + 4] = i + seg + 1;
                tri[t + 5] = i + seg + 2;
            }

        Mesh m = new Mesh { name = "Grid" };
        m.vertices = v;
        m.triangles = tri;
        m.RecalculateNormals();
        return m;
    }
}

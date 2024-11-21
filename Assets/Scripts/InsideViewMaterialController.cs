using UnityEngine;

public class InsideViewMaterialController : MonoBehaviour
{
    private MeshFilter meshFilter;

    void Start()
    {
        // Get the MeshFilter component
        meshFilter = GetComponent<MeshFilter>();

        // Call the function to invert the triangles
        InvertMeshTriangles();
    }

    void InvertMeshTriangles()
    {
        // Get the mesh from the MeshFilter component
        Mesh mesh = meshFilter.mesh;

        // Get the triangle indices of the mesh
        int[] triangles = mesh.triangles;

        // Reverse the triangle indices
        for (int i = 0; i < triangles.Length; i += 3)
        {
            // Swap the indices of each triangle (inverting the winding order)
            int temp = triangles[i];
            triangles[i] = triangles[i + 2];
            triangles[i + 2] = temp;
        }

        // Set the modified triangle indices back into the mesh
        mesh.triangles = triangles;

        // Recalculate normals after modifying the triangles
        mesh.RecalculateNormals();
    }
}

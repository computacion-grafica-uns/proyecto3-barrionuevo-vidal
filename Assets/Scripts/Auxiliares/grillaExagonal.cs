using UnityEngine;

public class HexGridSpawner : MonoBehaviour
{
    public GameObject hexPrefab;     // Arrastrá acá tu prefab de hexágono
    public int rows = 5;
    public int columns = 5;
    public float hexRadius = 1f;
    public float minHeight = -10f;
    public float maxHeight = 0f;

    void Start()
    {
        float dx = Mathf.Sqrt(3) * hexRadius;
        float dz = 1.5f * hexRadius;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                float offset = (row % 2 == 0) ? 0 : dx / 2;
                float x = col * dx + offset;
                float y = Random.Range(minHeight, maxHeight);
                float z = row * dz;

                Vector3 pos = new Vector3(x, y, z);
                Instantiate(hexPrefab, pos, Quaternion.identity);
            }
        }
    }
}

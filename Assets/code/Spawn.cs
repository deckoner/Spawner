using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private SpawnManagerScriptableObject SpawnManager;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SpawnManager.numero; i++)
        {
            Instantiate(SpawnManager.objeto, new Vector2(i, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using Random = UnityEngine.Random;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private void Update()
    {
        var position = new Vector3(Random.Range(-4f, 4f), 3f, 1f);
        
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(_prefab);
            _prefab.transform.position = position;
        }
    }
}

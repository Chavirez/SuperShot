using UnityEngine;

public class Spawner : MonoBehaviour
{

    private Vector3 SpawnPos;
    public GameObject spawnObject;
    private float newSpawnDuration = 1.0f;
    public GameObject PC;

    #region

    public static Spawner Instance;

    private void Awake()
    {

        Instance = this;

    }

    #endregion

    private void Start()
    {

        SpawnPos = PC.transform.position;

    }

    private void Update()
    {

        SpawnPos = PC.transform.position;

    }
    void SpawnNewObject()
    {

        Instantiate(spawnObject, SpawnPos, Quaternion.identity);

    }

    public void NewSpawnRequest()
    {

        Invoke(methodName: "SpawnNewObject", newSpawnDuration);

    }
}

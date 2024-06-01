using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowInstancer : MonoBehaviour
{
    [SerializeField] private float voxelSize;
    [SerializeField] private GameObject snowParticle;
    [SerializeField] public Transform spawnPos;

    
    

    private void Awake()
    {
        int amount = (2 / voxelSize);
        int[,,] snowblock = new int[amount, amount, amount];
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PreparePool<BulletBehaviour>(Queue<BulletBehaviour> q, GameObject snowParticle, Transform spawn, uint amount)
    {
        q.Clear();
        for (int i = 0; i < amount; i++)
        {
            GameObject go = Instantiate(prefab, spawn.position, spawn.rotation);
            go.name = prefab.name + i.ToString();
            q.Enqueue(go.GetComponent<BulletBehaviour>());
            go.SetActive(false);
        }
    }
}

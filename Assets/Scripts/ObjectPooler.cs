using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPooler : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> objectPool = new List<GameObject>();
    [SerializeField]
    private GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject newObject = Instantiate(prefab);
            newObject.SetActive(false);
            objectPool.Add(newObject);
        }
    }

    public GameObject GetObjectFromPool()
    {
        if (objectPool.Count == 0)
        {
            return null;
        }
        GameObject obj = objectPool[0];
        objectPool.Remove(obj);
        return obj;
    }

    public void ReturnObjectToPool()
    {

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudmanager : MonoBehaviour
{
    public int amount;
    [SerializeField] GameObject cloud;

    [SerializeField] float[] mapSize = new float[4]; // x -x y -y
    [SerializeField] float[] sizeminmax = new float[4]; // x -x y -y
    [SerializeField] float[] yPos = new float[2];
    [SerializeField] float[] ySize = new float[2];
    public Vector3 forwards;

    List<GameObject> pool = new List<GameObject>();
    [SerializeField] int culammount;

    [SerializeField] float sizeLose;
    [SerializeField] float speed;

    void Start()
    {
        ResetClouds();
    }
    void Update()
    {
        for(int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].activeSelf)
            {
                continue;
            }
            pool[i].transform.position += forwards * Time.deltaTime * speed;
            if (pool[i].transform.localScale.x < 1 ||
                pool[i].transform.localScale.y < 1 ||
                pool[i].transform.localScale.z < 1)
            {
                RemoveCloud(pool[i]);
                continue;
            }
            pool[i].transform.localScale -= (Vector3.forward * Time.deltaTime + Vector3.right * Time.deltaTime) * sizeLose * speed;
        }
        for (int i = 0; i < 200; i++)
        {
            if (culammount < amount)
            {
                int x = Random.Range((int)mapSize[0], (int)mapSize[1]);
                int z = Random.Range((int)mapSize[2], (int)mapSize[3]);
                int y = Random.Range((int)yPos[0], (int)yPos[1]);

                int xS = Random.Range((int)sizeminmax[0], (int)sizeminmax[1]);
                int zS = Random.Range((int)sizeminmax[2], (int)sizeminmax[3]);
                int yS = Random.Range((int)ySize[0], (int)ySize[1]);

                InstateCloud(new Vector3(x, y, z), new Vector3(xS, yS, zS));
            }
            else
            {
                break;
            }
        }
    }

    void InstateCloud(Vector3 pos, Vector3 sizes)
    {
        culammount += 1;
        foreach (GameObject a in pool)
        {
            if (!a.activeSelf)
            {
                a.transform.position = pos;
                a.transform.localScale = sizes;
                a.SetActive(true);
                return;
            }
        }
        GameObject that = Instantiate(cloud, pos, Quaternion.identity);
        that.transform.localScale = sizes;
        that.transform.SetParent(transform);
        pool.Add(that);
    }
    void RemoveCloud(GameObject that)
    {
        culammount -= 1;
        that.SetActive(false);
    }
    void ResetClouds()
    {
        for(int i = 0; i < amount; i++)
        {
            int x = Random.Range((int)mapSize[0], (int)mapSize[1]);
            int z = Random.Range((int)mapSize[2], (int)mapSize[3]);
            int y = Random.Range((int)yPos[0], (int)yPos[1]);

            int xS = Random.Range((int)sizeminmax[0], (int)sizeminmax[1]);
            int zS = Random.Range((int)sizeminmax[2], (int)sizeminmax[3]);
            int yS = Random.Range((int)ySize[0], (int)ySize[1]);

            InstateCloud(new Vector3(x, y, z), new Vector3(xS, yS, zS));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> GuardPrefabs;
    public int GuardTotal = 30;

    private int SpawnedGuards = 0;

    private bool allKilled = false;

    void Start()
    {
        SpawnGuard(0, 20);
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            if (SpawnedGuards >= GuardTotal && !allKilled)
            {
                Debug.Log("SUCCESS");
                allKilled = true;
                StartCoroutine(LevelEnd());
            }

            if (!allKilled)
            {
                int groupSize = Random.Range(1, 4);
                int speed = Random.Range(15, 25);
                SpawnedGuards += groupSize;

                for (int i = 0; i < groupSize; i++)
                {
                    SpawnGuard(i * 1, speed);
                }
            }        
        }
    }

    private void SpawnGuard(float dist, float speed)
    {
        int guardColor = Random.Range(0, GuardPrefabs.Count);
        GameObject guard = Instantiate(GuardPrefabs[guardColor], this.transform);
        guard.transform.Translate(new Vector3(dist, 0, 0));
        guard.GetComponent<EnemyBehaviour_Level09>().Speed = speed;
    }

    IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(3);
        if (GameObject.Find("SceneLoader"))
        {
            GameObject.Find("SceneLoader").GetComponent<SceneLoader>().LoadNextScene();
        }
    }
}
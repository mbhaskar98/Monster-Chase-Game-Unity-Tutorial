using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedGameMonster;

    [SerializeField]
    private Transform leftPos, rightPos;
    // Start is called before the first frame update

    private int randomIndex;
    private int randomSide;
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    IEnumerator SpawnMonster()
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedGameMonster = Instantiate(monsterReference[randomIndex]);

            // left side
            if (randomSide == 0)
            {
                spawnedGameMonster.transform.position = leftPos.position;
                spawnedGameMonster.GetComponent<Monster>().speed = Random.Range(4, 10);
            }
            //right side
            else
            {
                spawnedGameMonster.transform.position = rightPos.position;
                spawnedGameMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);
                spawnedGameMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

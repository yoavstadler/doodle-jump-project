using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public Vector3 spawnPosition;
    public Vector3 coinSpawnPosition;
    public Vector3 enemyspawnPosition;
    public GameObject platformPrefab;
    public GameObject coinsPrefab;
    public GameObject destroyer;
    public Transform PlayerTransform;
    public  GameObject[] platforms1;
    public GameObject[] platforms2;
    public GameObject normalenemy;
    public GameObject[] enemys;
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            creatPlatform();
            
        }

        GetComponent<DestroyerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerTransform.position.y > spawnPosition.y - 15)
        {
            creatPlatform();
            creatcoins();
            createnemys();


        }

      
    }

    void creatPlatform()
    {
       if(destroyer.GetComponent<DestroyerScript>().DestroyedPlatformes <=15)
        {
            float randx = Random.Range(-3.3f, 3.3f);
            float randy = Random.Range(0.5f, 2);
            spawnPosition.x = randx;
            spawnPosition.y += randy;
            spawnPosition.z = -0.3f;
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        if (15 < destroyer.GetComponent<DestroyerScript>().DestroyedPlatformes && destroyer.GetComponent<DestroyerScript>().DestroyedPlatformes < 30) 
        {
            float randx = Random.Range(-3.3f, 3.3f);
            float randy = Random.Range(0.5f, 2);
            spawnPosition.x = randx;
            spawnPosition.y += randy;
            spawnPosition.z = -0.3f;
            int randomPlatform = Random.Range(0, platforms1.Length);
            Instantiate(platforms1[randomPlatform], spawnPosition, Quaternion.identity);
        }

        if(destroyer.GetComponent<DestroyerScript>().DestroyedPlatformes > 30)
        {
            float randx = Random.Range(-3.3f, 3.3f);
            float randy = Random.Range(0.5f, 2);
            spawnPosition.x = randx;
            spawnPosition.y += randy;
            spawnPosition.z = -0.3f;
            int randomPlatform = Random.Range(0, platforms2.Length);
            Instantiate(platforms2[randomPlatform], spawnPosition, Quaternion.identity);
        }
       
    }

    void creatcoins()
    {
        float randox = Random.Range(-3.3f, 3.3f);
        float randoy = Random.Range(4, 10);
        coinSpawnPosition.x = randox;
        coinSpawnPosition.y += randoy;
        coinSpawnPosition.z = -0.1f;
        Instantiate(coinsPrefab, coinSpawnPosition, Quaternion.identity);
    }

    void createnemys()
    {
      if (15 < destroyer.GetComponent<DestroyerScript>().DestroyedPlatformes && destroyer.GetComponent<DestroyerScript>().DestroyedPlatformes < 30)
        {
            float randomx = Random.Range(-3.3f, 3.3f);
            float randomy = Player.transform.position.y + Random.Range( 10, 15);
            enemyspawnPosition.x = randomx;
            enemyspawnPosition.y += randomy - Player.transform.position.y;
            enemyspawnPosition.z = -0.1f;
            Instantiate(normalenemy, enemyspawnPosition, Quaternion.identity);
        }
        if (30 < destroyer.GetComponent<DestroyerScript>().DestroyedPlatformes)
        {
            float randomx = Random.Range(-3.3f, 3.3f);
            float randomy = Random.Range( 10, 15);
            enemyspawnPosition.x = randomx;
            enemyspawnPosition.y += randomy;
            enemyspawnPosition.z = -0.1f;
            int randomEnemy = Random.Range(0, enemys.Length);
            Instantiate(enemys[randomEnemy], enemyspawnPosition, Quaternion.identity);
        }
    }
}

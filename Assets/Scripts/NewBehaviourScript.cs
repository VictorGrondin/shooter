using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class apparition_asteroid : MonoBehaviour
{
    public GameObject asteroid;

    public Vector3 randomPos;//apparition random des asteroids

    public float debut_spawn;
    public float delai_creation_groupe;
    public float delai_entre_astreroid;

    bool gameovercontrol = false;
    bool restart = false;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))//si la touche R est actif on reload la game 
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    IEnumerator random_create()
    {
        yield return new WaitForSeconds(debut_spawn); // on fait spawn les asteroid aleatoire sur le meme axe celui Y
        while (true) {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.y, randomPos.y), 0, randomPos.x);
                Instantiate(asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(delai_entre_astreroid);
            }
            if (gameovercontrol)
            {
                restart = true; //si on restart la game on supprime les asteroids 
                break;

            }
            yield return new WaitForSeconds(delai_creation_groupe);

        
        }
        
    
    }
    
    
}

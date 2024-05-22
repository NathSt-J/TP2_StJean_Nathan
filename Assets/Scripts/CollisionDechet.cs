using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDechet : MonoBehaviour
{

    [SerializeField] private InfosJoueur _infosJoueur;

    private int inventaire;


    void Update()
    {
        if(_infosJoueur.nbPoints == 10){
            SceneManager.LoadScene("Fin");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dechet" && inventaire == 0){
            Destroy(other.gameObject);
            inventaire++;

            Debug.Log("J'ai " + inventaire + " cannette dans mon inventaire!");
        }

        if(other.gameObject.tag == "Poubelle" && inventaire >= 1){
            
            _infosJoueur.nbPoints++;
            inventaire = 0;

            Debug.Log("J'ai " + _infosJoueur.nbPoints + " point(s)!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttaqueMonstre : MonoBehaviour
{

    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private GameObject[] _vies;
    private int _compteurVies = 2;


    void Update()
    {
        if(_infosJoueur.nbVies == 0){
            SceneManager.LoadScene("Fin");
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Monstre")){
            _infosJoueur.nbVies -=1;
            _vies[_compteurVies].SetActive(false);
            _compteurVies -=1;
            Debug.Log("J'ai " + _infosJoueur.nbVies + " vies.");
        }
    }
}
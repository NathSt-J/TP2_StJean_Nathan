using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GestionAccueil : MonoBehaviour
{

    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private InfosNiveau _infosNiveau;

    [SerializeField] private TMP_InputField _nomJoueur;
    [SerializeField] private TMP_InputField _nomParc;


    public void VerifierNoms()
    {
        if(_nomJoueur.text != "" && _nomParc.text != "")
        {
            _infosJoueur.nomJoueur = _nomJoueur.text;
            _infosNiveau.nomParc = _nomParc.text;
            SceneManager.LoadScene("Niveau");
        }
    }
}

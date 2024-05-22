using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{

    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private TMP_Text _scoreFinal;

    void Start()
    {
        _scoreFinal.text = _infosJoueur.nbPoints.ToString();
    }

    public void Rejouer()
    {
        SceneManager.LoadScene("Accueil");
    }
}

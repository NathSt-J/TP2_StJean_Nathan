using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionNiveau : MonoBehaviour
{

    [Header("Informations du joueur")]
    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private TMP_Text _nomDuJoueur;
    [SerializeField] private TMP_Text _compteurPoints;

    [Space]

    [Header("Informations du niveau")]
    [SerializeField] private InfosNiveau _infos;
    [SerializeField] private TMP_Text _nomDuParc;
    



    void Start()
    {
        _nomDuJoueur.text = _infosJoueur.nomJoueur;


        _nomDuParc.text = _infos.nomParc;
    }

    void Update()
    {
        _compteurPoints.text = _infosJoueur.nbPoints.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionNiveau : MonoBehaviour
{

    [SerializeField] private InfosJoueur _infosJoueur;
    [SerializeField] private TMP_Text _nomJoueur;
    [SerializeField] private TMP_Text _nomParc;

    // Start is called before the first frame update
    void Start()
    {
        _nomJoueur.text = _infosJoueur.nomJoueur;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField] public float _tempsRestant;
    [SerializeField] private TMP_Text _tempsText;


    void Update()
    {
        CalculTemps();
        TempsEcoule();
    }

    private void CalculTemps(){
        _tempsRestant -= Time.deltaTime;
        AfficheTemps(_tempsRestant);
    }

    private void AfficheTemps(float temps)
    {
        temps +=1;

        float minutes = Mathf.FloorToInt(temps/60);
        float secondes = Mathf.FloorToInt(temps % 60);

        _tempsText.text = string.Format("{0:00}:{1:00}", minutes, secondes);
    }

    private void TempsEcoule(){
        if(_tempsRestant < 0){
            SceneManager.LoadScene("Fin");
        }
    }
}

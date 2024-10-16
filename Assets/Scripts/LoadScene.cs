using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void ChargementChambre(){
        SceneManager.LoadScene("Chambre");
    }
    public void ChargementSalleDeBain(){
        SceneManager.LoadScene("Salle de bain");
    }
    public void ChargementSalon(){
        SceneManager.LoadScene("Salon");
    }
}

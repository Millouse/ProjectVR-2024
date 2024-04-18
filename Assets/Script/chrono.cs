using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Chrono : MonoBehaviour
{
    private float tempsInitial = 30f; // Temps initial en secondes (5 minutes)
    private float tempsRestant; // Temps restant en secondes
    private bool estEnCours = false; // Indique si le chrono est en cours
    private Text chronoText; // Référence au texte à mettre à jour

    void Start()
    {
        chronoText = GetComponent<Text>(); // Obtient le composant Text attaché à cet objet
        tempsRestant = tempsInitial;
        MiseAJourTexteChrono();
        DemarrerChrono(); // Démarre le chrono dès le début
    }

    void Update()
    {
        if (estEnCours)
        {
            tempsRestant -= Time.deltaTime;
            if (tempsRestant <= 0)
            {
                tempsRestant = 0;
                estEnCours = false;
                StartCoroutine(AfficherFinDePartieEtRelancerScene());
            }
            else
            {
                MiseAJourTexteChrono();
            }
        }
    }

    // Méthode pour démarrer le chrono
    public void DemarrerChrono()
    {
        estEnCours = true;
    }

    // Méthode pour mettre en pause le chrono
    public void PauseChrono()
    {
        estEnCours = false;
    }

    // Méthode pour réinitialiser le chrono
    public void ReinitialiserChrono()
    {
        tempsRestant = tempsInitial;
        estEnCours = false;
        MiseAJourTexteChrono();
    }

    // Méthode pour mettre à jour le texte du chrono
    private void MiseAJourTexteChrono()
    {
        int minutes = Mathf.FloorToInt(tempsRestant / 60f);
        int secondes = Mathf.FloorToInt(tempsRestant % 60f);
        chronoText.text = string.Format("{0:00}:{1:00}", minutes, secondes);
    }

    // Coroutine pour afficher "Fin de partie" et relancer la scène après un certain temps
    private IEnumerator AfficherFinDePartieEtRelancerScene()
    {
        chronoText.text = "Fin de partie";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Principal_Menu");
    }
}

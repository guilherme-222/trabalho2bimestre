using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panelConfiguracoes, panelCreditos, panelExtras;

    public void NovaPartida()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void AbrirConfiguracoes()
    {
        panelConfiguracoes.SetActive(true);
    }

    public void AbrirCreditos()
    {
        panelCreditos.SetActive(true);
    }

    public void AbrirExtras()
    {
        panelExtras.SetActive(true);
    }

    public void FecharPainel(GameObject painel)
    {
        painel.SetActive(false);
    }
}
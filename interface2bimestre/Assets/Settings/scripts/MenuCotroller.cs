using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void AbrirConfiguracoes()
    {
        Debug.Log("Abrindo Configurações..."); // Aqui você pode abrir um painel
    }

    public void AbrirCreditos()
    {
        Debug.Log("Abrindo Créditos...");
    }

    public void AbrirExtras()
    {
        Debug.Log("Abrindo Extras...");
    }
}


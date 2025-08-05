using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int vidas = 3;
    public float energia = 100f;

    public Slider barraVidas;
    public Slider barraEnergia;

    void Start()
    {
        AtualizarUI();
    }

    void Update()
    {
        // Exemplo para testes (diminuindo energia com o tempo)
        energia -= Time.deltaTime * 5;
        if (energia < 0) energia = 0;

        AtualizarUI();
    }

    void AtualizarUI()
    {
        if (barraVidas != null)
            barraVidas.value = vidas;

        if (barraEnergia != null)
            barraEnergia.value = energia;
    }
}

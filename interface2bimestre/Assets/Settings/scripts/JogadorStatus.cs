using UnityEngine;
using UnityEngine.UI;

public class JogadorStatus : MonoBehaviour
{
    public int vidas = 3;
    public float energia = 100f;

    public Slider barraVidas;
    public Slider barraEnergia;

    void Start()
    {
        barraVidas.maxValue = vidas;
        barraVidas.value = vidas;

        barraEnergia.maxValue = 100f;
        barraEnergia.value = energia;
    }

    void Update()
    {
        // Atualização contínua (se necessário)
        barraVidas.value = vidas;
        barraEnergia.value = energia;
    }

    // Simulação de perda de energia
    public void ReceberDano(float dano)
    {
        energia -= dano;
        if (energia < 0)
        {
            vidas--;
            energia = 100f;
        }
    }
}
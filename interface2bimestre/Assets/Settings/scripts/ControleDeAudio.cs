using UnityEngine.Audio;
using UnityEngine.rendering;
using UnityEngine;
using UnityEngine.UI;


public class ControleDeAudio : MonoBehaviour
{
 public int VolumeSFX;
 public int Volume;
 public bool musica;
 public TMP_Text textoMusica;

 public Slider volume;
 public Slider volumeSFX;
 public Toggle togglemusica;
 
   
    void Start()
    {
        musica = togglemusica.isOn;
        Volume = (int)volumeSlider.value;
        VolumeSFX = (int)volumeSFXSlider.value;
    }

 
    void Update()
    {
         musica = togglemusica.isOn;
        Volume = (int)volumeSlider.value;
        VolumeSFX = (int)volumeSFXSlider.value;

        if (musica == true)
        {
            textoMusica.text = "Ligado";
            textoMusica.color = Color.green;
        }

        else
        {
             textoMusica.text = "Desligado";
            textoMusica.color = Color.red;
        }

    }
}

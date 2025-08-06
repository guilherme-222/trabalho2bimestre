using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
 public int VolumeSFX;
 public int Volume;
 public bool musica;
 public TPM_Text textoMusica;


 public Slider volume;
 public Slider volumeSFX;
 public Toggle toggleMusica;
 
   
    void Start()
    {
        musica = toggleMusica.isOn;
        Volume = (int)volumeSlider.value;
        VolumeSFX = (int)volumeSFXSlider.value;
    }


 
    void Update()
    {
         musica = toggleMusica.isOn;
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


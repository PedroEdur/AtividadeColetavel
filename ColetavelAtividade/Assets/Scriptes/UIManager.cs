using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPontuacao;

    void Update()
    {
        textoPontuacao.text = "Pontuação: " + GameManager.pontuacao;
    }
}

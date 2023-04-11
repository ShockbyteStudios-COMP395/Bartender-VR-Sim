using UnityEngine;
using TMPro;

public class IngredientPopup : MonoBehaviour
{
    public TextMeshProUGUI textMeshProElement; // The TextMeshPro element in the UI that we want to activate

    public void Activate()
    {
        textMeshProElement.gameObject.SetActive(true); // Activate the TextMeshPro element
    }

    public void Deactivate()
    {
        textMeshProElement.gameObject.SetActive(false); // Activate the TextMeshPro element
    }
}

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageHandler : MonoBehaviour
{
    private Image imageComponent;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public void UpdateImageComponent(float amt)
    {
        imageComponent.fillAmount += amt;
    }

    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
    
}

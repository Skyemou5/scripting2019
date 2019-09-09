using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imgComp;
    private void Start()
    {
        imgComp = GetComponent<Image>();
    }
    
    public void UpdateImageComponent(float amt)
    {
        imgComp.fillAmount += amt;
    }

    public void UpdateImageComponent(FloatData dataObj)
    {
        imgComp.fillAmount = dataObj.value;
    }

    
}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imgComp;
    public UnityEvent updateImageEvent;
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

    private void Update()
    {
        updateImageEvent.Invoke();
    }
}

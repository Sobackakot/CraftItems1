using TMPro;
using UnityEngine; 

public class ShowNameObject : MonoBehaviour
{   
    public static ShowNameObject InstanceNameObject { get; private set; }
    public GameObject showName;
    [SerializeField] private TextMeshProUGUI itemName;
    
    public void Awake()
    {
        InstanceNameObject = this;
    } 
    public void ShowItemName(string nameItem)
    {
        showName.gameObject.SetActive(true);
        itemName.text = nameItem;
    }
    public void OffOnText()
    {
        showName.gameObject.SetActive(false);
    }
}

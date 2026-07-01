using UnityEngine;

//CustomerSoul
public class CustomerSoul : MonoBehaviour
{
    public string m_customerName;
    public CatPersonality m_preferredCatPersonality;
    public CatPersonality m_dislikedCatPersonality;


    public float m_patience;
    public int m_happiness;
    public bool m_matched = false;

    private void OnMouseDown()
    {
        //MatchingSystem.Instance.SelectCustomer(this);
    }

}

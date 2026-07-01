using TMPro;
using Unity.VisualScripting;
using UnityEngine;

// MatchingSystem
// player matches a cat with a customer 
public class MatchingSystem : MonoBehaviour
{
    public static MatchingSystem m_instance;

    public CustomerSoul m_selectedCustomer;
    public CatSoul m_selectedCat;

    public TMP_Text m_resultText;

    private void Awake()
    {
        m_instance = this;
    }

    public void SelectCat(CatSoul _cat)
    {
        m_selectedCat = _cat;
        m_resultText.text = "Selected cat: " + _cat.name;

    }

    public void SelectCustomer(CustomerSoul _customer)
    {
        m_selectedCustomer = _customer;
        m_resultText.text = "Selected customer: " + _customer.name;
    }

    public void TryMatchCatWithCustomer(CustomerSoul _customer, CatSoul _cat)
    {
        if (m_selectedCat == null || m_selectedCustomer == null)
        {
            m_resultText.text = "Select a customer and a cat to match.";
            return;
        }
        if (_customer.m_preferredCatPersonality == _cat.m_catPersonality)
        {
            _cat.m_catHappiness += 10;
            _customer.m_happiness += 10;
        }
        else
        {
            _customer.m_patience -= 20;
        }
    }
}

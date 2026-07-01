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

    public void TryMatchCatWithCustomer()
    {
        if (m_selectedCat == null || m_selectedCustomer == null)
        {
            m_resultText.text = "Select a customer and a cat to match.";
            return;
        }
        if (m_selectedCat.m_catPersonality == m_selectedCustomer.m_preferredCatPersonality)
        {
            m_selectedCat.m_catHappiness += 10;
            m_selectedCustomer.m_happiness += 10;
            m_resultText.text = m_selectedCustomer.m_customerName + " and " + m_selectedCat.m_catName + " are a great match!";
        }
        else
        {
            m_selectedCustomer.m_patience -= 20;
            m_resultText.text = m_selectedCustomer.m_customerName + " and " + m_selectedCat.m_catName + " don't seem to connect...";
        }
    }
}

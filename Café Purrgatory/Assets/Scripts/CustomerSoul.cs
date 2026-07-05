using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

//CustomerSoul
public class CustomerSoul : MonoBehaviour
{
    public string m_customerName;
    public CatPersonality m_preferredCatPersonality;
    public CatPersonality m_dislikedCatPersonality;

    public TableManager m_currentTable;

    public float m_patience;
    public int m_happiness;
    public bool m_matched = false;

    private void OnMouseDown()
    {
        //MatchingSystem.Instance.SelectCustomer(this);
    }

    public void SitAtTable(TableManager _table)
    {
        m_currentTable = _table;
        _table.m_occupied = true;

        Debug.Log("Customer BEFORE: " + transform.position);
        Debug.Log("SeatPoint: " + _table.m_seatPoint.position);

        transform.position = _table.m_seatPoint.position;
        Debug.Log("Customer sat at " + _table.name);
        Debug.Log("Customer AFTER: " + transform.position);
    }

}

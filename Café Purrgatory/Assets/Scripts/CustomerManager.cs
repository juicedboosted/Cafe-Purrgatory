using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    //spawn customer
    //queue
    //seating

    public TableManager m_currentTable;

    public CustomerSoul m_customerPrefab;

    public Transform m_door;

    public TableManager[] m_tables;

    public void SpawnCustomer()
    {
        CustomerSoul customer = Instantiate(m_customerPrefab, m_door.position, Quaternion.identity);
        foreach (TableManager table in m_tables)
        {
            if (!table.m_occupied)
            {
                SitAtTable(table);
                return;
            }
        }
    }

    public void SitAtTable(TableManager _table)
    {
        m_currentTable = _table;
        transform.position = _table.m_seatPoint.position;
        _table.m_occupied = true;
    }
}

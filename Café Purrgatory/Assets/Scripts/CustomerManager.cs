using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    //spawn customer
    //queue
    //seating

    public CustomerSoul m_customerPrefab;
    public Transform m_door;
    public TableManager[] m_tables;

    public void SpawnCustomer()
    {
        CustomerSoul customer = Instantiate(m_customerPrefab, m_door.position, Quaternion.identity);
        foreach (TableManager table in m_tables)
        {
            if (table == null)
            {
                Debug.Log("Table slot is empty");
            }

            if (table.m_seatPoint == null)
            {
                Debug.Log(table.name + " has no SeatPoint");
            }

            if (!table.m_occupied)
            {
                Debug.Log("Customer sitting at " + table.name);
                customer.SitAtTable(table);
                return;
            }
        }
        Debug.Log("No free table found");
    }
}

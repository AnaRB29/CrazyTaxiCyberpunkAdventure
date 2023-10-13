using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ClientSoawn : MonoBehaviour
{
    public GameObject cliente;
    public GameObject objective;
    private GameObject _newCliente;
    private GameObject _newObjective;
    public GameObject player;
    public List<Vector3> positions;
    public List<Vector3> objectives;

    private void Start()
    {
        SpawnClient();
        SpawnObjective();
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, _newObjective.transform.position) <= 5)
        {
            Debug.Log("FRENA");
            
            if (player.GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                Debug.Log("Objectivo alcanzado");
                
            }
        }
        
        if (Vector3.Distance(player.transform.position, _newCliente.transform.position) <= 5)
        {
            Debug.Log("FRENA");
            
            if (player.GetComponent<Rigidbody>().velocity == Vector3.zero)
            {
                _newCliente.transform.position = Vector3.MoveTowards(_newCliente.transform.position,player.transform.position,.01f);
                

            }
        }
    }


    private void SpawnClient()
    {
        int indexC = Random.Range(0, positions.Count);
        _newCliente = Instantiate(cliente, positions[indexC], Quaternion.identity);
        
    }

    private void SpawnObjective()
    {
        int indexO = Random.Range(0, objectives.Count);
        _newObjective = Instantiate(objective, positions[indexO], Quaternion.identity);
    }
    
}

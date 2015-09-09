using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstanciarPontos : MonoBehaviour {

    [SerializeField]
    int numerodeLinhas, numerodeColunas;
    [SerializeField]
    GameObject ponto;

    
    public List<GameObject> pontos;

    [SerializeField]
    private float deltaY, deltaX;

    private Vector3 posicao;
    private float x, y;
    // Use this for initialization
	void Start () {
        pontos = new List<GameObject>();
        x = -10.28f;
        y = 6.0f;
        Instanciar();
    }

    void Instanciar()
    {
        GameObject _ponto;
        for (int i = 0; i < numerodeLinhas; i++)
        {
            x = x + deltaX;
            y = 6.0f;
            for (int j = 0; j < numerodeColunas; j++)
            {
                y = y + deltaY;
                posicao = new Vector3(x, y, 0);
                _ponto = GameObject.Instantiate(ponto, posicao, transform.rotation) as GameObject;
                _ponto.name = "ponto " + i.ToString() + "-" + j.ToString();
                pontos.Add(_ponto);
            }
        }
            
    }
}

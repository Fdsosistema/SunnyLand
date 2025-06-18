using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public TMP_Text Point_Text;
    int p = 0;
    public ParticleSystem efeito;
    private void OnTriggerEnter2D(Collider2D verificar)
    {
        if (verificar.CompareTag("Player"))
        {
            Debug.Log("foi");
            p++;
            Point_Text.text = "Pontos: "+ p.ToString();
            verificar.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
        }
    }
}

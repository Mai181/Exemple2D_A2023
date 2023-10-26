using UnityEngine;

public class Ennemi : MonoBehaviour
{
    [SerializeField] private float _vitesseEnnemi = 5f;

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _vitesseEnnemi);

        // Si sort de l'écran replacer dans haut aléatoirement
        if (transform.position.y <= -6f)
        {
            float valeurAleatoire = Random.Range(-9f, 9f);
            transform.position = new Vector3(valeurAleatoire, 8f, 0f); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Laser")
        {
            // Actions pour collision avec laser
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            // Actions pour collision avec le joueur
            Destroy(this.gameObject);
            // Réduire la vie du joueur
        }
    }
}

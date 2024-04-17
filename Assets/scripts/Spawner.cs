using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objetoPrefab; // El prefab del objeto que quieres instanciar
    public float tiempoMinimo = 3f; // Tiempo m�nimo entre instancias
    public float tiempoMaximo = 5f; // Tiempo m�ximo entre instancias

    private void Start()
    {
        // Llamar al m�todo de instancia de objetos con un retardo inicial y luego repetirlo en intervalos aleatorios
        Invoke("InstanciarObjeto", Random.Range(tiempoMinimo, tiempoMaximo));
    }

    private void InstanciarObjeto()
    {
        // Instanciar el objeto prefab en la posici�n del spawner
        Instantiate(objetoPrefab, transform.position, Quaternion.identity);

        // Llamar de nuevo al m�todo de instancia de objetos en un intervalo aleatorio
        Invoke("InstanciarObjeto", Random.Range(tiempoMinimo, tiempoMaximo));
    }
}

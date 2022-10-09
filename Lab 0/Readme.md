# Práctica 0
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%200/Demostracion%20ejecucion.gif)

Como se puede observar en el gif, en esta práctica cumplí con los requisitos solicitados de la siguiente manera:
- Añadí objetos 3D básicos (cilindro y esfera)
- Generé un terreno y lo modifiqué, añadientole texturas descargadas desde la assets store de unity
- Adicionalmente, añadí elementos libres de la sset store como vegetacion del terreno y Una piedra con texturas realistas
- Incluí el paquete starter Assets y emplee unos muros como prefabs para encerrar el terreno
- Todos los objetos que aparecen en escena fueron tageados individualmente
- Y, finalmente, hice un script muy simple que obtiene todos los objetos de una escena y los imprime por consola:
```c#
    void Start()
    {
        Object[] objetos = GameObject.FindObjectsOfType((typeof(GameObject)));
        foreach (Object objeto in objetos)
        {
            Debug.Log(objeto);
        }
    }
```

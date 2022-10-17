1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.
- A. Ninguno de los objetos será físico: Ambos objetos se quedan flotando
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif1.gif)
- B. La esfera tiene físicas, el cubo no: La esfera cae por la gravedad sobre el cubo y se queda ahí estático (tenga o no rigidbody el cubo), el cubo flota al no tener físicas
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif2.gif)
- C. La esfera y el cubo tienen físicas: Ambos caen, quedandose la esfera sobre el cubo apoyado en el suelo.
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif3.gif)
- D. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo: cae más rápida la esfera, rebota un poco y con ese movimiento, comienza a rodar cayendose del cubo hacia el plano
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif4.gif)
- E. La esfera tiene físicas y el cubo es de tipo IsTrigger: la esfera cae normal y atraviesa el cubo que se queda estático.
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif5.gif)
- F. La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas: La esfera cae normal y el cubo cae atravesando el plano del suelo hacia el infinito
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif6.gif)
- G. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ: Poniendo el cubo sobre la esfera, ambos caen, se queda el cubo sobre la esfera estático, sin resbalarse y caer sobre la superficie de la esfera
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif7.gif)

2. Sobre la escena que has trabajado ubica un cubo que represente un personaje que vas a mover. Se debe implementar un script que haga de CharacterController. Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en la dirección que estos ejes indican.
- Crear un script para el personaje que lo desplace por la pantalla, sin aplicar simulación física.
- Agregar un campo público que permita graduar la velocidad del movimiento desde el inspector de objetos.
- Estar a la escucha de si el usuario ha utilizado los ejes virtuales. Elegir cuáles se va a permitir utilizar: flechas, awsd.
- El recorrido virtual realizado con los contraladores (teclas) debe ser proporcional a lo que se desplaza el jugador:Elegir otros ejes virtuales para el giro y girar al jugador sobre el eje OY (up) 
  + Versión 1: implementada usando un eje virtual creado usando el input manager para girar sobre el eje Y usando las teclas Q y E del teclado
  ![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif8.1.gif)
  + Versión 2: implementada usando eje virtual Mouse X y Mouse Y del raton para hacer giros sobre eje X y eje Y
  ![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif8.2.gif)

3. Sobre la escena que has trabajado programa los scripts necesarios para las siguientes acciones:
- Se deben incluir varios cilindros sobre la escena. Cada vez que el objeto jugador colisione con alguno de ellos, deben aumentar su tamaño y el jugador aumentar puntuación.
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif9.gif)
- Agregar cilindros de tipo A, en los que además, si el jugador pulsa la barra espaciadora lo mueve hacia fuera de él. 
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif10.gif)
- Se deben incluir cilindros que se alejen del jugador cuando esté próximo.
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif11.gif)
- Ubicar un tercer objeto que sea capaz de detectar colisiones y que se mueva con las teclas: I, L, J, M
- Debes ubicar cubos que que aumentan de tamaño cuando se le acerca una esfera y que disminuye cuando se le acerca el jugador.
![Alt Text](https://github.com/alu0101325583/Interfaces-Inteligentes/blob/main/Lab%201/Gifs/P1-Gif12.gif)


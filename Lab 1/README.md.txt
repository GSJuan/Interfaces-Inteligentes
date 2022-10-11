1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.
- A. Ninguno de los objetos será físico: Ambos objetos se quedan flotando
- B. La esfera tiene físicas, el cubo no: La esfera cae por la gravedad sobre el cubo y se queda ahí estático (tenga o no rigidbody el cubo), el cubo flota al no tener físicas
- C. La esfera y el cubo tienen físicas: Ambos caen, quedandose la esfera sobre el cubo apoyado en el suelo.
- D. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo: cae más rápida la esfera, rebota un poco y con ese movimiento, comienza a rodar cayendose del cubo hacia el plano
- E. La esfera tiene físicas y el cubo es de tipo IsTrigger: la esfera cae normal y atraviesa el cubo que se queda estático.
- F. La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas: La esfera cae normal y el cubo cae atravesando el plano del suelo hacia el infinito
- G. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ: Poniendo el cubo sobre la esfera, ambos caen, se queda el cubo sobre la esfera estático, sin resbalarse y caer sobre la superficie de la esfera
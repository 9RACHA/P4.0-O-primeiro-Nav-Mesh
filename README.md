# P4.0 O primeiro Nav Mesh
Crea un labirinto sobre un plano, con distintas partes que inclúan plataformascon distintas alturas, escadas, saltos entre plataformas a distintas distancias e caídas. A idea é testar os distintos elementos que se poden configurar no Navmesh. Crea o navmesh, revisando as areas walkable, non walkable e inclúe unha nova área chamada hard que teña mais dificultade de avance (resalta isso con algunha cor ou elemento visible). 

Logo de probar as características principais do Nav Mesh, realiata tamén estas tarefas:

1.Crea tamén un offmesh-link entre dous puntos distantes.

2.Crea un axente de Navmesh (un cilindro) e asígnalle o tipo Humanoide. Fai que o axente se dirixa ao punto que lle marcas no xogo (Target).

3.Crea un segundo axente de Navmesh (cápsula doutra cor) e asígnalle o tipo humanoide, fai que persiga o axente1. 

4.Crea un obstáculo (Nav Mesh Obstacle) que se mova e peche o paso temporalmente. Podes consultar o código no exemplo proporcionado polo profesor. https://docs.unity3d.com/2021.3/Documentation/Manual/nav-CreateNavMeshObstacle.html

5.Fai que o destino do axente sexa definido ao clickar nunha parte do mapa. https://docs.unity3d.com/2021.3/Documentation/Manual/nav-MoveToClickPoint.html

6.Crea un terceriro axente que esté patruyando entre polo menos 3 puntos.  https://docs.unity3d.com/2021.3/Documentation/Manual/nav-AgentPatrol.html

Entregable:

O script ou scripts relevantes

Un pequeno informe cun par de capturas que demostren que o xogo funciona e coas explicacións que consideres axeitadas

O enderezo de github que contén o proxecto

## Informe

Agregar la pestaña Navigation : En el menu -> Window -> AI -> Navigation

Marcar en Static el objeto vacio padre llamado NavMesh que incluira a los objetos hijos del diseño de nivel y que los marcará en static también ![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/203c6c23-0f6c-43f3-8432-c68fe7349fcb)

![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/4254def8-2881-44af-95ef-07337f1af436) Static hijo marcado

Para crear el NavMesh pulsaremos en Bake
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/96dc6c45-3136-408a-959d-f7cb6147aa6e)

El NavMesh se creará automaticamente dependiendo de las caracteristicas del Agente
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/8c777b5a-7e8d-4b22-9624-dfa505e5286a)

Tambien es necesario añadir el paquete ![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/9d68df19-ea59-44e0-bf2d-241627fca040)
Poniendo en añadir como nombre -> com.unity.ai.navigation

El unico Area no caminable sera el puente negro ![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/e5851f54-93c6-4780-9df3-5a5b3cf8a26b)

Por defecto Not Walkable ya esta definido ![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/05745a37-4240-46d8-be55-b3f370288089)

El puente negro con cubos amarillos sera dificil de caminar ![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/c79372d0-b479-4ca2-a9c0-ebe8c8058b24)
Se le asigna una dificultad de 2, ya que sera más costoso que el Agente pase por aqui.

Se le asigna el area ![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/9e432921-2557-4fb0-a186-f0b35f76f932)









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

1.Crea tamén un offmesh-link entre dous puntos distantes.
OffMesh-Link: entre 2 puntos distantes. Esta asignado el componente de entrada el puente de la derecha y de salida el de la izquierda pero tambien esta marcada la casilla bidirecional por tanto podria cambiar el orden e ir hacia los 2 puntos sin tener una entrada ni salida fijas
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/1a0d07c1-d838-4ba3-8701-7fd098621942)

![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/42c2fda8-6d35-430c-879c-e67e024f02fc)

2.Crea un axente de Navmesh (un cilindro) e asígnalle o tipo Humanoide. Fai que o axente se dirixa ao punto que lle marcas no xogo (Target).
Componentes del NavmeshAgent
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/63c75e87-bbcf-4eab-9d39-1e0254eb54dc)

El script MoveTo de la documentacion
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/3f285455-7600-4d5c-a1a1-11b013be4623)

Prefab NavMeshAgent
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/7dc00c12-125f-4d9c-9e94-9d083fc078bb)

Agente Humanoide
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/1d0f4c10-750b-4165-8753-57c97ad1e51d)

3.Crea un segundo axente de Navmesh (cápsula doutra cor) e asígnalle o tipo humanoide, fai que persiga o axente1
Componentes del inspector
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/e3c89102-618f-49dc-97a6-945b14dc276e)

Prefab NavMeshAgentePerseguidor
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/c78a8594-4bba-4963-96c9-43c824424ea4)
Humanoide
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/d5aeb1d2-9011-4699-a426-f32699313218)

Script Agent muy parecido al anterior de MoveTo pero este actualizara constantemente la posicion al tener el destino en el Update
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/dd85785c-bcc8-4057-835a-48ef07b2e86d)

4.Crea un obstáculo (Nav Mesh Obstacle) que se mova e peche o paso temporalmente.
Eliminar o deseleccionar static, añadir el componente NavMeshObstacle y el Script correspondiente 
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/4bd0ed1e-6732-49da-97b5-d81734db2c54)
![image](https://github.com/9RACHA/P4.0-O-primeiro-Nav-Mesh/assets/66274956/3b7ead04-0820-4030-b814-a925c4e99fba)

5.Fai que o destino do axente sexa definido ao clickar nunha parte do mapa
Revisar El prefab level















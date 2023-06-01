# P4.0 O primeiro Nav Mesh
Crea un labirinto sobre un plano, con distintas partes que inclúan plataformascon distintas alturas, escadas, saltos entre plataformas a distintas distancias e caídas. A idea é testar os distintos elementos que se poden configurar no Navmesh. Crea o navmesh, revisando as areas walkable, non walkable e inclúe unha nova área chamada hard que teña mais dificultade de avance (resalta isso con algunha cor ou elemento visible). 

Logo de probar as características principais do Nav Mesh, realiata tamén estas tarefas:

Crea tamén un offmesh-link entre dous puntos distantes.
Crea un axente de Navmesh (un cilindro) e asígnalle o tipo Humanoide. Fai que o axente se dirixa ao punto que lle marcas no xogo (Target).
Crea un segundo axente de Navmesh (cápsula doutra cor) e asígnalle o tipo humanoide, fai que persiga o axente1. 
Crea un obstáculo (Nav Mesh Obstacle) que se mova e peche o paso temporalmente. Podes consultar o código no exemplo proporcionado polo profesor. https://docs.unity3d.com/2021.3/Documentation/Manual/nav-CreateNavMeshObstacle.html
Fai que o destino do axente sexa definido ao clickar nunha parte do mapa. https://docs.unity3d.com/2021.3/Documentation/Manual/nav-MoveToClickPoint.html
Crea un terceriro axente que esté patruyando entre polo menos 3 puntos.  https://docs.unity3d.com/2021.3/Documentation/Manual/nav-AgentPatrol.html

Entregable:

O script ou scripts relevantes
Un pequeno informe cun par de capturas que demostren que o xogo funciona e coas explicacións que consideres axeitadas
O enderezo de github que contén o proxecto

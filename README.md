# Unity
Unity Übungsaufgaben als Teil der Lehrveranstaltung "Entwicklung von Multimediasystemen" im SoSe 2020 , HTW Berlin

## Abgabe 00

#### Teil 1
* erzeugen Sie eine Szene in Unity
* erzeugen Sie einen Würfel und fügen Sie diesem einen Rigidbody hinzu, deaktivieren Sie die Gravitation im Rigidbody
* schreiben Sie ein Skript, das den Würfel mithilfe des transform-Attributes entlang der Z-Achse vor und zurück schiebt

#### Teil 2
* Erzeugen Sie einen anderen Würfel, der genau die entgegengesetzte Bewegung durchführt
* lassen Sie beide Würfel kollidieren und daraufhin ihre Richtung ändern

#### Teil 3
* Lassen Sie das Objekt zusätzlich zur Z-Bewegung um die Z-Achse rotieren

#### Teil 4
* lassen Sie das Objekt zusätzlich “wackeln”
* benutzen Sie dazu die UnityEngine.Random.Range(-1, 1) Methode.

#### Teil 5
* lassen Sie ein neues Objekt (z. B. ein Partikelsystem) dem ersten Objekt folgen, indem Sie ein public GameObject myTargetObject Attribute einfügen
* benutzen Sie das myTargetObject.transform.position-Attribute des Zielobjekts und kopieren Sie es (ggf. mit einem Offset) in das this.transform.position-Attribut.

## Abgabe 01

#### Aufgabe (Prefabs) 

1. Erstelle eine Spielfläche(Quad oder Cube) in der Größe (10 x 10)
2. Erzeuge ein leeres Game-Object im Menü GameObject -> Create Empty
3. Erzeuge ein C#-Script und verknüpfen Sie es mit dem GameObject.
4. Füge ein Attribut vom Typ Transform hinzu *public Transform myPrefab
5. Ziehe ein (schön gestaltetes) Prefab aus der Hierarchie auf das Transform-Feld im Inspektor. Das Objekt soll später als Collectable dienen
6. Erzeuge in der Start()-Methode mittels Instantiate(myPrefab, Vector, Quaternion) mehrere Instanzen des myPrefab-Objekts auf der Spielplattform. Nutze die UnityEngine.Random.Range()-Methode.
7. Ändere das Skript so, dass es eine bestimmte Anzahl von Objekten zufällig auf einer Spiel-Fläche verteilt.
8. Wähle eine der Folgenden Optionen:
* Gebe den neu erzeugten Objekte ein Verhalten (Rotation)
* Vermeide bei der Verteilung Kollisionen zwischen den Objekten

#### Aufgabe (Interaktion) 

9. Erzeuge ein Player-Objekt (z. B. einen Würfel), das sich mit Hilfe der Tastatur Achsenparallel bewegen kann.
10. Lasse die Kamera dem Player-Objekt in einem bestimmten Abstand (Offset) folgen.
11. Nutzen Sie zur Abfrage der Nutzerinteraktionen:
* float moveHorizontal = Input.GetAxis("Horizontal");
* float moveVertical = Input.GetAxis("Vertical");

#### Aufgabe (Rotation) 

12. Ändern Sie Ihr Player-Objekt, so dass es über die Tastatur gedreht werden kann.
13. Beim Nach-vorne-Gehen soll der Player in die Richtung gehen, in die er gerade schaut.
14. Verwende Quaternion.LookRotation(), um aus der Blickrichtung ein Quaternion zu
erzeugen

#### Aufgabe (Kamera)

15. Entwickele ein Skript, das die Kamera an die Position des Spielers hängt.
16. Integriere die Möglichkeit, dass die Kamera auch die Rotation des Spielers übernimmt. 
17. Realisiere die Kopplung manuell; so hast du die Möglichkeit, die Kamera auf die Betrachterposition einschwenken zu lassen.
18. Addiere einen Offset-Vektor auf die Position des Spielers, um die Kamera-Position zu setzen
19. Berücksichtige, dass der Offset-Vektor zwischen Spieler und Kamera auch rotiert werden muss.

## Abgabe 02

#### Aufgabe (Vuforia) 

1. Integriere Vuforia in das Projekt aus der ersten Abgabe
2. Downloade die ImageTarget-Datenbank von Moodle und importiere diese in das Projekt
3. Füge ein Image-Target mit einem Bild aus der gedownloadeten Datenbank
4. Lass das Spielfeld auf einem der bereitgestellten Target-Bildern darstellen.

#### Aufgabe (Virtual Buttons) 

1. Füge ein vier Virtual Buttons hinzu um die Spielfigur zu steuern (Vorwärts/Rückwärts,
Links/Rechts Rotation)
2. Virtual Buttons sind normalerweise unsichtbar, kombiniere diese mit UserInterfaceButtons von Unity und lass diese auf dem ImageTarget darstellen


## Abgabe 03

#### Aufgabe (2D User-Interfaces)

1. Baue ein 2D-Pausen-Menü in das Spiel ein
2. Erstelle ein Canvas mit zwei Buttons
3. Benenne die Buttons mit Return für schließen des Pausen-Menüs und Restart für Neustarten des Spiels
4. Erstelle ein neues leeres GameObject mit namen MenuManager
5. Erstelle ein neues Script und füge es dem MenuManager hinzu
6. Füge dem Script eine public Variable Menu vom Typ GameObject hinzu
7. Verbinde die Menu-Variable mit dem Canvas über die Editor-Oberfläche
8. Das Pausenmenü(Canvas) soll aufgerufen werden mit der Esc-Taste (KeyCode.Escape), das Canvas kann mit setActive() ein und ausgeblendet werden
9. Mit Aufruf des Pausen-Menüs soll das Spiel pausieren mit Time.timeScale = 0;
10. Durch klick auf dem Button Restart soll die Szene neugestartet werden verwende dazu SceneManager.LoadScene(SceneManager.GetActiveScene().name);
11. Mittels Return soll das Pausen-Menü geschlossen werden und das Spiel soll weiter gehen
12. Das Menü soll sich auch über erneutes betätigen der Esc-Taste schließen lassen
13. Hinweis: FixedUpdate() wird bei Time.timeScale = 0;nicht mehr aufgerufen, führe die Pausenfunktion stattdessen in Update() aus

#### Aufgabe (Shader Graph)

1. Fügt die Universal Render Pipeline zum laufenden Projekt hinzu
2. Erstellt einen Shader mit dem Shader-Graph
3. Der Shader soll einen animierten Leuchteffekt beinhalten siehe Beispiel
4. Erstelle ein neues Material für die Collectables und setzt den erstellten Shader für das Material

#### Aufgabe (VFX Graph)

1. Integriere den VFX-Graphen in das laufende Projekt
2. Erstelle einen VGX-Graph und erzeuge ein paar Partikel welche um die Collectables erscheinen. Die Farbe der Partikel soll über den Inspektor konfigurierbar sein

## Abgabe 03

#### Aufgabe (DOTS)

1. Konvertiere das Projekt mit Stand aus Abgabe 1 oder 3 zum Teil in das ECS-System, installiere dazu die Packages DOTS-Editor und Hybrid-Renderer
2. Erzeuge eine Komponente PlayerComponent welche folgenden Variablen beinhaltet:
- Speed (float) – Setzt die Bewegungsgeschwindigkeit des Spielers
- RotationAngle(float) – Speichert den aktuellen Rotationswinkel
3. Füge die PlayerComponent dem Player-GameObject hinzu (Hinweis: [GenerateAuthoringComponent] in der Komponente setzen
4. Aktiviere beim Player-GameObject das „Convert To Entity“ –Feld (Oben unter dem GameObject-Namen)
5. Erzeuge ein System PlayerBehaviorSystem, in dem System soll die Steuerung des Players implementiert werden
6. Innerhalb der OnUpdate()-Methode soll eine Entities.ForEach()-Lambdablock generiert werden. Folgende Komponenten sollen als Referenz (mit dem ref-parameter) übergeben werden:
- PlayerComponent
- Translation
- Rotation
7. Über das PlayerComponent kann auf die rotationAngle-Variable zugegriffen werden. rotationAngle kann mit dem Wert aus Input.GetAxis("Horizontal") addiert werden.
8. Erzeuge aus den Winkel einen Richtungsvektor mit float3 targetDirection = new float (math.Sin(rotationAngle), 0, math.cos(rotationAngle));
9. Erzeuge aus dem Richtungsvektor eine Rotation mit quaternion.LookRotationSafe()und übergib diese an die Rotation-Komponente
10. Update die Position der Translation-Komponente indem du den Richtungsvektor mit dem speed der PlayerComponent und dem Wert aus Input.GetAxis(„Vertical") multiplizierst
11. Erzeuge eine neue Komponente SpawnCollectableComponent welche folgende Variablen hat
- Anzahl der Collectables (int)
- CollectablePrefab (Entity)
12. Erzeuge ein neues leeres GameObject und zieh die SpawnCollectableComponent auf das GameObject
13. Setz das Feld „Convert to Entity“ für das GameObject
14. Erzeuge ein System SpawnCollectableSystem welches die Collectables als Entitäten erzeugt
- Das GameObject soll nicht mehr in der Szenenhierachie erscheinen
- Mögliche Kollisionen zwischen den Collectables müssen nicht abgefangen werden
15. Für die zufällige Positionierung verwende die Unity.Mathematics.Random-Klasse
16. Die Collectable-Entitäten erhalten eine neue Komponente mit den Namen CollectedComponent
17. In der CollectedComponent wird als Member ein boolean isCollected definiert.
18. Das Verhalten der Collectables soll über ein zweites System gemanaged werden, erzeuge hierzu ein zweites System CollectableBehaviorSystem
19. Das Verhalten sollte mindestens eine Rotation beinhalten (Rotation-Komponente) 

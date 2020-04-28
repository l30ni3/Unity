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


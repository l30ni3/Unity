# Unity
Unity exercises as part of the lecture "Development of Multimedia Systems"

## Abgabe 00

### Teil 1
* erzeugen Sie eine Szene in Unity
* erzeugen Sie einen Würfel und fügen Sie diesem einen Rigidbody hinzu, deaktivieren Sie die Gravitation im Rigidbody
* schreiben Sie ein Skript, das den Würfel mithilfe des transform-Attributes entlang der Z-Achse vor und zurück schiebt

### Teil 2
* Erzeugen Sie einen anderen Würfel, der genau die entgegengesetzte Bewegung durchführt
* lassen Sie beide Würfel kollidieren und daraufhin ihre Richtung ändern

### Teil 3
* Lassen Sie das Objekt zusätzlich zur Z-Bewegung um die Z-Achse rotieren

### Teil 4
* lassen Sie das Objekt zusätzlich “wackeln”
* benutzen Sie dazu die UnityEngine.Random.Range(-1, 1) Methode.

### Teil 5
* lassen Sie ein neues Objekt (z. B. ein Partikelsystem) dem ersten Objekt folgen, indem Sie ein public GameObject myTargetObject Attribute einfügen
* benutzen Sie das myTargetObject.transform.position-Attribute des Zielobjekts und kopieren Sie es (ggf. mit einem Offset) in das this.transform.position-Attribut.

🏗️ Phase 1: Projekt Models
Das Fundament. Hier definierst du, wie ein Benutzer aussieht.

1. Klasse: User (Basisklasse, abstract)
Properties:

Username (string)

PasswordHash (string)

Role (string)

Konstruktor: Muss alle drei Properties initialisieren.

Methoden:

GetInfo(): Gibt einen formatierten String mit Name und Rolle zurück.

CheckPassword(string inputHash): Gibt true zurück, wenn der übergebene Hash mit dem gespeicherten übereinstimmt.

2. Klasse: Admin (Erbt von User)
Konstruktor: Muss den Basis-Konstruktor aufrufen und die Rolle fest auf "Admin" setzen.

3. Klasse: NormalUser (Erbt von User)
Konstruktor: Muss den Basis-Konstruktor aufrufen und die Rolle fest auf "User" setzen.

Methoden:

ChangePassword(string newHash): Aktualisiert das Passwort-Property.

⚙️ Phase 2: Projekt Services
Das Gehirn. Hier passiert die eigentliche Arbeit.

Klasse: AuthService
Felder/Properties:

Eine private List<User> (hier liegen alle geladenen Benutzer).

Ein Pfad zur users.csv.

Methoden:

HashPassword(string password): Nutzt SHA256, um das Passwort in ein Byte-Array umzuwandeln und dieses als Hex-String zurückzugeben.

Register(string username, string password, string role):

Prüfen, ob User existiert.

Validieren (Name nicht leer, Passwort min. 6 Zeichen).

Neues Objekt (Admin oder NormalUser) erstellen.

In Liste speichern und an CSV anhängen.

Login(string username, string password):

Passwort hashen.

In der Liste nach Übereinstimmung von Name und Hash suchen.

Das User-Objekt zurückgeben (oder null).

LoadUsersFromFile(): Liest die CSV Zeile für Zeile, splittet den Text am ; und befüllt die Liste mit den richtigen Objekten.

🖥️ Phase 3: Projekt LoginSystem (Konsole)
Die Oberfläche. Hier steuerst du alles.

Program.cs
Ablauf:

Instanz von AuthService erstellen.

Hauptschleife (Main Menu):

Auswahl: Registrieren, Login, Beenden.

Nach dem Login (User Menu):

Prüfen: Ist der eingeloggte User ein Admin?

Wenn Admin: Menü für "Alle User anzeigen", "User löschen", "Logout".

Wenn NormalUser: Menü für "Profil anzeigen", "Passwort ändern", "Logout".

⚠️ Deine "Must-Haves" (Regeln)
Dateiformat: Die users.csv muss das Format Name;Hash;Rolle haben.

Referenzen: Services muss Models kennen. LoginSystem muss beide kennen.

Sichtbarkeit: Denke an das Keyword public, sonst kannst du aus dem Konsolen-Projekt nicht auf deine Klassen zugreifen.
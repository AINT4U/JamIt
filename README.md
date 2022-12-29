# Technische Informationen zu Jam-IT!

## Datenbank
Für die Erstellung der Alben wird eine SQLite Datenbank verwendet. Die Modelle der einzelnen Ressourcen befinden sich im Ordner [Models](./JamIT/Models/). Die CRUD-Operationen werden über die Services gehandelt, welche sich im Ordner [Services](./JamIT/Services/) befinden. Die Erstellung der Songs geht nicht über eine Datenbank.

## Benutzer und Login
Aufgrund fehlender Zeit in diesem Projekt gibt es weder Benutzer noch ein funktionierendes Login bisher. Die [Profilseite](./JamIT/Views/Profile.xaml) ist lediglich eine Darstellung der Seite wie sie wäre, wenn es Benutzer gäbe. Auf dieser Seite sind nur Beispiel Daten.

## Navigation / Flyout
Die Seiten-Navigation ist ein sogenanntes Flyout, des statisch ist, also immer angezeigt wird. Aufgrund eines Problems von MAUI und den eingestellten Flyout-Einstellungen ladet die Hintergrundfarbe der Navigation beim start nicht. Aus diesem Grund wurde ein Workaround gemacht, und die Farbe wurde mit leichtem Delay im Code-Behind gesetzt. Daher kann es in diesem Bereich gewisse Probleme geben.

## Sinnvolle Listenansicht
Im Bewertungsraster gibt es das Kriterium "Sinnvolle Listenansicht" und daraufhin eine Liste von Beispielen (ListView, Carousel, ...). In meinem Fall ist die Listenansicht auf der Seite [AlbumList](./JamIT/Views/AlbumListPage.xaml). Es ist ein Flexlayout mit Boxen, die je nach Breite der Seite neu angeordnet werden.
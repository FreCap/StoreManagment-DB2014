Esame: Base di Dati

Data: 17/06/2015

Gruppo: 1193

Componenti 2
Bellini Federico 0000692306 federico.bellini3@studio.unibo.it
Capponi Francesco 0000693862 francesco.capponi@studio.unibo.it

Interfaccia e piattaforma: interfaccia grafica C# su piattafroma Windows

Titolo: Azienda idraulica

Istruzioni:

Per importare il file di backup del database:
	- Aprire SQL Server Managemet Studio 2008, cliccare con il tasto destro su
	  "databases", scegliere l'opzione "Restore database".
	- Nella finestra che si apre, aggiungere nel campo "to database": "ProgettoDB15".
	- Selezionare il radioButton "from Device", selezionare il pulsante Add, ed
	  immettere il path del file .bak(backup del database) allegato.
	- Selezionare il file di backup appena aggiunto nella finestra sottostante e 
	  premere ok.

Importare il progetto C# in Visual Studio 2010, e connetterlo con il database appena importato.
Prima di avviare l'applicazione è necessario aggiornare il file LinqToSQLClass.dbm, cancellando
tutte le tabelle e le relazioni presenti in esso, e sostituendole con tutte le tabelle del 
database appena connesso a visual studio.
Il funzionamento dell'applicazione viene descritto brevemente nell'ultima parte della relazione
allegata.
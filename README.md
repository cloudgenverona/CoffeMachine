# CoffeMachine
Dopo aver completato la terza iterazione
http://simcap.github.io/coffeemachine/cm-third-iteration.html

Sviluppiamo ora delle varianti per iniziare a utilizzare degli integration test.

### Integration Test 1
Ogni volta che viene eseguita una erogazione con successo, è necessario verificare la quantità di sostanza rimasta a sistema.  
Nel caso di quantità sufficiente non succede nulla.  
Nel caso di quantità non sufficiente è necessario inviare un SMS al proprietario dell'impianto.  

### Integration Test 2
Ogni volta che viene eseguito un ordine con successo, è necessario mandare una mail al proprietario dell'impianto.  
Nella mail dovrà essere scritto il segente testo:  
IMPIANTO:FATTURATO:DATA  
Impianto è un numero fisso preconfigurato di 6 caratteri  
Fatturato è il quantitativo economico che la macchina conta dopo ogni acquisto  
Data è la data dell'acquisto nel formato: YYYYMMDD:HHmm  

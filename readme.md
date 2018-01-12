# MitBank
### An internet banking  C# client for a RELATIONAL database
Or just another application keeping trak of your **M**oney **i**n **t**he **Bank**.
### 1. Baza de date
![Diagrama](./Database.png)
#### Proceduri Stocate
1. AddBankAdmin (IDEmployee, Username, Password)
	* Creeaza un cont-utilizator de Admin (adauga perechea username + password in Usernames, tip admin).
1. AddNormalUser (IDCustomer, Username, Password)
	* Creeaza un cont-utilizator pentru un client al bancii.
#### -- to be continued.
### 2. Aplicatia (Clientul)
Aplicatia este gandita pe 2 layere, astfel:
1. Layerul **User Interface**, cu clasele:
    * Form1
    * Form2
1. Layerul **Data Management**, cu clasele:
    * DataManagement (statica)
##### Principiu de functionare:
Clasa *DataManagement* contine metode statice ce vor fi apelate din clasele de nivel
User Interface. Aceste metode statice se vor conecta la SQL Server, vor executa
operatiunile prevazute si vor intoarce spre User Interface un obiect de tip *Page*,
ce urmeaza a fi afisat utilizatorului prin grija interfetei grafice.
### 3. Tehnologia ADO.NET utilizata: Entitiy Framewok
De invatat!
###### Referinte:
[Gid github](http://rogerdudler.github.io/git-guide/)

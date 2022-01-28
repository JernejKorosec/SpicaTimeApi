Živijo Jernej,

 

Hvala za tvoj čas in razgovor danes. Kot dogovorjeno, ti pošiljam navodila za nalogo.
Prosim poskusi jo rešiti v Angular https://angular.io/.
Na sledečem naslovu imamo Rest API http://rdweb.spica.com:5213/timeapi, 
ki servira podatke in omogoča akcije nad evidenco delovnega časa. 

Zadaj je demo baza, tako da ne rabiš skrbet, da bi kaj "pokvarila". 
Prilagam TimeAPI developer manual, ki naj ti služi kot osnova: ​pdf icon TimeAPI. 
Prosil te bom za diskretnost okoli priloženega TimeAPI developer manuala, 
ki ni javen in ga zato po uporabi prosim izbriši.

Vse klice lahko izvedeš s Session Tokenom:
    User: demo
    Pass: demo
    API GUID: 87F262C4-7FA6-46D3-880D-2F7E15B4F204

Cilj je sledeč:
    Narediš en single page application v Angular, ki omogoča upravljanje s par entitetami.
    Settings ekran: tu nastaviš SpicaToken, ki ga pocachiraš v local storage od koder ga vsi ostali api klici uporabljajo
    Users ekran: (/employee endpoint)
        Pregled vseh userjev v nekem gridu
        Iskanje po imenu in priimku
        Dodajanje novega zaposlenega (ime, priimek, email, matična številka)
    Presence ekran
        Izpis trenutno prisotnih zaposlenih (upoštevaj vse zaposleni, zato uporabi filter orgUnitId=10000000)
        Nek gumb reload posodobi spisek (če bi teoretično enemu ki ni prisoten preko timeapija vnesel dogodek Prihod cca 10 minut nazaj, bi se potem moral pojaviti na seznamu)
    Opcijsko - uporabiš TDD kot razvojni proces.
Rešitev naloži kar na lasten github, od koder bo viden tudi tvoj history developmenta. Lahko pa si tudi sami snamemo dol, zbuildamo in poženemo (prosim pripravi navodila za namestitev v readme.md).
Za podrobnosti sem na voljo. Prosim sporoči, do kdaj misliš, da lahko dokončaš nalogo.
Lep dan & vikend,
Luka

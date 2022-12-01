using CSharpShop_2;

//Creo un prodotto e lo stampo//___________________________________________________
prodotto prodottoUno = new prodotto("pane", "alimentari", 3.99, 4);
prodottoUno.stampaProdotto();

//_________________________________________________________________________________
//Creo un prodotto e lo stampo//___________________________________________________
prodotto prodottoDue = new prodotto("sparapatate", "utensili", 119.99, 22);
prodottoDue.stampaProdotto();


//-------------------------shop2---------------------------------------------------
Elettrodomestico stampante = new Elettrodomestico("Epson","Elettrodomestico","nuovo",60.99,22);
stampante.stampaProdotto();
bool acceso= stampante.Getacceso();
Console.WriteLine(acceso);
stampante.AccendiElettrodomestico();
bool accesodue = stampante.Getacceso();
Console.WriteLine(acceso);
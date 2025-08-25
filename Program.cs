using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone1 = new Iphone("11-99999-9999", "XR", "123712831", 256);
Smartphone nokia1 = new Nokia("11-98888-98888", "Lumia", "423423423", 128);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("WhatsApp");
//Console.WriteLine("Dalej jestes zły i zawiedziony?");
//Console.WriteLine("Chcesz się pogodzić? Wpisz tak albo nie.");

//string odpowiedz = Console.ReadLine();

//if (odpowiedz == "tak")
//{
//    Console.WriteLine("Ciesze się! W takim razie odpowiedz na pytanie: ");
//    Console.WriteLine("Co jest ważniejsze: obrażanie się czy przepraszanie?");
//    string odpowiedz2 = Console.ReadLine().ToLower();

//    if (odpowiedz2 == "przepraszanie")
//    {
//        Console.WriteLine("Brawo! Otrzymujesz odblokowaną funkcję przepraszania!");
//        Console.WriteLine("Powiedz teraz: 'Przepraszam!'");
//    }
//    else if (odpowiedz2 == "obrażanie")
//    {
//        Console.WriteLine("...");
//    }
//    else
//    {
//        Console.WriteLine("Chyba coś źle napisałeś");
//    }
//}
//else
//{
//    Console.WriteLine("Okej, to wrócimy do tego, gdy będziesz gotowy.");
//}


Console.WriteLine("Dalej jestes zły i zawiedziony?");
Console.WriteLine("Chcesz się pogodzić? Wpisz tak albo nie.");

string odpowiedz = Console.ReadLine();

if (odpowiedz == "tak")
{
    Console.WriteLine("Ciesze się! W takim razie odpowiedz na pytanie:");
    bool poprawnaOdpowiedz = false;

    while (!poprawnaOdpowiedz) 
    {
        Console.WriteLine("Co jest ważniejsze: obrażanie się czy przepraszanie?");
        string odpowiedz2 = Console.ReadLine();

        if (odpowiedz2 == "przepraszanie")
        {
            Console.WriteLine("Brawo! Otrzymujesz odblokowaną funkcję przepraszania!");
            Console.WriteLine("Powiedz teraz: 'Przepraszam!'");
            poprawnaOdpowiedz = true;
        }
        else if(odpowiedz2 == "obrażanie")
        {
            Console.WriteLine("...");
            Console.WriteLine("Chyba nie zroumiałeś pytania :)))))");
            poprawnaOdpowiedz = false;
        }

        else
        {
            Console.WriteLine("Chyba coś źle napisałeś");
        }
    }
}
else
{
    Console.WriteLine("Okej, to wrócimy do tego, gdy będziesz gotowy.");
}
    
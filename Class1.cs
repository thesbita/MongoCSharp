using System;

public class Calcular
{
    public void CalcularMedia()
    {
        try
        {
            decimal nota1, nota2, maiornota, menornota, media;

            nota1 = 6;
            nota2 = 8;

            if (nota1 > nota2)
            {
                maiornota = nota1;
            }
            else if (nota2 > nota1)
            {
                maiornota = nota2;
            }


            media = (nota1 + nota2) / 2;
            media.ToString();
        }



        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }
    }
}

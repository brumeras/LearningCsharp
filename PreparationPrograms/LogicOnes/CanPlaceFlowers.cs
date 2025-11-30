namespace PreparationPrograms.LogicOnes;

public class CanPlaceFlowers
{
        public bool CheckIfCanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                // Praleisime jei užimta
                if (flowerbed[i] == 1)
                {
                    continue;
                }
            
                // Dabartinė pozicija tuščia - tikriname ar galime sodinti
            
                // Ar kairė pusė saugi?
                if (i > 0 && flowerbed[i - 1] == 1)
                {
                    continue; // Kairėje yra gėlė - negalime
                }
            
                // Ar dešinė pusė saugi?
                if (i < flowerbed.Length - 1 && flowerbed[i + 1] == 1)
                {
                    continue; // Dešinėje yra gėlė - negalime
                }
            
                // Jei pasiekėme šią vietą - galime sodinti!
                flowerbed[i] = 1;
                n--;
            
                // Optimizacija: jei jau pasodinom visas, grąžiname iš karto
                if (n == 0)
                {
                    return true;
                }
            }
        
            // Patikriname ar pavyko pasodinti visas
            if (n <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

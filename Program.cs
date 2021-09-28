using System;

namespace Encapsulation
{
    class Program
    {


        public static void Main()

        {
            BeerEncapsulator Utilisateur = new BeerEncapsulator();

            Utilisateur.GetNbrDeCapsuleEntreeParUser();
            Utilisateur.GetNbrDeBottlesEntreeParUser();
            Utilisateur.GetNbrDeBeerEntreeParUser();

            Console.WriteLine("Entrez le nombre de bières à réaliser : ");

            Console.WriteLine("-----------------------------------------");

            int b = Int32.Parse(Console.ReadLine());

            Utilisateur.ProduceEncapsulatedBeerBottles(b);

            Utilisateur.AddBeer();





        }


        public class BeerEncapsulator
        {

            private UInt32 _avalaibleBeerVolume;
            private UInt32 _avalaibleBottles;
            private UInt32 _avalaibleCapsules;

            public UInt32 GetNbrDeCapsuleEntreeParUser()
            {
                Console.WriteLine("Entrez le nombre de capsules en stock");
                UInt32 a = UInt32.Parse(Console.ReadLine());
                _avalaibleCapsules = a;
                return a;

            }
            public UInt32 GetNbrDeBeerEntreeParUser()
            {
                Console.WriteLine("Entrez le nombre de cl de bière en stock");
                UInt32 b = UInt32.Parse(Console.ReadLine());
                _avalaibleBeerVolume = b;
                return b;

            }

            public UInt32 GetNbrDeBottlesEntreeParUser()
            {
                Console.WriteLine("Entrez le nombre de bouteille en stock");
                UInt32 c = UInt32.Parse(Console.ReadLine());
                _avalaibleBottles = c;
                return c;
            }

            public void AddBeer()

            {
                if (_avalaibleBeerVolume < 33)
                {
                    _avalaibleBeerVolume = _avalaibleBeerVolume +33;
                   
                }

            }

            public int ProduceEncapsulatedBeerBottles(int nombreDeBieresAFaire)

            {

                int nombreDeBieresFaites = 0;
                while (_avalaibleBeerVolume > 33 && _avalaibleBottles > 0 && _avalaibleCapsules > 0 && nombreDeBieresAFaire>0)

                {

                    _avalaibleBeerVolume = _avalaibleBeerVolume - 33;
                    _avalaibleCapsules = _avalaibleCapsules - 1;
                    _avalaibleBottles = _avalaibleBottles - 1;

                    nombreDeBieresAFaire = nombreDeBieresAFaire - 1;
                    nombreDeBieresFaites = nombreDeBieresFaites + 1;
                    


                }
                Console.WriteLine(nombreDeBieresFaites + " bières ont pu être faites !!!!!!!");
                Console.WriteLine("Il reste "+ nombreDeBieresAFaire + " bières à réaliser !!!!");
                Console.WriteLine("Il reste " + _avalaibleBeerVolume + " cl de bière !!!!!!!");
                Console.WriteLine("Il reste " + _avalaibleBottles + " bouteilles !!!!!!!");
                Console.WriteLine("Il reste " + _avalaibleCapsules + " capsules !!!!!!!");
                Console.WriteLine("-----------------------------------------------------");

                if (_avalaibleBottles == 0)
                {
                    Console.WriteLine("Oups !! Les bouteilles sont manquantes, on ravitaille bouteilles !!!!");
                    return 0;
                }
                else if (_avalaibleCapsules == 0)
                {
                    Console.WriteLine("Oups !! Les capsules sont manquantes, on ravitaille capsules !!!!");
                    return 0;
                }
                else if (_avalaibleBeerVolume < 33)
                {
                    Console.WriteLine("Oups !! Il n'y a plus de bière, on ravitaille  cl de bière !!!!");
                    return 0;

                }

                return nombreDeBieresFaites;


            }

        }
    }
}



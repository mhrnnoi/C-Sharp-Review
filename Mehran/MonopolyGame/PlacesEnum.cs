namespace MonopolyGame
{
    public class OldKent
    {

        public static int price = 60;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }

                
            }
            else
            {
        CheckifpLayerWant(PLAyeR Player);
     If ( yes )
     {
        PRocesBu;(Player Player);
     }
     else
     {
        auction();
     }

            }
        }
        public static void RentCalcPlayer()
        {
            if (HasHotel)
            {
                Rent = 250;
            }
            else if (Houses == 4)
            {
                Rent = 160;
            }
            else if (Houses == 3)
            {
                Rent = 90;
            }
            else if (Houses == 2)
            {
                Rent = 30;
            }
            else if (Houses == 1)
            {
                Rent = 10;
            }
            else if (IsColorSet)
            {
                Rent = 4;
            }
            else
            {
                Rent = 2;
            }



        }





        public static string Name = "old kent";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();

    }
    public class Whitechapel
    {
        public static  int price = 60;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        public static void RentCalcPlayer()
        {
            if (HasHotel)
            {
                Rent = 450;
            }
            else if (Houses == 4)
            {
                Rent = 320;
            }
            else if (Houses == 3)
            {
                Rent = 180;
            }
            else if (Houses == 2)
            {
                Rent = 60;
            }
            else if (Houses == 1)
            {
                Rent = 20;
            }
            else if (IsColorSet)
            {
                Rent = 8;
            }
            else
            {
                Rent = 4;
            }


        }



        public static string Name = "white chappel";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();

    }
    public class TheAngelIslington
    {
        public static  int price = 100;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 550;
            }
            else if (Houses == 4)
            {
                Rent = 400;
            }
            else if (Houses == 3)
            {
                Rent = 270;
            }
            else if (Houses == 2)
            {
                Rent = 90;
            }
            else if (Houses == 1)
            {
                Rent = 30;
            }
            else if (IsColorSet)
            {
                Rent = 12;
            }
            else
            {
                Rent = 6;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "The Angel Islington";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();

    }
    public class EustonRoad
    {

        public static  int price = 100;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 550;
            }
            else if (Houses == 4)
            {
                Rent = 400;
            }
            else if (Houses == 3)
            {
                Rent = 270;
            }
            else if (Houses == 2)
            {
                Rent = 90;
            }
            else if (Houses == 1)
            {
                Rent = 30;
            }
            else if (IsColorSet)
            {
                Rent = 12;
            }
            else
            {
                Rent = 6;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Euston Road";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class PentonvilleRoad
    {

        public static  int price = 120;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 600;
            }
            else if (Houses == 4)
            {
                Rent = 450;
            }
            else if (Houses == 3)
            {
                Rent = 300;
            }
            else if (Houses == 2)
            {
                Rent = 100;
            }
            else if (Houses == 1)
            {
                Rent = 40;
            }
            else if (IsColorSet)
            {
                Rent = 16;
            }
            else
            {
                Rent = 8;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Penton villeRoad";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Pall_mall
    {

        public static  int price = 140;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 750;
            }
            else if (Houses == 4)
            {
                Rent = 625;
            }
            else if (Houses == 3)
            {
                Rent = 450;
            }
            else if (Houses == 2)
            {
                Rent = 150;
            }
            else if (Houses == 1)
            {
                Rent = 50;
            }
            else if (IsColorSet)
            {
                Rent = 20;
            }
            else
            {
                Rent = 10;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Pall mall";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class WhiteHall
    {

        public static  int price = 140;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 750;
            }
            else if (Houses == 4)
            {
                Rent = 625;
            }
            else if (Houses == 3)
            {
                Rent = 450;
            }
            else if (Houses == 2)
            {
                Rent = 150;
            }
            else if (Houses == 1)
            {
                Rent = 50;
            }
            else if (IsColorSet)
            {
                Rent = 20;
            }
            else
            {
                Rent = 10;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "WhiteHall";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class NorthumberlandAvenue
    {

        public static  int price = 160;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 900;
            }
            else if (Houses == 4)
            {
                Rent = 700;
            }
            else if (Houses == 3)
            {
                Rent = 500;
            }
            else if (Houses == 2)
            {
                Rent = 180;
            }
            else if (Houses == 1)
            {
                Rent = 60;
            }
            else if (IsColorSet)
            {
                Rent = 24;
            }
            else
            {
                Rent = 12;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "NorthumberlandAvenue";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner(); 
    }
    public class BowStreet
    {

        public static int price = 180;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 950;
            }
            else if (Houses == 4)
            {
                Rent = 750;
            }
            else if (Houses == 3)
            {
                Rent = 550;
            }
            else if (Houses == 2)
            {
                Rent = 200;
            }
            else if (Houses == 1)
            {
                Rent = 70;
            }
            else if (IsColorSet)
            {
                Rent = 28;
            }
            else
            {
                Rent = 14;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Bow Street";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class MarlboroughStreet
    {

        public static  int price = 100;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 950;
            }
            else if (Houses == 4)
            {
                Rent = 750;
            }
            else if (Houses == 3)
            {
                Rent = 550;
            }
            else if (Houses == 2)
            {
                Rent = 200;
            }
            else if (Houses == 1)
            {
                Rent = 70;
            }
            else if (IsColorSet)
            {
                Rent = 28;
            }
            else
            {
                Rent = 14;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Marlborough Street";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class VineStreet
    {
        public static int price = 200;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1000;
            }
            else if (Houses == 4)
            {
                Rent = 800;
            }
            else if (Houses == 3)
            {
                Rent = 600;
            }
            else if (Houses == 2)
            {
                Rent = 220;
            }
            else if (Houses == 1)
            {
                Rent = 80;
            }
            else if (IsColorSet)
            {
                Rent = 32;
            }
            else
            {
                Rent = 16;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "VineStreet";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }

    public class Strand
    {

        public static  int price = 220;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1050;
            }
            else if (Houses == 4)
            {
                Rent = 875;
            }
            else if (Houses == 3)
            {
                Rent = 700;
            }
            else if (Houses == 2)
            {
                Rent = 250;
            }
            else if (Houses == 1)
            {
                Rent = 90;
            }
            else if (IsColorSet)
            {
                Rent = 36;
            }
            else
            {
                Rent = 18;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Strand";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Fleet
    {

        public static int price = 220;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1050;
            }
            else if (Houses == 4)
            {
                Rent = 875;
            }
            else if (Houses == 3)
            {
                Rent = 700;
            }
            else if (Houses == 2)
            {
                Rent = 250;
            }
            else if (Houses == 1)
            {
                Rent = 90;
            }
            else if (IsColorSet)
            {
                Rent = 36;
            }
            else
            {
                Rent = 18;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Fleet";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Trafelgar
    {

        public static int price = 240;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1100;
            }
            else if (Houses == 4)
            {
                Rent = 925;
            }
            else if (Houses == 3)
            {
                Rent = 750;
            }
            else if (Houses == 2)
            {
                Rent = 300;
            }
            else if (Houses == 1)
            {
                Rent = 100;
            }
            else if (IsColorSet)
            {
                Rent = 40;
            }
            else
            {
                Rent = 20;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Trafelgar";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class LeicesterSquare
    {

        public static int price = 260;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1150;
            }
            else if (Houses == 4)
            {
                Rent = 975;
            }
            else if (Houses == 3)
            {
                Rent = 800;
            }
            else if (Houses == 2)
            {
                Rent = 330;
            }
            else if (Houses == 1)
            {
                Rent = 110;
            }
            else if (IsColorSet)
            {
                Rent = 44;
            }
            else
            {
                Rent = 22;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Leicester Square";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Coventry
    {

        public static  int price = 260;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1150;
            }
            else if (Houses == 4)
            {
                Rent = 975;
            }
            else if (Houses == 3)
            {
                Rent = 800;
            }
            else if (Houses == 2)
            {
                Rent = 330;
            }
            else if (Houses == 1)
            {
                Rent = 110;
            }
            else if (IsColorSet)
            {
                Rent = 44;
            }
            else
            {
                Rent = 22;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Coventry";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Picadely
    {

        public static  int price = 280;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1200;
            }
            else if (Houses == 4)
            {
                Rent = 1025;
            }
            else if (Houses == 3)
            {
                Rent = 850;
            }
            else if (Houses == 2)
            {
                Rent = 360;
            }
            else if (Houses == 1)
            {
                Rent = 120;
            }
            else if (IsColorSet)
            {
                Rent = 48;
            }
            else
            {
                Rent = 24;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Picadely";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Regnet
    {

        public static  int price = 300;
        public static int Rent = 2;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1275;
            }
            else if (Houses == 4)
            {
                Rent = 1100;
            }
            else if (Houses == 3)
            {
                Rent = 900;
            }
            else if (Houses == 2)
            {
                Rent = 390;
            }
            else if (Houses == 1)
            {
                Rent = 130;
            }
            else if (IsColorSet)
            {
                Rent = 52;
            }
            else
            {
                Rent = 26;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Regnet";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Oxford
    {

        public static  int price = 300;
        public static int Rent = 26;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            
            if (HasHotel)
            {
                Rent = 1275;
            }
            else if (Houses == 4)
            {
                Rent = 1100;
            }
            else if (Houses == 3)
            {
                Rent = 900;
            }
            else if (Houses == 2)
            {
                Rent = 390;
            }
            else if (Houses == 1)
            {
                Rent = 130;
            }
            else if (IsColorSet)
            {
                Rent = 52;
            }
            else
            {
                Rent = 26;
            }




        }

        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        
        



        public static string Name = "Oxford";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Bond_Street
    {

        public static  int price = 320;
        public static int Rent = 28;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1400;
            }
            else if (Houses == 4)
            {
                Rent = 1200;
            }
            else if (Houses == 3)
            {
                Rent = 1000;
            }
            else if (Houses == 2)
            {
                Rent = 450;
            }
            else if (Houses == 1)
            {
                Rent = 150;
            }
            else if (IsColorSet)
            {
                Rent = 56;
            }
            else
            {
                Rent = 28;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Bond Street";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class ParkLane
    {

        public static  int price = 350;
        public static int Rent = 35;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 1500;
            }
            else if (Houses == 4)
            {
                Rent = 1300;
            }
            else if (Houses == 3)
            {
                Rent = 1100;
            }
            else if (Houses == 2)
            {
                Rent = 500;
            }
            else if (Houses == 1)
            {
                Rent = 175;
            }
            else if (IsColorSet)
            {
                Rent = 70;
            }
            else
            {
                Rent = 35;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Park Lane";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }
    public class Mayfair
    {

        public static  int price = 400;
        public static int Rent = 50;
        public static bool IsColorSet = false;
        public static bool HasOwner = false;
        
        public static int MortgagePay = MortgageRecive + MortgageRecive / 100;
        public static int MortgageRecive = price / 2;
        public static int Houses = 0;
        public static bool ismortgage = false;
        public static bool HasHotel = false;

        public static void RentCalcPlayer()
        {
            {
            if (HasHotel)
            {
                Rent = 2000;
            }
            else if (Houses == 4)
            {
                Rent = 1700;
            }
            else if (Houses == 3)
            {
                Rent = 1400;
            }
            else if (Houses == 2)
            {
                Rent = 600;
            }
            else if (Houses == 1)
            {
                Rent = 200;
            }
            else if (IsColorSet)
            {
                Rent = 100;
            }
            else
            {
                Rent = 50;
            }


        }

        }
        public static void Process(Player player)
        {
            if (HasOwner)
            {
                if (Owner == player)
                {



                }
                else
                {
                    if (ismortgage)
                    {

                    }
                    else
                    {
                        RentCalcPlayer();
                        
                    }
                }
            }
        }
        


        public static string Name = "Mayfair";
        public static Player Owner { get; set; }


        // void Mortgage();
        // void UnMortgage();
        // void SetOwner();
    }

    public enum PlacesEnum
    {
        Go = 1,
        Old_Kent_Road,
        ChestCard1,
        Whitechapel_Road,
        IncomeTax200,
        King_cross_station,
        The_Angel_Islington,
        ChanceCard1,
        Euston_Road,
        Pentonville_Road,
        Jail,
        Pall_mall,
        Electricity,
        WhiteHall,
        Northumberland_Avenue,
        Marylebone_Station,
        Bow_Street,
        ChestCard2,
        Marlborough_Street,
        Vine_Street,
        FreeParking,
        Strand,
        ChanceCard2,
        Fleet,
        Trafelgar,
        Fenchurch_Station,
        Leicester_Square,
        Coventry,
        Water,
        Picadely,
        Go_to_Jail,
        Regnet,
        Oxford,
        ChestCard3,
        Bond_Street,
        Liverpool_Street_Station,
        ChanceCard3,
        Park_lane,
        TAx100,
        Mayfair
    }
}
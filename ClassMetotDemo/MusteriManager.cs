using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriLogIn(Musteri musteri)
		{
			Console.WriteLine("Type Your ID Please : ");
            int idbruh = Convert.ToInt32(Console.ReadLine());
            if(idbruh == musteri.MusteriId)
			{
				Console.WriteLine("Welcome Back !" + musteri.MusteriName);
			}
			else 
			{
                Console.WriteLine("This ID Doesn't Exist! ");
			}
            FirstActions(musteri);
		}
        public void MusteriSignIn(Musteri musteri)
        {
			Console.WriteLine("Insert your name please : ");
            musteri.MusteriName = Console.ReadLine();
			Console.WriteLine("And age too : ");
            musteri.MusteriAge = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Your Balance Is: " + "0");
            FirstActions(musteri);
        }
        public void MusteriDel(Musteri musteri)
        {
			Console.WriteLine("Insert Your Account To Delete : ");
            string name = Console.ReadLine();
			Console.WriteLine("Your Account With The Name Of "+ name +" Got Deleted Successfully");
            Exit(musteri);
        }
        public void MusteriChangeBal(Musteri musteri)
        {
			Console.WriteLine("Press 1 To Add To Your Balance" + "\n" +
                            + "Press 2 To Take From Your Balance");
            int breh = Convert.ToInt32(Console.ReadLine());
			switch (breh)
			{
                case 1:
                    BalAdd(musteri);
                    break;
                case 2:
                    BalTake(musteri);
                    break;
                default:
					Console.WriteLine("Wrong Numbers Bro Stop It!");
                    break;
			}
            void BalAdd(Musteri musteri)
            {
				Console.WriteLine("Your Current Balance Is :" + musteri.MusteriBalance);
				Console.WriteLine("How Much Money Are You Adding ?");
                double money = Convert.ToDouble(Console.ReadLine());
                double resultMoney = money + musteri.MusteriBalance;
				Console.WriteLine("Your New Balance Is : " + resultMoney);
                FirstActions(musteri);
            }
            void BalTake(Musteri musteri)
            {
				Console.WriteLine("Your Current Balance Is :" + musteri.MusteriBalance);
                Console.WriteLine("How Much Money Are You Taking ?");
                double money = Convert.ToDouble(Console.ReadLine());
                double resultMoney = money - musteri.MusteriBalance;
                Console.WriteLine("Your New Balance Is : " + resultMoney);
                FirstActions(musteri);
            }
        }
        public void FirstActions(Musteri musteri)
		{
			Console.WriteLine("Press 0 To Log In " + "\n"+
                              "Press 1 To Add A New Account " + "\n" +
                              "Press 2 To Delete An Account" + "\n" +
                              "Press 3 To Deal With Your Balance" + "\n" +
                              "Press 4 To Exit");
            int bruh = Convert.ToInt32(Console.ReadLine());
			switch (bruh)
			{
                case 0:
                    MusteriLogIn(musteri);
                    break;
                case 1:
                    MusteriSignIn(musteri);
                    break;
                case 2:
                    MusteriDel(musteri);
                    break;
                case 3:
                    MusteriChangeBal(musteri);
                    break;
                case 4:
                    Exit(musteri);
                    break;
                default:
					Console.WriteLine("Wrong Numbers Kiddo!");
                    break;
			}
		}
        public void Exit(Musteri musteri)
		{
			Console.WriteLine("Are You Sure ? ");
			Console.WriteLine("Press 1 For Yes " + "\n" +
                            + "Press 2 For No ");
            int LastDecision = Convert.ToInt32(Console.ReadLine());
			switch (LastDecision)
			{
                case 1:
                    break;
                case 2:
                    FirstActions(musteri);
                    break;
                default:
					Console.WriteLine("bruh");
                    break;
			}
		}
    }
}

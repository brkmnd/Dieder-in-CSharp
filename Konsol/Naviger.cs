using System;
using System.Collections.Generic;
using DiederGrupper;

namespace Konsol
{
	public class Naviger
	{
		private DiederGruppe d0;
        private PrintGon printGon;
        private int rTo = 1;
        private void printNL(string s){
            Console.WriteLine(s);
        }
        private void printMenu(){
            Console.WriteLine("   ----------");
            Console.WriteLine("Rotation^{0}\t: r eller ->",this.rTo.ToString());
            Console.WriteLine("Rotation^(-{0})\t: <-",this.rTo.ToString());
            Console.WriteLine("Spejlning\t: s eller op eller ned");
            Console.WriteLine("Quit\t\t: q");
            Console.WriteLine("   ----------");
        }
        private void matchKey(ConsoleKeyInfo k0)
        {   
            if ("123456789".IndexOf(k0.KeyChar) > -1){
                this.rTo = (int)Char.GetNumericValue(k0.KeyChar);
            }
            switch (k0.KeyChar)
            {
                case 'r':
                    this.d0 = this.d0.R(1);
                    break;
                case 's':
                    this.d0 = this.d0.S();
                    break;
                case 'q':
                    Environment.Exit(0);
                    break;
            }
            switch (k0.Key)
            {
                case ConsoleKey.RightArrow:
                    this.d0 = this.d0.R(this.rTo);
                    break;
                case ConsoleKey.LeftArrow:
                    this.d0 = this.d0.R(-this.rTo);
                    break;
                case ConsoleKey.UpArrow:
                    this.d0 = this.d0.S();
                    break;
                case ConsoleKey.DownArrow:
                    this.d0 = this.d0.S();
                    break;
            }
			Console.Clear();
            this.printGon.SetGon(this.d0.ToList());
			this.printNL(this.printGon.ToString());
            this.printMenu();
		}
		private void getKey(){
			ConsoleKeyInfo k0;
			while(true){
				k0 = Console.ReadKey();
				matchKey(k0);
			}
		}
		public Naviger(){
			this.d0 = new DiederGruppe (16);
		}
		public void Start(){
            this.printGon = new PrintGon(this.d0.ToList());
			this.printNL(this.printGon.ToString());
            this.printMenu();
			this.getKey ();
		}
	}
}


using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRPG
{
    public class GUI
    {
        private string header;
        public string Header{
            get{return this.header;}
            set{this.header = value;}
        }
        public GUI()
        {
            this.header = "Welcome to the Game" + "\n"
            + "================================" + "\n";
        }
        public void render()
        {
            Console.WriteLine(this.header);
        }
    }
}
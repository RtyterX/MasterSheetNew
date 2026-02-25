using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Entitys
{
    public class Step
    {
        public int number;
        public string text;
        public string script;
        public PictureBox image;
        public int client_Id;
    
        public Step(int number, string text, string script, PictureBox image, int client_Id)
        {
            this.number = number;
            this.text = text;
            this.script = script;
            this.image = image;
            this.client_Id = client_Id;
        }
    
    }
}

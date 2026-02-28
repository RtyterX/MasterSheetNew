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
        public Script script;
        public PictureBox image;
        public bool restore;
        public int client_Id;
    
        public Step(int number, string text, Script script, PictureBox image, bool restore, int client_Id)
        {
            this.number = number;
            this.text = text;
            this.script = script;
            this.image = image;
            this.restore = restore;
            this.client_Id = client_Id;
        }
    
    }
}

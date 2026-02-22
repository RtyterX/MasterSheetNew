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
        public string description;
        public string script;
        public PictureBox image;
    
        public Step(int number, string description, string script, PictureBox image)
        {
            this.number = number;
            this.description = description;
            this.script = script;
            this.image = image;
        }
    
    }
}

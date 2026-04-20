using System;
using System.Collections.Generic;
using System.Drawing;


namespace MasterSheetNew.Entitys
{
    public class Step
    {
        public int number;
        public string text;
        public Script script;
        public Bitmap image;
        public bool restore;
        public int client_Id;
    
        public Step(int number, string text, Script script, Bitmap image, bool restore, int client_Id)
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

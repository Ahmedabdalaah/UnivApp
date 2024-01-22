using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace UnivApp
{
    internal class GetData
    {
        public GetData(RichTextBox box,  String fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach(string line in lines)
            {
                box.Text += "\n"+line;
            }
        }
    }
}

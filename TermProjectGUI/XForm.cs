using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProjectGUI {
    public class XForm: Form {
        protected Worker worker { get; set; }
        //protected XForm parentForm {get; set; }
        static int titleSize = 18;
        static int subtitleSize = 14;
        static int textSize = 12;
        static string fontName = "Arial";
        Font titleFont = new Font(fontName, titleSize);
        Font subtitleFont = new Font(fontName, subtitleSize);
        Font textFont = new Font(fontName, textSize);

        public XForm() { }

        public string GetCurrentDate() {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

    }
}

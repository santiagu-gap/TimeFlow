using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeFlow
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        public class ColorPalette
        {
            public static Color BackgroundColor { get; } = Color.FromArgb(18, 18, 18);  // #121212
            public static Color TextColor { get; } = Color.FromArgb(234, 234, 234);    // #EAEAEA
            public static Color AccentColor { get; } = Color.FromArgb(52, 152, 219);   // #3498DB
            public static Color SecondaryTextColor { get; } = Color.FromArgb(142, 142, 147); // #8E8E93
            public static Color LinkColor { get; } = Color.FromArgb(30, 144, 255);    // #1E90FF
            public static Color ErrorColor { get; } = Color.FromArgb(255, 59, 48);     // #FF3B30
            public static Color WarningColor { get; } = Color.FromArgb(255, 168, 0);   // #FFA800
            public static Color SelectionColor { get; } = Color.FromArgb(64, 64, 64);  // #404040
            public static Color BorderColor { get; } = Color.FromArgb(8, 8, 8);       // #080808
            public static Color InactiveColor { get; } = Color.FromArgb(12, 12, 12);  // #0C0C0C
        }


    }

}

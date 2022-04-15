using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NOTEPAD.FrmNote;

namespace NOTEPAD.Lib.Util
{
    public static class LookUtil
    {
        private static int percentage = 100;
        public static void SetFont(Control control, ZoomType zoomType)
        {
            float currentFontSize = control.Font.Size;

            switch (zoomType)
            {
                case ZoomType.ZoomIn:
                    currentFontSize += 1.0F;
                    break;
                case ZoomType.ZoomOut:
                    currentFontSize -= 1.0F;
                    break;
                case ZoomType.Default:
                    currentFontSize = 9;
                    break;
                default:
                    currentFontSize = 9;
                    break;
            }

            control.Font = new Font(control.Font.Name, currentFontSize, control.Font.Style, control.Font.Unit);
        }

        public static void SetStatusBarLabel(ToolStripStatusLabel label, ZoomType zoomType)
        {
            switch (zoomType)
            {
                case ZoomType.ZoomIn:
                    percentage += 10;
                    break;
                case ZoomType.ZoomOut:
                    percentage -= 10;
                    break;
                case ZoomType.Default:
                    percentage = 100;
                    break;
                default:
                    percentage = 100;
                    break;
            }

            label.Text = $"{percentage}%";
        }

        public static string GetStatusBarLineAndColumn(int currentLine, int currentColumn)
        {
            return $"Ln {currentLine}, Col {currentColumn}";
        }
    }
}

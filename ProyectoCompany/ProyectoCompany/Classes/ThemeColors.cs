﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompany.Classes
{
    public static class ThemeColors
    {
        public static Color primaryColor {get; set;}
        public static Color secondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { 
          "#3F5181",
          "#009688",
          "#FF5722",
          "#607DBB",
          "#FF9800",
          "#9C27B0",
          "#2196F3",
          "#EA676C",
          "#E41A4A",
          "#5978BB",
          "#018790",
          "#0E3441",
          "#00B0AD",
          "#721D47",
          "#EA4833",
          "#EF937E",
          "#F37521",
          "#A12059",
          "#126881",
          "#88C240",
          "#364D58",
          "#C7DC5B",
          "#0094BC",
          "#E4126B",
          "#43B76E",
          "#7BCFE9",
          "#B71C46"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //if correction factor is less than 0, DARK color
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;

            } //if correction factor is less than 0, DARK color
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}

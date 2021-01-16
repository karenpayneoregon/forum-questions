using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CreateDynamicControls.Classes
{
    public class Operations
    {
        public static List<Button> ButtonsList { get; set; }
        public static int Base { get; set; }
        public static int Left { get; set; }
        public static int BaseWidth { get; set; }
        public static int BaseHeightPadding { get; set; }
        public static string BaseName { get; set; } = "Button";
        public static EventHandler EventHandler { get; set; }
        public static Control ParentControl { get; set; }
        public static int Index = 1;

        /// <summary>
        /// Initialize global properties
        /// </summary>
        /// <param name="pControl">Control to place button</param>
        /// <param name="pBase"></param>
        /// <param name="pBaseHeightPadding"></param>
        /// <param name="pLeft"></param>
        /// <param name="pWidth"></param>
        /// <param name="pButtonClick">Click event for button</param>
        public static void Internalize(Control pControl, int pBase, int pBaseHeightPadding, int pLeft, int pWidth, EventHandler pButtonClick)
        {
            
            ParentControl = pControl;
            Base = pBase;
            BaseHeightPadding = pBaseHeightPadding;
            Left = pLeft;
            BaseWidth = pWidth;
            EventHandler = pButtonClick;
            ButtonsList = new List<Button>();
            
        }
        public static void CreateButton(string text = "")
        {

            var button = new Button()
            {
                Name = $"{BaseName}{Index}",
                Text = text, 
                Width = BaseWidth,
                Location = new Point(Left, Base),
                Parent = ParentControl,
                Visible = true
            };

            button.Click += new System.EventHandler(EventHandler);
            ButtonsList.Add(button);

            ParentControl.Controls.Add(button);
            Base += BaseHeightPadding;
            Index += 1;
        }

    }
}

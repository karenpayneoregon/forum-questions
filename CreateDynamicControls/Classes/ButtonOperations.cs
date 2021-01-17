using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CreateDynamicControls.Classes.Controls;

namespace CreateDynamicControls.Classes
{
    public class Operations
    {
        public static List<DataButton> ButtonsList { get; set; }
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
        /// <param name="pBase">Top</param>
        /// <param name="pBaseHeightPadding">Padding between buttons</param>
        /// <param name="pLeft">Left position</param>
        /// <param name="pWidth">Width of button</param>
        /// <param name="pButtonClick">Click event for button</param>
        public static void Initialize(Control pControl, int pBase, int pBaseHeightPadding, int pLeft, int pWidth, EventHandler pButtonClick)
        {
            
            ParentControl = pControl;
            Base = pBase;
            BaseHeightPadding = pBaseHeightPadding;
            Left = pLeft;
            BaseWidth = pWidth;
            EventHandler = pButtonClick;
            ButtonsList = new List<DataButton>();
            
        }
        public static void CreateButton(string text = "")
        {

            var button = new DataButton()
            {
                Name = $"{BaseName}{Index}",
                Text = text, 
                Width = BaseWidth,
                Location = new Point(Left, Base),
                Parent = ParentControl,
                Visible = true
            };

            button.Click += EventHandler;
            ButtonsList.Add(button);

            ParentControl.Controls.Add(button);
            Base += BaseHeightPadding;
            Index += 1;
        }
        public static void CreateCategoryButton(string text, int categoryIdentifier)
        {

            var button = new DataButton()
            {
                Name = $"{BaseName}{Index}",
                Text = text,
                Width = BaseWidth,
                Location = new Point(Left, Base),
                Parent = ParentControl, 
                Identifier = categoryIdentifier,
                Visible = true
            };

            button.Click += EventHandler;
            ButtonsList.Add(button);

            ParentControl.Controls.Add(button);
            Base += BaseHeightPadding;
            Index += 1;
        }
    }
}

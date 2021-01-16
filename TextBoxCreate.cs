using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreateDynamicTextBoxes_CS
{
    public class TextBoxCreate
    {
        public TextBox[] TextBoxes { get; set; }
        public string TextBoxBaseName { get; set; }
        public int TextBoxCount { get; set; }
        public Control ParentControl { get; set; }

        public TextBoxCreate()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ParentControl">Where the controls will be located on i.e. a form, a groupbox, FlowLayOut etc</param>
        /// <param name="BaseName">Base name of the TextBox after the prefix of txt</param>
        /// <param name="Count">How many TextBoxes to generate</param>
        public TextBoxCreate(Control ParentControl, string BaseName, int Count)
        {
            this.ParentControl = ParentControl;
            this.TextBoxBaseName = BaseName;
            this.TextBoxCount = Count;
        }

        public void Test()
        {
            Console.WriteLine();
        }

        public void CreateTextBoxes()
        {
            int Base = 10;
            this.TextBoxes = Enumerable.Range(0, TextBoxCount).Select((Indexer) =>
                {
                    TextBox b = new TextBox
                    {
                        Name = string.Concat("txt", TextBoxBaseName, Indexer + 1),
                        Text = Convert.ToString(Indexer + 1),
                        Width = 150,
                        Location = new Point(25, Base),
                        Parent = this.ParentControl
                    };

                    this.ParentControl.Controls.Add(b);
                    Base += 30;

                    return b;
                }
            ).ToArray();
        }
    }
}
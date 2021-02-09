using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ExtenderSample
{
    public class TextBoxCustom : TextBox
    {
        [Category("Behavior"), Description("Identifier")]
        public int? Id { get; set; }
        public bool HasId => Id.HasValue;
    }
}

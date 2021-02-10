using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Document;

namespace GemboxDocumentTest.Classes
{
    public class Operations
    {
        private static void InitializeGemSoftware()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }

        public static void Example1()
        {
            InitializeGemSoftware();
            var document = new DocumentModel();

            Section section = new Section(document);
            document.Sections.Add(section);

            Paragraph paragraph = new Paragraph(document);
            section.Blocks.Add(paragraph);

            var run = new Run(document, "Hello World!");
            paragraph.Inlines.Add(run);

            document.Save("Hello World.docx");
        }
        
    }
}

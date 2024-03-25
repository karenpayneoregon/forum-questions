using GemBox.Document;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ComponentInfo.SetLicense("DKMF-J4EF-6ESJ-LJ8M ");

        DocumentModel document = new();

        Section section = new Section(document);
        document.Sections.Add(section);

        Paragraph paragraph = new(document);
        section.Blocks.Add(paragraph);

        Run run = new Run(document, "Hello World!");
        paragraph.Inlines.Add(run);

        document.Save("HelloWorld.docx");
        MessageBox.Show("Done");
    }
}

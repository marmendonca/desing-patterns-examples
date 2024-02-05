namespace DesingPatternsExamples.Criational.FactoryMethod.Example;

public class PdfExporter : IDocumentExporter
{
    public void Export(Document document)
    {
        Console.WriteLine($"Exporting document {document.Title} to PDF format.");
    }
}
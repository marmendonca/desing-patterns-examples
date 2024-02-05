namespace DesingPatternsExamples.Criational.FactoryMethod.Example;

public class CsvExporter : IDocumentExporter
{
    public void Export(Document document)
    {
        Console.WriteLine($"Exporting document {document.Title} to CSV format.");
    }
}
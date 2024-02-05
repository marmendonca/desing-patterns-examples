namespace DesingPatternsExamples.Criational.FactoryMethod.Example;

public class CsvExporterFactory : IDocumentExporterFactory
{
    public IDocumentExporter CreateExporter()
    {
        return new CsvExporter();
    }
}
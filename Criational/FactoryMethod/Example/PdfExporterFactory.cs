namespace DesingPatternsExamples.Criational.FactoryMethod.Example;

public class PdfExporterFactory : IDocumentExporterFactory
{
    public IDocumentExporter CreateExporter()
    {
        return new PdfExporter();
    }
}
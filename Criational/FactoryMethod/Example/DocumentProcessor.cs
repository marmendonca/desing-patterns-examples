namespace DesingPatternsExamples.Criational.FactoryMethod.Example;

public class DocumentProcessor
{
    public void ProcessDocument(IDocumentExporterFactory exporterFactory, Document document)
    {
        IDocumentExporter exporter = exporterFactory.CreateExporter();
        exporter.Export(document);
    }
}
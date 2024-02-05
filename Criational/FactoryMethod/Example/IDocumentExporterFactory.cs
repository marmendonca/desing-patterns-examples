namespace DesingPatternsExamples.Criational.FactoryMethod.Example;

public interface IDocumentExporterFactory
{
    IDocumentExporter CreateExporter();
}
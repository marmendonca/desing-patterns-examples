using DesingPatternsExamples.Criational.FactoryMethod.Example;

class Program
{
    static void Main()
    {
        # region Singleton
        // using DesingPatternsExamples.Criational.Singleton;
        //
        // var dbConnection = DatabaseConnection.GetInstance();

        // Execução de uma consulta usando a instância Singleton.
        //dbConnection.ExecuteQuery("SELECT * FROM Users");

        // Tentativa de criar uma nova instância usando o construtor privado resultará na obtenção da mesma instância existente.
        // var sameConnection = DatabaseConnection.GetInstance();
        //
        // var isSameConnection = Equals(dbConnection.ConnectionString, sameConnection.ConnectionString);

        // Verificação se são a mesma instância.
        //Console.WriteLine("Are both connections the same? " + isSameConnection);
        # endregion
        
        # region Factory Method
        // Cliente usa o Factory Method para criar exportadores de documentos.
        //DocumentProcessor processor = new DocumentProcessor();

        // Criando um documento.
        //Document document = new Document("Sample Document");

        // Utilizando a fábrica de PDF para exportar o documento.
        // PdfExporterFactory pdfFactory = new PdfExporterFactory();
        // processor.ProcessDocument(pdfFactory, document);

        // Utilizando a fábrica de CSV para exportar o documento.
        // CsvExporterFactory csvFactory = new CsvExporterFactory();
        // processor.ProcessDocument(csvFactory, document);
        #endregion
    }
}


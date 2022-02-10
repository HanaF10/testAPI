using testAPI.DTO;

namespace testAPI.testData.Repositories
{
    public interface IDocumentRepository
    {
        public int SaveDocument(CreateDocReqDTO doc);
    }
    public class DocumentRepository : IDocumentRepository
    {
        public int SaveDocument(CreateDocReqDTO doc)
        {
            throw new NotImplementedException();
        }
    }
}

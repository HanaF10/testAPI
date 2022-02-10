using testAPI.DTO;
using testAPI.testCore.Helpers;
using testAPI.testData.Repositories;

namespace testAPI.testCore.Services
{
    public interface IDocumentService
    {
        public void SaveDocument(CreateDocReqDTO doc);
    }
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;
        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
        public void SaveDocument(CreateDocReqDTO doc)
        {
            if (IsFileSizeExceed100MB(doc.Size,doc.SizeType))
                EmailHelper.SendMail();
            _documentRepository.SaveDocument(doc);

        }

        public bool IsFileSizeExceed100MB(double fileSize, int sizeType)
        {
            //based on sizeType represents numbers from 1-3, see enum
            var calculatedSize =Math.Pow(1024 , sizeType)*fileSize;
            double mb = 1024 * 1024;//1 mb
            return (calculatedSize / mb) > 100;
        }
        public enum FileSizeType
        {
            KB = 1,
            MB = 2,
            GB = 3,
        }
    }


}

namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;


public class DcFileService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcFileService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Файлы    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<FileData> ListAllDcFileData()
    {
        List<FileData>? FileDataList = _db.FileData?.ToList();
        return FileDataList;
    }

    public void CreateFileModel(FileData objFileModel)
    {
        _db.FileData?.Add(objFileModel);
        _db.SaveChanges();
        return;
    }

    public FileData GetFileDataInfoById(int ID)
    {

        return _db.FileData.FirstOrDefault(s => s.FileId == ID);

        /*
        if (FileDataInfo == null)
        {
            FileData FileDataDefaultInfo = new FileData();
            FileDataDefaultInfo.FileId = ID;
            FileDataDefaultInfo.FileName = "no files";
//            FileDataDefaultInfo.UploadDate = null;
//            FileDataDefaultInfo.LastChangeDate = ;
            FileDataDefaultInfo.FilePath = "";
            return FileDataDefaultInfo;
        }

        else return FileDataInfo;
        */
    }

    public List<FileData> ListFilesOfSpecificCategory()
    {
        List<FileData>? SelectedFileList = _db.FileData.Where(s => (s.FileCategory == "Детали") && (s.IsAppliedToTable == false)).ToList();
        //List<FileData>? SelectedFileList = _db.FileData.Where(s =>  s.IsAppliedToTable == false).ToList();
        return SelectedFileList;
    }


    public void UpdateEntityModelInfo(FileData objFileModel)
    {
        objFileModel.IsAppliedToTable = true;
        _db.SaveChanges();
        return;
    }

}


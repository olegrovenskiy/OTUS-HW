

namespace TspuWebPortal.ORM;

using System.Linq;
using TspuWebPortal.Model;

    public class SiteDataService
    {
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly TspuDbContext _db;

        public SiteDataService(TspuDbContext db)
        {
            _db = db;
        }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~    ТСПУ   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void CreateSite (SiteData objSite)
        {
            _db.Sites?.Add(objSite);
            _db.SaveChanges();
            return;
        }
        
        public List<SiteData> GetAllSitesInfo()
        {
            var SiteList = _db.Sites?.ToList();
            return SiteList;
        }

        public SiteData GetSiteInfoById(int ID)
        {

            SiteData SiteInfo = _db.Sites.FirstOrDefault(s => s.ID == ID);

            if (SiteInfo == null)
            {
                SiteData DefaultInfo = new SiteData();
                DefaultInfo.ID = ID;
                DefaultInfo.Oper = "Не создан";
                DefaultInfo.SiteType = "Не создан";
                DefaultInfo.City = "Не создан";
                DefaultInfo.SiteType = "Не создан";
                DefaultInfo.Address = "Не создан";
                DefaultInfo.Links = "Не создан";
                return DefaultInfo;
            }

            else return SiteInfo;

        }

        public void UpdateSiteInfo(SiteData objSite)
        {
            _db.Sites?.Update(objSite);
            _db.SaveChanges();
            return;
        }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    ЦОДы    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public List<DcData> ListAllDcSites()
        {
            List <DcData>? SiteList = _db.DataCenters?.ToList();
            return SiteList;
        }


        public void CreateDc(DcData objDc)
        {
            _db.DataCenters?.Add(objDc);
            _db.SaveChanges();
            return;
        }


        public DcData GetDcInfoById(int ID)
        {

            DcData? DcInfo = _db.DataCenters?.FirstOrDefault(s => s.DataCenterId == ID);

            if (DcInfo == null)
            {
                DcData DcDefaultInfo = new DcData();
                DcDefaultInfo.DataCenterId = ID;
                DcDefaultInfo.DataCenterName = "Не создан";
                DcDefaultInfo.DataCenterAddress = "Не создан";
                return DcDefaultInfo;
            }

            else return DcInfo;

        }

        public void UpdateDcInfo(DcData objDcSite)
        {
            _db.DataCenters?.Update(objDcSite);
            _db.SaveChanges();
            return;
        }


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Помещения   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<RoomData> ListAllDcRooms()
        {
            List<RoomData>? RoomList = _db.Rooms?.ToList();
            return RoomList;
        }

    public List<RoomData> ListRoomsOnSpecificDataCenter(int ID)
    {
        //List<RoomData>? RoomList = _db.Rooms?.ToList();
        List<RoomData>? SelectedRoomList = _db.Rooms.Where(s => s.DataCenterId == ID).ToList();
        return SelectedRoomList;
    }


    public void CreateRoom(RoomData objRoom)
        {
            _db.Rooms?.Add(objRoom);
            _db.SaveChanges();
            return;
        }

        public RoomData GetRoomInfoById(int ID)
        {

            RoomData? RoomInfo = _db.Rooms?.FirstOrDefault(s => s.RoomId == ID);

            if (RoomInfo == null)
            {
                RoomData RoomDefaultInfo = new RoomData();
                RoomDefaultInfo.DataCenterId = ID;
                RoomDefaultInfo.RoomName = "Не создан";
                RoomDefaultInfo.RoomCoordinates = "Не создан";
                return RoomDefaultInfo;
            }

            else return RoomInfo;

        }

        public void UpdateRoomInfo(RoomData objDcRoom)
        {
            _db.Rooms?.Update(objDcRoom);
            _db.SaveChanges();
            return;
        }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Ряды    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<RowData> ListAllDcRows()
    {
        List<RowData>? RowList = _db.Rows?.ToList();
        return RowList;
    }

    public void CreateRow(RowData objRow)
    {
        _db.Rows?.Add(objRow);
        _db.SaveChanges();
        return;
    }

    public RowData GetRowInfoById(int ID)
    {

        RowData? RowInfo = _db.Rows?.FirstOrDefault(s => s.RowId == ID);

        if (RowInfo == null)
        {
            RowData RowDefaultInfo = new RowData();
            RowDefaultInfo.RowId = ID;
            RowDefaultInfo.RowNameDataCenter = "Не создан";
            RowDefaultInfo.RowNameAsbi = "Не создан";
            RowDefaultInfo.RoomId = 0;
            return RowDefaultInfo;
        }

        else return RowInfo;

    }

    public void UpdateRowInfo(RowData objDcRow)
    {
        _db.Rows?.Update(objDcRow);
        _db.SaveChanges();
        return;
    }

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Сущности    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<EntityModelData> ListAllDcEntityModels()
    {
        List<EntityModelData>? EntityModelList = _db.EntityModel?.ToList();
        return EntityModelList;
    }

    public void CreateEntityModel(EntityModelData objEntityModel)
    {
        _db.EntityModel?.Add(objEntityModel);
        _db.SaveChanges();
        return;
    }

    public EntityModelData GetEntityModelInfoById(int ID)
    {

        EntityModelData? EntityModelInfo = _db.EntityModel?.FirstOrDefault(s => s.EntityModelId == ID);

        if (EntityModelInfo == null)
        {
            EntityModelData EntityModelDefaultInfo = new EntityModelData();
            EntityModelDefaultInfo.EntityModelId = ID;
            EntityModelDefaultInfo.Vendor = "Не создан";
            EntityModelDefaultInfo.ModelType = "Не создан";
            EntityModelDefaultInfo.ModelName = "Не создан";
            EntityModelDefaultInfo.PartNumber = "Не создан";
            EntityModelDefaultInfo.NominalPower = 0;
            EntityModelDefaultInfo.MaximalPower = 0;
            return EntityModelDefaultInfo;
        }

        else return EntityModelInfo;

    }

    public void UpdateEntityModelInfo(EntityModelData objDcEntityModel)
    {
        _db.EntityModel?.Update(objDcEntityModel);
        _db.SaveChanges();
        return;
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

        FileData? FileDataInfo = _db.FileData?.FirstOrDefault(s => s.FileId == ID);

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

    }

    public List<FileData> ListFilesOfSpecificCategory()
    {
        List<FileData>? SelectedFileList = _db.FileData.Where(s => (s.FileCategory == "Детали") && (s.IsAppliedToTable == false)).ToList();
        //List<FileData>? SelectedFileList = _db.FileData.Where(s =>  s.IsAppliedToTable == false).ToList();
        return SelectedFileList;
    }


    public void FileInfoAppendedToDetailTable(FileData objFileModel)
    {
        objFileModel.IsAppliedToTable = true;
        _db.SaveChanges();
        return;
    }


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<InitialDetailTableData> ListAllDetailTableData()
    {
        List<InitialDetailTableData>? DetailTableDataList = _db.DetailTable?.ToList();
        return DetailTableDataList;
    }

    public void CreateDetailTableModel(InitialDetailTableData objDetailTableModel)
    {
        _db.DetailTable?.Add(objDetailTableModel);
        _db.SaveChanges();
        return;
    }

    public InitialDetailTableData GetDetailTableDataInfoById(int ID)
    {

        InitialDetailTableData? DetailTableDataInfo = _db.DetailTable?.FirstOrDefault(s => s.InitialDetailTableId == ID);

        if (DetailTableDataInfo == null)
        {
            InitialDetailTableData DetailTableDataDefaultInfo = new InitialDetailTableData();
            DetailTableDataInfo.InitialDetailTableId = ID;
            return DetailTableDataDefaultInfo;
        }

        else return DetailTableDataInfo;

    }

    public void UpdateDetailTableInfo(InitialDetailTableData objDetailTableModel)
    {
        
        _db.DetailTable?.Update(objDetailTableModel);
        _db.SaveChanges();
        return;
    }

}

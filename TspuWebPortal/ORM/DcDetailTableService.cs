namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

    public class DcDetailTableService
    {
        //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly TspuDbContext _db;

        public DcDetailTableService(TspuDbContext db)
        {
            _db = db;
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public List<DetailTableData> ListAllDetailTableData()
        {
            List<DetailTableData>? DetailTableDataList = _db.DetailTables?.ToList();
            return DetailTableDataList;
        }

        public void CreateDetailTableModel(DetailTableData objDetailTableModel)
        {
            _db.DetailTables?.Add(objDetailTableModel);
            _db.SaveChanges();
            return;
        }

        public DetailTableData GetDetailTableDataInfoById(int ID)
        {

            DetailTableData? DetailTableDataInfo = _db.DetailTables?.FirstOrDefault(s => s.InitialDetailTableId == ID);

            if (DetailTableDataInfo == null)
            {
                DetailTableData DetailTableDataDefaultInfo = new DetailTableData();
                DetailTableDataInfo.InitialDetailTableId = ID;
                return DetailTableDataDefaultInfo;
            }

            else return DetailTableDataInfo;

        }

        public void UpdateDetailTableInfo(DetailTableData objDetailTableModel)
        {

            _db.DetailTables?.Update(objDetailTableModel);
            _db.SaveChanges();
            return;
        }

    }

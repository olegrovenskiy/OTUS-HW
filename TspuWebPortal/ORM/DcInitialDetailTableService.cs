namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

    public class DcInitialDetailTableService
    {
        //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly TspuDbContext _db;

        public DcInitialDetailTableService(TspuDbContext db)
        {
            _db = db;
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

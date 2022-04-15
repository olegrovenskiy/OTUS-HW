namespace TspuWebPortal.ORM;
using System.Linq;
using TspuWebPortal.Model;

public class DcCardService
{
    //~~~~~~~~~~~~~~~~~~~~~~~~~~    Базовые настройки   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    private readonly TspuDbContext _db;

    public DcCardService(TspuDbContext db)
    {
        _db = db;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    Таблицы деталей    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public List<CardData> ListAllCardData()
    {
        List<CardData>? CardDataList = _db.Cards?.ToList();
        return CardDataList;
    }

    public void CreateCardModel(CardData objCardModel)
    {
        _db.Cards?.Add(objCardModel);
        _db.SaveChanges();
        return;
    }

    public CardData GetCardDataInfoById(int ID)
    {

        CardData? CardDataInfo = _db.Cards?.FirstOrDefault(s => s.CardId == ID);

        if (CardDataInfo == null)
        {
            CardData CardDataDefaultInfo = new CardData();
            CardDataInfo.CardId = ID;
            return CardDataDefaultInfo;
        }

        else return CardDataInfo;

    }

    public void UpdateCardInfo(CardData objCardModel)
    {

        _db.Cards?.Update(objCardModel);
        _db.SaveChanges();
        return;
    }

}

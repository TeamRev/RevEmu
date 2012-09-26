using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Revolution.Database.DAO.Repository.Interface;
using Revolution.Database.DAO.Repository;
using RevolutionDatabase.Tables;

namespace Revolution.Application.HabboHotel.Catalog.Controllers
{
    class CatalogItemController : IRepository<CatalogItemController>
    {
        #region Columns
        public int id { get; set; }
        public int pageId { get; set; }
        public string name { get; set; }
        public int credits { get; set; }
        public int pixels { get; set; }
        public int snow { get; set; }
        public int quantity { get; set; }
        #endregion

        #region Constructor
        public CatalogItemController(int itemId)
        {
            catalogitem item;

            using (var session = Application.DbManager.GetSessionFactory().OpenSession())
            {
                item = session.Get<catalogitem>(itemId);
            }

            this.id = id;
            this.pageId = pageId;
            this.name = item.name;
            this.credits = item.credits;
            this.pixels = item.pixels;
            this.snow = item.snow;
            this.quantity = item.quantity;

            
        }

        #endregion

        #region DAO
        public void SaveOrUpdate(CatalogItemController item)
        {
            new NHibernateRepository<CatalogItemController>().SaveOrUpdate(item);
        }

        public void Delete(CatalogItemController item)
        {
            new NHibernateRepository<CatalogItemController>().Delete(item);
        }
        #endregion
    }
}

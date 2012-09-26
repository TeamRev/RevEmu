using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Revolution.Application.HabboHotel.Catalog.Controllers;
using System.Collections;
using RevolutionDatabase.Tables;

namespace Revolution.Revision.R63B.Game.Catalog
{
    internal class CatalogPageController
    {
        #region Fields
        /// <summary>
        /// Id of the Catalog Page.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Name of the Catalog Page
        /// </summary>
        private readonly string _caption;

        /// <summary>
        /// Parentid of the Catalog Page
        /// </summary>
        private readonly int _parentid;

        private readonly int _icon;

        private readonly int _colour;

        //private readonly string _isDummyPage;

        private readonly string _template;

        private readonly ICollection<string> _pageStrings;
        private readonly ICollection<string> _pageStrings2;

        internal Hashtable ItemsTable;
        #endregion

        /// <summary>
        /// Gets the catalog page, by using the ID.
        /// </summary>

        internal CatalogPageController(int id, ref Hashtable CatalogItems)
        {
            catalogpage catalogpage;

            ItemsTable = new Hashtable();

            using (var session = Application.Application.DbManager.GetSessionFactory().OpenSession())
            {
                catalogpage = session.Get<catalogpage>(id);
            }

            _id = catalogpage.id;

            _caption = catalogpage.name;

            _parentid = catalogpage.parentId;

            _icon = catalogpage.iconImage;

            _colour = catalogpage.iconColor;

            _template = Convert.ToString(catalogpage.layout);

            List<string> strings1 = new List<string>();

            strings1.Add(catalogpage.imgHeadline);
            strings1.Add(catalogpage.imgTeaser);
            strings1.Add(catalogpage.special);

            _pageStrings = strings1;

            List<string> strings2 = new List<string>();

            strings2.Add(catalogpage.textOne);
            strings2.Add(catalogpage.textTwo);
            strings2.Add(catalogpage.textDetails);
            strings2.Add(catalogpage.textTeaser);

            _pageStrings2 = strings2;

            foreach (CatalogItemController Item in CatalogItems.Values)
            {
                if (Item.pageId == _id)
                    ItemsTable.Add(Item.id, Item);
            }
        }



        public int GetID()
        {
            return _id;
        }

        public string GetCaption()
        {
            return _caption;
        }

        public int GetParentid()
        {

            return _parentid; 
        }

        public int GetIcon()
        {
            return _icon;
        }

        public int GetIconColor()
        {
            return _colour;
        }

        public string GetPageTemplate()
        {
            return _template;
        }

        public ICollection<string> GetPageStrings1()
        {
            return _pageStrings;
        }

        public ICollection<string> GetPageStrings2()
        {
            return _pageStrings2;
        }

        internal CatalogItemController GetItem(int pageId)
        {
            if (ItemsTable.ContainsKey(pageId))
                return (CatalogItemController)ItemsTable[pageId];

            return null;
        }
    }
}

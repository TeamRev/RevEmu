using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Revolution.Revision.R63B.Game.Catalog;
using Mango.Communication.Sessions;
using Revolution.Core;
using Revolution.Application.HabboHotel.Catalog.Controllers;
using Revolution.Revision.R63.Game.Habbo.Controller;

namespace Revolution.Application.HabboHotel.Catalog
{
    class Catalog
    {
        private Dictionary<int, CatalogPageController> Pages = new Dictionary<int, CatalogPageController>();

        public CatalogPageController GetPage(int pageId)
        {
            // Invalid Page Id
            if (!Pages.ContainsKey(pageId))
            {
                return null;
            }

            // Return Current Page
            return Pages[pageId];
        }

        /// <summary>
        /// Handels the purchase for an object from the catalog.
        /// </summary>
        public void Purchase(Session session, Message message)
        {
            // Get pageId from Client.
            int pageId = message.NextInt32();

            // Get itemId from Client.
            int itemId = message.NextInt32();

            // Create a instance of CatalogItemController using the purchased item Id.
            CatalogItemController purchasedItem = new CatalogItemController(itemId);

            // Simple check.
            if (purchasedItem.pageId != pageId) // If Page id do not match
                return;

            // Remove credits based on Item cost.
            session.Habbo.credits -= purchasedItem.credits;

            message = new Message(11); // Change to CreditUpdate id.

            // Updates users credits.
            message.WriteString("" + session.Habbo.credits + ".0");

            session.SendPacket(message);

            session.Habbo.SaveOrUpdate(session.Habbo);
    
        }
    
    }
}

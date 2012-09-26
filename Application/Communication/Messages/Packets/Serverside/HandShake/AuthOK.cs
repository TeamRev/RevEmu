using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolution.Core;

namespace Revolution.Application.Messages.Packets.Serverside.HandShake
{
    class AuthOK
    {
        public Message Parse(Message instance)
        {
            // [0][0][0]'[3]ö[0][5]Login[0][6]socket[0]client.auth_ok[0][0][0][0][0][0][0][0][0][2][5][0][0][0][8]á[0][10]habbo_club[0][0][0][2][9]²[0][0][0][2][7][3][0][0][0]–[2][0][0]’2012-07-13 00:00,africaDesert;2012-07-16 00:00,;2012-07-20 00:00,africaSavannah;2012-07-23 00:00,;2012-07-27 00:00,africaJungle;2012-07-30 00:00,;[0][0][0][2][8]õ[0][0][0][10][0]Y[0][6]REQ001[0][0][0]}[2][0][0]y2012-07-09 00:00,africaDesertFurniPromo;2012-07-16 00:00,africaSavannahFurniPromo;2012-07-23 00:00,africaJungleFurniPromo[0][0][1]e[2][0][1]a2012-07-09 00:00,africaDesertSubmitPromo;2012-07-11 00:00,africaDesertVotePromo;2012-07-13 00:00,africaDesertQuests;2012-07-16 00:00,africaSavannahSubmitPromo;2012-07-18 00:00,africaSavannahVotePromo;2012-07-20 00:00,africaSavannahQuests;2012-07-23 00:00,africaJungleSubmitPromo;2012-07-25 00:00,africaJungleVotePromo;2012-07-27 00:00,africaJungleQuests[0][0][0]ß[2][0][0]Û2012-07-09 00:00,africaDesertRewards;2012-07-11 00:00,;2012-07-16 00:00,africaSavannahRewards;2012-07-18 00:00,concurrentUsersCompetition;2012-07-23 00:00,africaJungleRewards;2012-07-25 00:00,concurrentUsersCompetition;[0][0][0]_[2][0][0][2012-07-09 00:00,africaDesert;2012-07-16 00:00,africaSavannah;2012-07-23 00:00,africaJungle[0][0][0][2][0]ã[0][0][0][2][10][13]

            return instance;
        }
    }
}

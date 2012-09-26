namespace Revolution.Messages.Packets
{
    internal class RevcHeaders
    {
        #region Authentication

        public const uint ClientRelease = 4000;
        public const uint InitCrypto = 1850;
        public const uint InitRC4 = 1238;

        public const uint ClientSettings = 2002;
        public const uint ClientMachineId = 82;
        public const uint SSOTicket = 149;

        public const uint InitializeUserInformation = 700;

        public const uint CreateMyRoom = 1539;
        public const uint GroupInProfile = 59;
        public const uint GroupMembers = 190;
        public const uint Ping = 3410;
        public const uint Alert = 1974;
        public const uint ClubVIP = 2894;
        public const uint WatchProfile = 2261;
        public const uint AcceptFriendRequest = 1;
        public const uint OpenMessenger = 3108;
        public const uint OpenMessengerConsole = 191;
        public const uint SearchFriend = 4;
        public const uint SearchResultAdd = 7;
        public const uint SendConsoleMessage = 3460;
        public const uint ModerationUserInformation = 806;
        public const uint RoomModels = 957;
        public const uint InfoLoading = 1030;
        public const uint RoomLoading = 783;
        public const uint ShoutOnHotel = 134;
        public const uint TalkOnHotel = 3612;
        public const uint SnowWarTokens = 2371;
        public const uint SnowWarTopList = 1423;
        public const uint EnterOnRoom = 1964;
        public const uint Inventory = 1178;
        public const uint JoinQueue = 1675;
        public const uint Walk = 3418;
        // We are doing messenger now. So get the event ids.

        //I am Zak, and I am leaning on my board, rhyming...

        #endregion

        #region Catalogue
        public const uint CatalogPage = 10;
        public const uint Catalog = 11;
        #endregion

        #region Navigator

        public const uint FeaturedRooms = 523;
        public const uint NavigatorInit = 499;
        public const uint OwnRooms = 2344;

        #endregion
    }
}
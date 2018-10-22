namespace BinaryTools.Internal.Native.Enums
{
    internal enum CREDErrorCodes
    {
        NO_ERROR = 0,
        ERROR_NOT_FOUND = 1168,
        ERROR_NO_SUCH_LOGON_SESSION = 1312,
        ERROR_INVALID_PARAMETER = 87,
        ERROR_INVALID_FLAGS = 1004,
        ERROR_BAD_USERNAME = 2202,
        SCARD_E_NO_READERS_AVAILABLE = (int)(0x8010002E - 0x100000000),
        SCARD_E_NO_SMARTCARD = (int)(0x8010000C - 0x100000000),
        SCARD_W_REMOVED_CARD = (int)(0x80100069 - 0x100000000),
        SCARD_W_WRONG_CHV = (int)(0x8010006B - 0x100000000)
    }
}

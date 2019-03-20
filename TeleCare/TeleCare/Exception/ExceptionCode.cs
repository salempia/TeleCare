namespace TeleCare.CustomerException
{
    public enum ExceptionCode
    {
        UnAuthorized = 1001,
        NotFound = 1002,
        NullObject = 1003,
        SqlServerError = 1004,
        ServerError = 1005,
        IllegalParameters = 1006,
        DuplicateObject = 1007,
        Forbidden = 1008,
        IllegalPassword = 1009,
        NotStrongPassword = 1010,
        FileTypeError = 1011,
        PasswordEmpty = 1012,
        PasswordCouldNotEqual = 1013,
        FailedToDelete = 1014,
        DataConflict = 1015,
        AlreadyExisted = 1016,
        PasswordNotMeetRequirement = 1020,
        FailedExpirationDate = 1021,
        NoTicket = 1022,
        FailedToSendEmail = 1023,
        Locked = 1030,
        FeeScheduleUploadFailed = 1031,
        InvalidTicket = 1041,
        NonExistentTicket = 1042,
        ExpiredTicket = 1043,
        DisabledWebAccess = 1044,
        NoTrackingTypeInThisCategory = 1045,
        NoRenewalSubTypeInThisCatTypeCombination = 1046,
        NoCancellationSubTypeInThisCatTypeCombination = 1047,
        ExceededAllowedValue = 1048
    }
}
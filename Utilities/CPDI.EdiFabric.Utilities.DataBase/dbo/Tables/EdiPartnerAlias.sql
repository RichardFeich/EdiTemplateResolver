CREATE TABLE [dbo].[EdiPartnerAlias] (
    Id          INT IDENTITY PRIMARY KEY,
    RawId       NVARCHAR(64) NOT NULL,   -- raw ISA06/ISA08/GS02/GS03 value
    PartnerKey  NVARCHAR(64) NOT NULL,   -- normalized key used in mapping
    IsSender    BIT          NOT NULL DEFAULT(1),
    IsReceiver  BIT          NOT NULL DEFAULT(1)
);

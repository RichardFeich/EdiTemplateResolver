CREATE TABLE [dbo].[EdiTemplateMapping] (
    Id               INT IDENTITY PRIMARY KEY,
    PartnerKey       NVARCHAR(64)  NOT NULL,   -- normalized partner id (e.g., ISA06/ISA08 alias)
    VersionNorm      CHAR(6)       NOT NULL,   -- "004010","005010","006010"
    St01             CHAR(3)       NOT NULL,   -- "850","856","940","999", etc.
    TypeFullName     NVARCHAR(256) NOT NULL,   -- e.g., 'MyCompany.Templates.X12.ACE004010.TS850_ACE'
    AssemblyName     NVARCHAR(256) NULL,       -- optional: 'MyCompany.Templates.X12.ACE004010'
    AssemblyPath     NVARCHAR(512) NULL,       -- optional: absolute/relative path if not in probing path
    IsEnabled        BIT           NOT NULL DEFAULT(1),
    IsStrict         BIT           NOT NULL DEFAULT(0),  -- forbid fallback for this row
    Priority         INT           NOT NULL DEFAULT(100),-- lower=prefer
    EffectiveFromUtc DATETIME2     NULL,
    EffectiveToUtc   DATETIME2     NULL,
    CONSTRAINT UX_EdiTemplateMapping UNIQUE (PartnerKey, VersionNorm, St01, Priority)
);
